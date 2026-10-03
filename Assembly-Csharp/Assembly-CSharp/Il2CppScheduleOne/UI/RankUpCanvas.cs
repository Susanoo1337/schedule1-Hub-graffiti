using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Levelling;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200075A RID: 1882
	public class RankUpCanvas : MonoBehaviour
	{
		// Token: 0x0600B77A RID: 46970 RVA: 0x002F6F60 File Offset: 0x002F5160
		// Note: this type is marked as 'beforefieldinit'.
		static RankUpCanvas()
		{
			Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "RankUpCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr);
			RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<IsRunning>k__BackingField");
			RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<Order>k__BackingField");
			RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "OpenCloseAnim");
			RankUpCanvas.NativeFieldInfoPtr_RankUpAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "RankUpAnim");
			RankUpCanvas.NativeFieldInfoPtr_OldRankLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "OldRankLabel");
			RankUpCanvas.NativeFieldInfoPtr_NewRankLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "NewRankLabel");
			RankUpCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "Canvas");
			RankUpCanvas.NativeFieldInfoPtr_UIScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "UIScreen");
			RankUpCanvas.NativeFieldInfoPtr_LevelUpPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "LevelUpPanel");
			RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "UnlockedItemsContainer");
			RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "UnlockedItemsCanvasGroup");
			RankUpCanvas.NativeFieldInfoPtr_UnlockedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "UnlockedItems");
			RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ExtraUnlocksLabel");
			RankUpCanvas.NativeFieldInfoPtr_SoundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "SoundEffect");
			RankUpCanvas.NativeFieldInfoPtr_ProgressSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ProgressSlider");
			RankUpCanvas.NativeFieldInfoPtr_ProgressLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ProgressLabel");
			RankUpCanvas.NativeFieldInfoPtr_BlipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "BlipSound");
			RankUpCanvas.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ClickSound");
			RankUpCanvas.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "coroutine");
			RankUpCanvas.NativeFieldInfoPtr_queuedRankUps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "queuedRankUps");
			RankUpCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687318);
			RankUpCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687319);
			RankUpCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687320);
			RankUpCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687321);
			RankUpCanvas.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687322);
			RankUpCanvas.NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687323);
			RankUpCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687324);
			RankUpCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687325);
			RankUpCanvas.NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687326);
			RankUpCanvas.NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687327);
			RankUpCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100687328);
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x0600B77B RID: 46971 RVA: 0x002F71FC File Offset: 0x002F53FC
		// (set) Token: 0x0600B77C RID: 46972 RVA: 0x002F7238 File Offset: 0x002F5438
		public unsafe virtual bool IsRunning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x0600B77D RID: 46973 RVA: 0x002F7278 File Offset: 0x002F5478
		// (set) Token: 0x0600B77E RID: 46974 RVA: 0x002F72B4 File Offset: 0x002F54B4
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B77F RID: 46975 RVA: 0x002F72F4 File Offset: 0x002F54F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308262, XrefRangeEnd = 308300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x002F7328 File Offset: 0x002F5528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308300, XrefRangeEnd = 308306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueuePostSleepEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x002F735C File Offset: 0x002F555C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308306, XrefRangeEnd = 308395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x002F7390 File Offset: 0x002F5590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308395, XrefRangeEnd = 308409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x002F73C4 File Offset: 0x002F55C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308409, XrefRangeEnd = 308421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RankUp(FullRank oldRank, FullRank newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B784 RID: 46980 RVA: 0x002F7410 File Offset: 0x002F5610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308476, RefRangeEnd = 308477, XrefRangeStart = 308421, XrefRangeEnd = 308476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayRankupAnimation(FullRank oldRank, FullRank newRank, bool playSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x002F746C File Offset: 0x002F566C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308477, XrefRangeEnd = 308485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankUpCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x000552C1 File Offset: 0x000534C1
		public RankUpCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0600B787 RID: 46983 RVA: 0x002F74A8 File Offset: 0x002F56A8
		// (set) Token: 0x0600B788 RID: 46984 RVA: 0x000552CA File Offset: 0x000534CA
		public unsafe bool _IsRunning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField)) = value;
			}
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0600B789 RID: 46985 RVA: 0x002F74D0 File Offset: 0x002F56D0
		// (set) Token: 0x0600B78A RID: 46986 RVA: 0x000552E5 File Offset: 0x000534E5
		public unsafe int _Order_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField)) = value;
			}
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x0600B78B RID: 46987 RVA: 0x002F74F8 File Offset: 0x002F56F8
		// (set) Token: 0x0600B78C RID: 46988 RVA: 0x00055300 File Offset: 0x00053500
		public unsafe Animation OpenCloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0600B78D RID: 46989 RVA: 0x002F7528 File Offset: 0x002F5728
		// (set) Token: 0x0600B78E RID: 46990 RVA: 0x0005531F File Offset: 0x0005351F
		public unsafe Animation RankUpAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_RankUpAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_RankUpAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0600B78F RID: 46991 RVA: 0x002F7558 File Offset: 0x002F5758
		// (set) Token: 0x0600B790 RID: 46992 RVA: 0x0005533E File Offset: 0x0005353E
		public unsafe TextMeshProUGUI OldRankLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OldRankLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OldRankLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0600B791 RID: 46993 RVA: 0x002F7588 File Offset: 0x002F5788
		// (set) Token: 0x0600B792 RID: 46994 RVA: 0x0005535D File Offset: 0x0005355D
		public unsafe TextMeshProUGUI NewRankLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_NewRankLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_NewRankLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x0600B793 RID: 46995 RVA: 0x002F75B8 File Offset: 0x002F57B8
		// (set) Token: 0x0600B794 RID: 46996 RVA: 0x0005537C File Offset: 0x0005357C
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x0600B795 RID: 46997 RVA: 0x002F75E8 File Offset: 0x002F57E8
		// (set) Token: 0x0600B796 RID: 46998 RVA: 0x0005539B File Offset: 0x0005359B
		public unsafe UIScreen UIScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UIScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UIScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x0600B797 RID: 46999 RVA: 0x002F7618 File Offset: 0x002F5818
		// (set) Token: 0x0600B798 RID: 47000 RVA: 0x000553BA File Offset: 0x000535BA
		public unsafe UIPanel LevelUpPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_LevelUpPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_LevelUpPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x0600B799 RID: 47001 RVA: 0x002F7648 File Offset: 0x002F5848
		// (set) Token: 0x0600B79A RID: 47002 RVA: 0x000553D9 File Offset: 0x000535D9
		public unsafe GameObject UnlockedItemsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x0600B79B RID: 47003 RVA: 0x002F7678 File Offset: 0x002F5878
		// (set) Token: 0x0600B79C RID: 47004 RVA: 0x000553F8 File Offset: 0x000535F8
		public unsafe CanvasGroup UnlockedItemsCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x0600B79D RID: 47005 RVA: 0x002F76A8 File Offset: 0x002F58A8
		// (set) Token: 0x0600B79E RID: 47006 RVA: 0x00055417 File Offset: 0x00053617
		public unsafe Il2CppReferenceArray<RectTransform> UnlockedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x0600B79F RID: 47007 RVA: 0x002F76D8 File Offset: 0x002F58D8
		// (set) Token: 0x0600B7A0 RID: 47008 RVA: 0x00055436 File Offset: 0x00053636
		public unsafe TextMeshProUGUI ExtraUnlocksLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0600B7A1 RID: 47009 RVA: 0x002F7708 File Offset: 0x002F5908
		// (set) Token: 0x0600B7A2 RID: 47010 RVA: 0x00055455 File Offset: 0x00053655
		public unsafe AudioSourceController SoundEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_SoundEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_SoundEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x0600B7A3 RID: 47011 RVA: 0x002F7738 File Offset: 0x002F5938
		// (set) Token: 0x0600B7A4 RID: 47012 RVA: 0x00055474 File Offset: 0x00053674
		public unsafe Slider ProgressSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0600B7A5 RID: 47013 RVA: 0x002F7768 File Offset: 0x002F5968
		// (set) Token: 0x0600B7A6 RID: 47014 RVA: 0x00055493 File Offset: 0x00053693
		public unsafe TextMeshProUGUI ProgressLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0600B7A7 RID: 47015 RVA: 0x002F7798 File Offset: 0x002F5998
		// (set) Token: 0x0600B7A8 RID: 47016 RVA: 0x000554B2 File Offset: 0x000536B2
		public unsafe AudioSourceController BlipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_BlipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_BlipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x0600B7A9 RID: 47017 RVA: 0x002F77C8 File Offset: 0x002F59C8
		// (set) Token: 0x0600B7AA RID: 47018 RVA: 0x000554D1 File Offset: 0x000536D1
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ClickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x0600B7AB RID: 47019 RVA: 0x002F77F8 File Offset: 0x002F59F8
		// (set) Token: 0x0600B7AC RID: 47020 RVA: 0x000554F0 File Offset: 0x000536F0
		public unsafe Coroutine coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x0600B7AD RID: 47021 RVA: 0x002F7828 File Offset: 0x002F5A28
		// (set) Token: 0x0600B7AE RID: 47022 RVA: 0x0005550F File Offset: 0x0005370F
		public unsafe List<Tuple<FullRank, FullRank>> queuedRankUps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_queuedRankUps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<FullRank, FullRank>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_queuedRankUps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007E0B RID: 32267
		private static readonly IntPtr NativeFieldInfoPtr__IsRunning_k__BackingField;

		// Token: 0x04007E0C RID: 32268
		private static readonly IntPtr NativeFieldInfoPtr__Order_k__BackingField;

		// Token: 0x04007E0D RID: 32269
		private static readonly IntPtr NativeFieldInfoPtr_OpenCloseAnim;

		// Token: 0x04007E0E RID: 32270
		private static readonly IntPtr NativeFieldInfoPtr_RankUpAnim;

		// Token: 0x04007E0F RID: 32271
		private static readonly IntPtr NativeFieldInfoPtr_OldRankLabel;

		// Token: 0x04007E10 RID: 32272
		private static readonly IntPtr NativeFieldInfoPtr_NewRankLabel;

		// Token: 0x04007E11 RID: 32273
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007E12 RID: 32274
		private static readonly IntPtr NativeFieldInfoPtr_UIScreen;

		// Token: 0x04007E13 RID: 32275
		private static readonly IntPtr NativeFieldInfoPtr_LevelUpPanel;

		// Token: 0x04007E14 RID: 32276
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedItemsContainer;

		// Token: 0x04007E15 RID: 32277
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedItemsCanvasGroup;

		// Token: 0x04007E16 RID: 32278
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedItems;

		// Token: 0x04007E17 RID: 32279
		private static readonly IntPtr NativeFieldInfoPtr_ExtraUnlocksLabel;

		// Token: 0x04007E18 RID: 32280
		private static readonly IntPtr NativeFieldInfoPtr_SoundEffect;

		// Token: 0x04007E19 RID: 32281
		private static readonly IntPtr NativeFieldInfoPtr_ProgressSlider;

		// Token: 0x04007E1A RID: 32282
		private static readonly IntPtr NativeFieldInfoPtr_ProgressLabel;

		// Token: 0x04007E1B RID: 32283
		private static readonly IntPtr NativeFieldInfoPtr_BlipSound;

		// Token: 0x04007E1C RID: 32284
		private static readonly IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x04007E1D RID: 32285
		private static readonly IntPtr NativeFieldInfoPtr_coroutine;

		// Token: 0x04007E1E RID: 32286
		private static readonly IntPtr NativeFieldInfoPtr_queuedRankUps;

		// Token: 0x04007E1F RID: 32287
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007E20 RID: 32288
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0;

		// Token: 0x04007E21 RID: 32289
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04007E22 RID: 32290
		private static readonly IntPtr NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0;

		// Token: 0x04007E23 RID: 32291
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04007E24 RID: 32292
		private static readonly IntPtr NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0;

		// Token: 0x04007E25 RID: 32293
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0;

		// Token: 0x04007E26 RID: 32294
		private static readonly IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;

		// Token: 0x04007E27 RID: 32295
		private static readonly IntPtr NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0;

		// Token: 0x04007E28 RID: 32296
		private static readonly IntPtr NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0;

		// Token: 0x04007E29 RID: 32297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CF1 RID: 3313
		[ObfuscatedName("ScheduleOne.UI.RankUpCanvas+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F6B1 RID: 63153 RVA: 0x003B2CBC File Offset: 0x003B0EBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0>.NativeClassPtr);
				RankUpCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_progressDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0>.NativeClassPtr, "progressDisplays");
				RankUpCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				RankUpCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0>.NativeClassPtr, 100687329);
				RankUpCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0>.NativeClassPtr, 100687330);
			}

			// Token: 0x0600F6B2 RID: 63154 RVA: 0x003B2D38 File Offset: 0x003B0F38
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6B3 RID: 63155 RVA: 0x003B2D74 File Offset: 0x003B0F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308257, XrefRangeEnd = 308262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F6B4 RID: 63156 RVA: 0x00074A58 File Offset: 0x00072C58
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B04 RID: 19204
			// (get) Token: 0x0600F6B5 RID: 63157 RVA: 0x003B2DB4 File Offset: 0x003B0FB4
			// (set) Token: 0x0600F6B6 RID: 63158 RVA: 0x00074A61 File Offset: 0x00072C61
			public unsafe List<Tuple<FullRank, int, int>> progressDisplays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_progressDisplays);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<FullRank, int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_progressDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B05 RID: 19205
			// (get) Token: 0x0600F6B7 RID: 63159 RVA: 0x003B2DE4 File Offset: 0x003B0FE4
			// (set) Token: 0x0600F6B8 RID: 63160 RVA: 0x00074A80 File Offset: 0x00072C80
			public unsafe RankUpCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankUpCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6E0 RID: 42720
			private static readonly IntPtr NativeFieldInfoPtr_progressDisplays;

			// Token: 0x0400A6E1 RID: 42721
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A6E2 RID: 42722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6E3 RID: 42723
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E0F RID: 3599
			[ObfuscatedName("ScheduleOne.UI.RankUpCanvas+<>c__DisplayClass28_0+<<StartEvent>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique : Il2CppSystem.Object
			{
				// Token: 0x0601034C RID: 66380 RVA: 0x003D7868 File Offset: 0x003D5A68
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique()
				{
					Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0>.NativeClassPtr, "<<StartEvent>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr);
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>1__state");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>2__current");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>4__this");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<rankSoundPlayed>5__2");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>7__wrap2");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<progress>5__4");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<oldRank>5__5");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<newRank>5__6");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<startXP>5__7");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<endXP>5__8");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<lerpTime>5__9");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<xpForRank>5__10");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<blipSpacing>5__11");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<blipTime>5__12");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<i>5__13");
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100687331);
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100687332);
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100687333);
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100687334);
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100687335);
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100687336);
					RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100687337);
				}

				// Token: 0x0601034D RID: 66381 RVA: 0x003D7A4C File Offset: 0x003D5C4C
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601034E RID: 66382 RVA: 0x003D7A94 File Offset: 0x003D5C94
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308148, XrefRangeEnd = 308153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601034F RID: 66383 RVA: 0x003D7AC8 File Offset: 0x003D5CC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308153, XrefRangeEnd = 308249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06010350 RID: 66384 RVA: 0x003D7B04 File Offset: 0x003D5D04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308249, XrefRangeEnd = 308252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __m__Finally1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F46 RID: 20294
				// (get) Token: 0x06010351 RID: 66385 RVA: 0x003D7B38 File Offset: 0x003D5D38
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010352 RID: 66386 RVA: 0x003D7B78 File Offset: 0x003D5D78
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308252, XrefRangeEnd = 308257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F47 RID: 20295
				// (get) Token: 0x06010353 RID: 66387 RVA: 0x003D7BAC File Offset: 0x003D5DAC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010354 RID: 66388 RVA: 0x0007AF5A File Offset: 0x0007915A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F37 RID: 20279
				// (get) Token: 0x06010355 RID: 66389 RVA: 0x003D7BEC File Offset: 0x003D5DEC
				// (set) Token: 0x06010356 RID: 66390 RVA: 0x0007AF63 File Offset: 0x00079163
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F38 RID: 20280
				// (get) Token: 0x06010357 RID: 66391 RVA: 0x003D7C14 File Offset: 0x003D5E14
				// (set) Token: 0x06010358 RID: 66392 RVA: 0x0007AF7E File Offset: 0x0007917E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F39 RID: 20281
				// (get) Token: 0x06010359 RID: 66393 RVA: 0x003D7C44 File Offset: 0x003D5E44
				// (set) Token: 0x0601035A RID: 66394 RVA: 0x0007AF9D File Offset: 0x0007919D
				public unsafe RankUpCanvas.__c__DisplayClass28_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankUpCanvas.__c__DisplayClass28_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F3A RID: 20282
				// (get) Token: 0x0601035B RID: 66395 RVA: 0x003D7C74 File Offset: 0x003D5E74
				// (set) Token: 0x0601035C RID: 66396 RVA: 0x0007AFBC File Offset: 0x000791BC
				public unsafe bool _rankSoundPlayed_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2)) = value;
					}
				}

				// Token: 0x17004F3B RID: 20283
				// (get) Token: 0x0601035D RID: 66397 RVA: 0x003D7C9C File Offset: 0x003D5E9C
				// (set) Token: 0x0601035E RID: 66398 RVA: 0x0007AFD7 File Offset: 0x000791D7
				public List<Tuple<FullRank, int, int>>.Enumerator __7__wrap2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2);
						return new List<Tuple<FullRank, int, int>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Tuple<FullRank, int, int>>.Enumerator>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Tuple<FullRank, int, int>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17004F3C RID: 20284
				// (get) Token: 0x0601035F RID: 66399 RVA: 0x003D7CCC File Offset: 0x003D5ECC
				// (set) Token: 0x06010360 RID: 66400 RVA: 0x0007B005 File Offset: 0x00079205
				public unsafe Tuple<FullRank, int, int> _progress_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<FullRank, int, int>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F3D RID: 20285
				// (get) Token: 0x06010361 RID: 66401 RVA: 0x003D7CFC File Offset: 0x003D5EFC
				// (set) Token: 0x06010362 RID: 66402 RVA: 0x0007B024 File Offset: 0x00079224
				public unsafe FullRank _oldRank_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5)) = value;
					}
				}

				// Token: 0x17004F3E RID: 20286
				// (get) Token: 0x06010363 RID: 66403 RVA: 0x003D7D24 File Offset: 0x003D5F24
				// (set) Token: 0x06010364 RID: 66404 RVA: 0x0007B03F File Offset: 0x0007923F
				public unsafe FullRank _newRank_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6)) = value;
					}
				}

				// Token: 0x17004F3F RID: 20287
				// (get) Token: 0x06010365 RID: 66405 RVA: 0x003D7D4C File Offset: 0x003D5F4C
				// (set) Token: 0x06010366 RID: 66406 RVA: 0x0007B05A File Offset: 0x0007925A
				public unsafe int _startXP_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7)) = value;
					}
				}

				// Token: 0x17004F40 RID: 20288
				// (get) Token: 0x06010367 RID: 66407 RVA: 0x003D7D74 File Offset: 0x003D5F74
				// (set) Token: 0x06010368 RID: 66408 RVA: 0x0007B075 File Offset: 0x00079275
				public unsafe int _endXP_5__8
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8)) = value;
					}
				}

				// Token: 0x17004F41 RID: 20289
				// (get) Token: 0x06010369 RID: 66409 RVA: 0x003D7D9C File Offset: 0x003D5F9C
				// (set) Token: 0x0601036A RID: 66410 RVA: 0x0007B090 File Offset: 0x00079290
				public unsafe float _lerpTime_5__9
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9)) = value;
					}
				}

				// Token: 0x17004F42 RID: 20290
				// (get) Token: 0x0601036B RID: 66411 RVA: 0x003D7DC4 File Offset: 0x003D5FC4
				// (set) Token: 0x0601036C RID: 66412 RVA: 0x0007B0AB File Offset: 0x000792AB
				public unsafe int _xpForRank_5__10
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10)) = value;
					}
				}

				// Token: 0x17004F43 RID: 20291
				// (get) Token: 0x0601036D RID: 66413 RVA: 0x003D7DEC File Offset: 0x003D5FEC
				// (set) Token: 0x0601036E RID: 66414 RVA: 0x0007B0C6 File Offset: 0x000792C6
				public unsafe float _blipSpacing_5__11
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11)) = value;
					}
				}

				// Token: 0x17004F44 RID: 20292
				// (get) Token: 0x0601036F RID: 66415 RVA: 0x003D7E14 File Offset: 0x003D6014
				// (set) Token: 0x06010370 RID: 66416 RVA: 0x0007B0E1 File Offset: 0x000792E1
				public unsafe float _blipTime_5__12
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12)) = value;
					}
				}

				// Token: 0x17004F45 RID: 20293
				// (get) Token: 0x06010371 RID: 66417 RVA: 0x003D7E3C File Offset: 0x003D603C
				// (set) Token: 0x06010372 RID: 66418 RVA: 0x0007B0FC File Offset: 0x000792FC
				public unsafe float _i_5__13
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13)) = value;
					}
				}

				// Token: 0x0400AE81 RID: 44673
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AE82 RID: 44674
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AE83 RID: 44675
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AE84 RID: 44676
				private static readonly IntPtr NativeFieldInfoPtr__rankSoundPlayed_5__2;

				// Token: 0x0400AE85 RID: 44677
				private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

				// Token: 0x0400AE86 RID: 44678
				private static readonly IntPtr NativeFieldInfoPtr__progress_5__4;

				// Token: 0x0400AE87 RID: 44679
				private static readonly IntPtr NativeFieldInfoPtr__oldRank_5__5;

				// Token: 0x0400AE88 RID: 44680
				private static readonly IntPtr NativeFieldInfoPtr__newRank_5__6;

				// Token: 0x0400AE89 RID: 44681
				private static readonly IntPtr NativeFieldInfoPtr__startXP_5__7;

				// Token: 0x0400AE8A RID: 44682
				private static readonly IntPtr NativeFieldInfoPtr__endXP_5__8;

				// Token: 0x0400AE8B RID: 44683
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__9;

				// Token: 0x0400AE8C RID: 44684
				private static readonly IntPtr NativeFieldInfoPtr__xpForRank_5__10;

				// Token: 0x0400AE8D RID: 44685
				private static readonly IntPtr NativeFieldInfoPtr__blipSpacing_5__11;

				// Token: 0x0400AE8E RID: 44686
				private static readonly IntPtr NativeFieldInfoPtr__blipTime_5__12;

				// Token: 0x0400AE8F RID: 44687
				private static readonly IntPtr NativeFieldInfoPtr__i_5__13;

				// Token: 0x0400AE90 RID: 44688
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AE91 RID: 44689
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE92 RID: 44690
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AE93 RID: 44691
				private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

				// Token: 0x0400AE94 RID: 44692
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AE95 RID: 44693
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE96 RID: 44694
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x02000438 RID: 1080
	public class CasinoGameBetPanel : MonoBehaviour
	{
		// Token: 0x060060D3 RID: 24787 RVA: 0x001CA7B8 File Offset: 0x001C89B8
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGameBetPanel()
		{
			Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "CasinoGameBetPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr);
			CasinoGameBetPanel.NativeFieldInfoPtr__container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, "_container");
			CasinoGameBetPanel.NativeFieldInfoPtr__betTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, "_betTitleLabel");
			CasinoGameBetPanel.NativeFieldInfoPtr__betSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, "_betSlider");
			CasinoGameBetPanel.NativeFieldInfoPtr__betAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, "_betAmount");
			CasinoGameBetPanel.NativeFieldInfoPtr__readyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, "_readyButton");
			CasinoGameBetPanel.NativeFieldInfoPtr__readyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, "_readyLabel");
			CasinoGameBetPanel.NativeFieldInfoPtr__panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, "_panel");
			CasinoGameBetPanel.NativeFieldInfoPtr__gameController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, "_gameController");
			CasinoGameBetPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, 100676018);
			CasinoGameBetPanel.NativeMethodInfoPtr_Open_Public_Void_CasinoGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, 100676019);
			CasinoGameBetPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, 100676020);
			CasinoGameBetPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, 100676021);
			CasinoGameBetPanel.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, 100676022);
			CasinoGameBetPanel.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, 100676023);
			CasinoGameBetPanel.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, 100676024);
			CasinoGameBetPanel.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, 100676025);
			CasinoGameBetPanel.NativeMethodInfoPtr_ReadyToggled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, 100676026);
			CasinoGameBetPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr, 100676027);
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x001CA950 File Offset: 0x001C8B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205649, XrefRangeEnd = 205667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameBetPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x001CA984 File Offset: 0x001C8B84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205685, RefRangeEnd = 205687, XrefRangeStart = 205667, XrefRangeEnd = 205685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(CasinoGameController game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameBetPanel.NativeMethodInfoPtr_Open_Public_Void_CasinoGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x001CA9C8 File Offset: 0x001C8BC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205703, RefRangeEnd = 205705, XrefRangeStart = 205687, XrefRangeEnd = 205703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameBetPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x001CA9FC File Offset: 0x001C8BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205705, XrefRangeEnd = 205722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameBetPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x001CAA30 File Offset: 0x001C8C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205722, XrefRangeEnd = 205728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetSliderChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameBetPanel.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x001CAA70 File Offset: 0x001C8C70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205733, RefRangeEnd = 205736, XrefRangeStart = 205728, XrefRangeEnd = 205733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplayedBet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameBetPanel.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x001CAAA4 File Offset: 0x001C8CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205736, XrefRangeEnd = 205754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshReadyButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameBetPanel.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x001CAAD8 File Offset: 0x001C8CD8
		[CallerCount(0)]
		public unsafe float GetBetFromSliderValue(float sliderVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sliderVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameBetPanel.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x001CAB24 File Offset: 0x001C8D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205754, XrefRangeEnd = 205758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadyToggled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameBetPanel.NativeMethodInfoPtr_ReadyToggled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x001CAB58 File Offset: 0x001C8D58
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGameBetPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGameBetPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameBetPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x0002DBFB File Offset: 0x0002BDFB
		public CasinoGameBetPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x060060DF RID: 24799 RVA: 0x001CAB94 File Offset: 0x001C8D94
		// (set) Token: 0x060060E0 RID: 24800 RVA: 0x0002DC04 File Offset: 0x0002BE04
		public unsafe GameObject _container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x060060E1 RID: 24801 RVA: 0x001CABC4 File Offset: 0x001C8DC4
		// (set) Token: 0x060060E2 RID: 24802 RVA: 0x0002DC23 File Offset: 0x0002BE23
		public unsafe TextMeshProUGUI _betTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__betTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__betTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x060060E3 RID: 24803 RVA: 0x001CABF4 File Offset: 0x001C8DF4
		// (set) Token: 0x060060E4 RID: 24804 RVA: 0x0002DC42 File Offset: 0x0002BE42
		public unsafe Slider _betSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__betSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__betSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x060060E5 RID: 24805 RVA: 0x001CAC24 File Offset: 0x001C8E24
		// (set) Token: 0x060060E6 RID: 24806 RVA: 0x0002DC61 File Offset: 0x0002BE61
		public unsafe TextMeshProUGUI _betAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__betAmount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__betAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x060060E7 RID: 24807 RVA: 0x001CAC54 File Offset: 0x001C8E54
		// (set) Token: 0x060060E8 RID: 24808 RVA: 0x0002DC80 File Offset: 0x0002BE80
		public unsafe Button _readyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__readyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__readyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x060060E9 RID: 24809 RVA: 0x001CAC84 File Offset: 0x001C8E84
		// (set) Token: 0x060060EA RID: 24810 RVA: 0x0002DC9F File Offset: 0x0002BE9F
		public unsafe TextMeshProUGUI _readyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__readyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__readyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x060060EB RID: 24811 RVA: 0x001CACB4 File Offset: 0x001C8EB4
		// (set) Token: 0x060060EC RID: 24812 RVA: 0x0002DCBE File Offset: 0x0002BEBE
		public unsafe UIPanel _panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x060060ED RID: 24813 RVA: 0x001CACE4 File Offset: 0x001C8EE4
		// (set) Token: 0x060060EE RID: 24814 RVA: 0x0002DCDD File Offset: 0x0002BEDD
		public unsafe CasinoGameController _gameController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__gameController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGameController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameBetPanel.NativeFieldInfoPtr__gameController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042B8 RID: 17080
		private static readonly IntPtr NativeFieldInfoPtr__container;

		// Token: 0x040042B9 RID: 17081
		private static readonly IntPtr NativeFieldInfoPtr__betTitleLabel;

		// Token: 0x040042BA RID: 17082
		private static readonly IntPtr NativeFieldInfoPtr__betSlider;

		// Token: 0x040042BB RID: 17083
		private static readonly IntPtr NativeFieldInfoPtr__betAmount;

		// Token: 0x040042BC RID: 17084
		private static readonly IntPtr NativeFieldInfoPtr__readyButton;

		// Token: 0x040042BD RID: 17085
		private static readonly IntPtr NativeFieldInfoPtr__readyLabel;

		// Token: 0x040042BE RID: 17086
		private static readonly IntPtr NativeFieldInfoPtr__panel;

		// Token: 0x040042BF RID: 17087
		private static readonly IntPtr NativeFieldInfoPtr__gameController;

		// Token: 0x040042C0 RID: 17088
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040042C1 RID: 17089
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_CasinoGameController_0;

		// Token: 0x040042C2 RID: 17090
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040042C3 RID: 17091
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040042C4 RID: 17092
		private static readonly IntPtr NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0;

		// Token: 0x040042C5 RID: 17093
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0;

		// Token: 0x040042C6 RID: 17094
		private static readonly IntPtr NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0;

		// Token: 0x040042C7 RID: 17095
		private static readonly IntPtr NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0;

		// Token: 0x040042C8 RID: 17096
		private static readonly IntPtr NativeMethodInfoPtr_ReadyToggled_Private_Void_0;

		// Token: 0x040042C9 RID: 17097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

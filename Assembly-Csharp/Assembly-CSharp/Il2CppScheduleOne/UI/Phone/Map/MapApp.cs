using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Map
{
	// Token: 0x020007B0 RID: 1968
	public class MapApp : App<MapApp>
	{
		// Token: 0x0600BF6B RID: 49003 RVA: 0x0030F39C File Offset: 0x0030D59C
		// Note: this type is marked as 'beforefieldinit'.
		static MapApp()
		{
			Il2CppClassPointerStore<MapApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Map", "MapApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapApp>.NativeClassPtr);
			MapApp.NativeFieldInfoPtr_KeyMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "KeyMoveSpeed");
			MapApp.NativeFieldInfoPtr_ContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "ContentRect");
			MapApp.NativeFieldInfoPtr_PoIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "PoIContainer");
			MapApp.NativeFieldInfoPtr_HorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "HorizontalScrollbar");
			MapApp.NativeFieldInfoPtr_VerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "VerticalScrollbar");
			MapApp.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "BackgroundImage");
			MapApp.NativeFieldInfoPtr_LabelGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelGroup");
			MapApp.NativeFieldInfoPtr_MainMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "MainMapSprite");
			MapApp.NativeFieldInfoPtr_TutorialMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "TutorialMapSprite");
			MapApp.NativeFieldInfoPtr_LabelScrollMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelScrollMin");
			MapApp.NativeFieldInfoPtr_LabelScrollMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelScrollMax");
			MapApp.NativeFieldInfoPtr_uiScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "uiScreen");
			MapApp.NativeFieldInfoPtr_uiPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "uiPanel");
			MapApp.NativeFieldInfoPtr_SkipFocusPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "SkipFocusPlayer");
			MapApp.NativeFieldInfoPtr_opened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "opened");
			MapApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100688260);
			MapApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100688261);
			MapApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100688262);
			MapApp.NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100688263);
			MapApp.NativeMethodInfoPtr_SetupMapItem_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100688264);
			MapApp.NativeMethodInfoPtr_TeardownMapItem_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100688265);
			MapApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100688266);
		}

		// Token: 0x0600BF6C RID: 49004 RVA: 0x0030F584 File Offset: 0x0030D784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318179, XrefRangeEnd = 318189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF6D RID: 49005 RVA: 0x0030F5C0 File Offset: 0x0030D7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318189, XrefRangeEnd = 318238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF6E RID: 49006 RVA: 0x0030F60C File Offset: 0x0030D80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318238, XrefRangeEnd = 318251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF6F RID: 49007 RVA: 0x0030F648 File Offset: 0x0030D848
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 318257, RefRangeEnd = 318260, XrefRangeStart = 318251, XrefRangeEnd = 318257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusPosition(Vector2 anchoredPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref anchoredPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapApp.NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF70 RID: 49008 RVA: 0x0030F688 File Offset: 0x0030D888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318265, RefRangeEnd = 318266, XrefRangeStart = 318260, XrefRangeEnd = 318265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupMapItem(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapApp.NativeMethodInfoPtr_SetupMapItem_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF71 RID: 49009 RVA: 0x0030F6CC File Offset: 0x0030D8CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318271, RefRangeEnd = 318272, XrefRangeStart = 318266, XrefRangeEnd = 318271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TeardownMapItem(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapApp.NativeMethodInfoPtr_TeardownMapItem_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF72 RID: 49010 RVA: 0x0030F710 File Offset: 0x0030D910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318272, XrefRangeEnd = 318278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF73 RID: 49011 RVA: 0x0005980B File Offset: 0x00057A0B
		public MapApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x0600BF74 RID: 49012 RVA: 0x0030F74C File Offset: 0x0030D94C
		// (set) Token: 0x0600BF75 RID: 49013 RVA: 0x00059814 File Offset: 0x00057A14
		public unsafe static float KeyMoveSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapApp.NativeFieldInfoPtr_KeyMoveSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapApp.NativeFieldInfoPtr_KeyMoveSpeed, (void*)(&value));
			}
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x0600BF76 RID: 49014 RVA: 0x0030F768 File Offset: 0x0030D968
		// (set) Token: 0x0600BF77 RID: 49015 RVA: 0x00059822 File Offset: 0x00057A22
		public unsafe RectTransform ContentRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_ContentRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_ContentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x0600BF78 RID: 49016 RVA: 0x0030F798 File Offset: 0x0030D998
		// (set) Token: 0x0600BF79 RID: 49017 RVA: 0x00059841 File Offset: 0x00057A41
		public unsafe RectTransform PoIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_PoIContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_PoIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x0600BF7A RID: 49018 RVA: 0x0030F7C8 File Offset: 0x0030D9C8
		// (set) Token: 0x0600BF7B RID: 49019 RVA: 0x00059860 File Offset: 0x00057A60
		public unsafe Scrollbar HorizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_HorizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_HorizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x0600BF7C RID: 49020 RVA: 0x0030F7F8 File Offset: 0x0030D9F8
		// (set) Token: 0x0600BF7D RID: 49021 RVA: 0x0005987F File Offset: 0x00057A7F
		public unsafe Scrollbar VerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_VerticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_VerticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x0600BF7E RID: 49022 RVA: 0x0030F828 File Offset: 0x0030DA28
		// (set) Token: 0x0600BF7F RID: 49023 RVA: 0x0005989E File Offset: 0x00057A9E
		public unsafe Image BackgroundImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_BackgroundImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_BackgroundImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x0600BF80 RID: 49024 RVA: 0x0030F858 File Offset: 0x0030DA58
		// (set) Token: 0x0600BF81 RID: 49025 RVA: 0x000598BD File Offset: 0x00057ABD
		public unsafe CanvasGroup LabelGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x0600BF82 RID: 49026 RVA: 0x0030F888 File Offset: 0x0030DA88
		// (set) Token: 0x0600BF83 RID: 49027 RVA: 0x000598DC File Offset: 0x00057ADC
		public unsafe Sprite MainMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_MainMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_MainMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x0600BF84 RID: 49028 RVA: 0x0030F8B8 File Offset: 0x0030DAB8
		// (set) Token: 0x0600BF85 RID: 49029 RVA: 0x000598FB File Offset: 0x00057AFB
		public unsafe Sprite TutorialMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_TutorialMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_TutorialMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x0600BF86 RID: 49030 RVA: 0x0030F8E8 File Offset: 0x0030DAE8
		// (set) Token: 0x0600BF87 RID: 49031 RVA: 0x0005991A File Offset: 0x00057B1A
		public unsafe float LabelScrollMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMin)) = value;
			}
		}

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x0600BF88 RID: 49032 RVA: 0x0030F910 File Offset: 0x0030DB10
		// (set) Token: 0x0600BF89 RID: 49033 RVA: 0x00059935 File Offset: 0x00057B35
		public unsafe float LabelScrollMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMax)) = value;
			}
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x0600BF8A RID: 49034 RVA: 0x0030F938 File Offset: 0x0030DB38
		// (set) Token: 0x0600BF8B RID: 49035 RVA: 0x00059950 File Offset: 0x00057B50
		public unsafe UIScreen uiScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_uiScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_uiScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x0600BF8C RID: 49036 RVA: 0x0030F968 File Offset: 0x0030DB68
		// (set) Token: 0x0600BF8D RID: 49037 RVA: 0x0005996F File Offset: 0x00057B6F
		public unsafe UIMapPanel uiPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_uiPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIMapPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_uiPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x0600BF8E RID: 49038 RVA: 0x0030F998 File Offset: 0x0030DB98
		// (set) Token: 0x0600BF8F RID: 49039 RVA: 0x0005998E File Offset: 0x00057B8E
		public unsafe bool SkipFocusPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_SkipFocusPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_SkipFocusPlayer)) = value;
			}
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x0600BF90 RID: 49040 RVA: 0x0030F9C0 File Offset: 0x0030DBC0
		// (set) Token: 0x0600BF91 RID: 49041 RVA: 0x000599A9 File Offset: 0x00057BA9
		public unsafe bool opened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_opened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_opened)) = value;
			}
		}

		// Token: 0x04008308 RID: 33544
		private static readonly IntPtr NativeFieldInfoPtr_KeyMoveSpeed;

		// Token: 0x04008309 RID: 33545
		private static readonly IntPtr NativeFieldInfoPtr_ContentRect;

		// Token: 0x0400830A RID: 33546
		private static readonly IntPtr NativeFieldInfoPtr_PoIContainer;

		// Token: 0x0400830B RID: 33547
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalScrollbar;

		// Token: 0x0400830C RID: 33548
		private static readonly IntPtr NativeFieldInfoPtr_VerticalScrollbar;

		// Token: 0x0400830D RID: 33549
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundImage;

		// Token: 0x0400830E RID: 33550
		private static readonly IntPtr NativeFieldInfoPtr_LabelGroup;

		// Token: 0x0400830F RID: 33551
		private static readonly IntPtr NativeFieldInfoPtr_MainMapSprite;

		// Token: 0x04008310 RID: 33552
		private static readonly IntPtr NativeFieldInfoPtr_TutorialMapSprite;

		// Token: 0x04008311 RID: 33553
		private static readonly IntPtr NativeFieldInfoPtr_LabelScrollMin;

		// Token: 0x04008312 RID: 33554
		private static readonly IntPtr NativeFieldInfoPtr_LabelScrollMax;

		// Token: 0x04008313 RID: 33555
		private static readonly IntPtr NativeFieldInfoPtr_uiScreen;

		// Token: 0x04008314 RID: 33556
		private static readonly IntPtr NativeFieldInfoPtr_uiPanel;

		// Token: 0x04008315 RID: 33557
		private static readonly IntPtr NativeFieldInfoPtr_SkipFocusPlayer;

		// Token: 0x04008316 RID: 33558
		private static readonly IntPtr NativeFieldInfoPtr_opened;

		// Token: 0x04008317 RID: 33559
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04008318 RID: 33560
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04008319 RID: 33561
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400831A RID: 33562
		private static readonly IntPtr NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0;

		// Token: 0x0400831B RID: 33563
		private static readonly IntPtr NativeMethodInfoPtr_SetupMapItem_Public_Void_GameObject_0;

		// Token: 0x0400831C RID: 33564
		private static readonly IntPtr NativeMethodInfoPtr_TeardownMapItem_Public_Void_GameObject_0;

		// Token: 0x0400831D RID: 33565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

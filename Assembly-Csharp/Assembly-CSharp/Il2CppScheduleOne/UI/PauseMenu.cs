using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.State;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.UI.MainMenu;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000747 RID: 1863
	public class PauseMenu : Singleton<PauseMenu>
	{
		// Token: 0x0600B4D2 RID: 46290 RVA: 0x002EF150 File Offset: 0x002ED350
		// Note: this type is marked as 'beforefieldinit'.
		static PauseMenu()
		{
			Il2CppClassPointerStore<PauseMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PauseMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr);
			PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "<IsPaused>k__BackingField");
			PauseMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Canvas");
			PauseMenu.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Container");
			PauseMenu.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Screen");
			PauseMenu.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "State");
			PauseMenu.NativeFieldInfoPtr_TogglePauseAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "TogglePauseAction");
			PauseMenu.NativeFieldInfoPtr_CartelNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "CartelNameLabel");
			PauseMenu.NativeFieldInfoPtr_onPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "onPause");
			PauseMenu.NativeFieldInfoPtr_onResume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "onResume");
			PauseMenu.NativeFieldInfoPtr__togglePausePressedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "_togglePausePressedThisFrame");
			PauseMenu.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686989);
			PauseMenu.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686990);
			PauseMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686991);
			PauseMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686992);
			PauseMenu.NativeMethodInfoPtr_OnGameLoseFocus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686993);
			PauseMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686994);
			PauseMenu.NativeMethodInfoPtr_CanTogglePause_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686995);
			PauseMenu.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686996);
			PauseMenu.NativeMethodInfoPtr_PrepForScreenshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686997);
			PauseMenu.NativeMethodInfoPtr_UpdateCartelName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686998);
			PauseMenu.NativeMethodInfoPtr_CleanupScreenshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100686999);
			PauseMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100687000);
			PauseMenu.NativeMethodInfoPtr_CheckTogglePause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100687001);
			PauseMenu.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100687002);
			PauseMenu.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100687003);
			PauseMenu.NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100687004);
			PauseMenu.NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100687005);
			PauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100687006);
		}

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0600B4D3 RID: 46291 RVA: 0x002EF3B0 File Offset: 0x002ED5B0
		// (set) Token: 0x0600B4D4 RID: 46292 RVA: 0x002EF3EC File Offset: 0x002ED5EC
		public unsafe bool IsPaused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x002EF42C File Offset: 0x002ED62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304555, XrefRangeEnd = 304562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PauseMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D6 RID: 46294 RVA: 0x002EF468 File Offset: 0x002ED668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304562, XrefRangeEnd = 304609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PauseMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x002EF4A4 File Offset: 0x002ED6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304609, XrefRangeEnd = 304624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGameLoseFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_OnGameLoseFocus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x002EF4D8 File Offset: 0x002ED6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304624, XrefRangeEnd = 304633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D9 RID: 46297 RVA: 0x002EF51C File Offset: 0x002ED71C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 304641, RefRangeEnd = 304645, XrefRangeStart = 304633, XrefRangeEnd = 304641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanTogglePause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_CanTogglePause_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B4DA RID: 46298 RVA: 0x002EF558 File Offset: 0x002ED758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304645, XrefRangeEnd = 304679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PauseMenu.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x002EF594 File Offset: 0x002ED794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304679, XrefRangeEnd = 304681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepForScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_PrepForScreenshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DC RID: 46300 RVA: 0x002EF5C8 File Offset: 0x002ED7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304681, XrefRangeEnd = 304686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCartelName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_UpdateCartelName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DD RID: 46301 RVA: 0x002EF5FC File Offset: 0x002ED7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304686, XrefRangeEnd = 304688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_CleanupScreenshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DE RID: 46302 RVA: 0x002EF630 File Offset: 0x002ED830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304688, XrefRangeEnd = 304694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DF RID: 46303 RVA: 0x002EF664 File Offset: 0x002ED864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304694, XrefRangeEnd = 304697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTogglePause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_CheckTogglePause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4E0 RID: 46304 RVA: 0x002EF698 File Offset: 0x002ED898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304697, XrefRangeEnd = 304701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x002EF6CC File Offset: 0x002ED8CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304722, RefRangeEnd = 304724, XrefRangeStart = 304701, XrefRangeEnd = 304722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x002EF700 File Offset: 0x002ED900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304747, RefRangeEnd = 304748, XrefRangeStart = 304724, XrefRangeEnd = 304747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4E3 RID: 46307 RVA: 0x002EF734 File Offset: 0x002ED934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304748, XrefRangeEnd = 304760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StuckButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4E4 RID: 46308 RVA: 0x002EF768 File Offset: 0x002ED968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304760, XrefRangeEnd = 304772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PauseMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4E5 RID: 46309 RVA: 0x00053A52 File Offset: 0x00051C52
		public PauseMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x0600B4E6 RID: 46310 RVA: 0x002EF7A4 File Offset: 0x002ED9A4
		// (set) Token: 0x0600B4E7 RID: 46311 RVA: 0x00053A5B File Offset: 0x00051C5B
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x0600B4E8 RID: 46312 RVA: 0x002EF7CC File Offset: 0x002ED9CC
		// (set) Token: 0x0600B4E9 RID: 46313 RVA: 0x00053A76 File Offset: 0x00051C76
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0600B4EA RID: 46314 RVA: 0x002EF7FC File Offset: 0x002ED9FC
		// (set) Token: 0x0600B4EB RID: 46315 RVA: 0x00053A95 File Offset: 0x00051C95
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x0600B4EC RID: 46316 RVA: 0x002EF82C File Offset: 0x002EDA2C
		// (set) Token: 0x0600B4ED RID: 46317 RVA: 0x00053AB4 File Offset: 0x00051CB4
		public unsafe MenuScreen Screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x0600B4EE RID: 46318 RVA: 0x002EF85C File Offset: 0x002EDA5C
		// (set) Token: 0x0600B4EF RID: 46319 RVA: 0x00053AD3 File Offset: 0x00051CD3
		public unsafe MonoStateMachine State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x0600B4F0 RID: 46320 RVA: 0x002EF88C File Offset: 0x002EDA8C
		// (set) Token: 0x0600B4F1 RID: 46321 RVA: 0x00053AF2 File Offset: 0x00051CF2
		public unsafe InputActionReference TogglePauseAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_TogglePauseAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_TogglePauseAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x0600B4F2 RID: 46322 RVA: 0x002EF8BC File Offset: 0x002EDABC
		// (set) Token: 0x0600B4F3 RID: 46323 RVA: 0x00053B11 File Offset: 0x00051D11
		public unsafe TextMeshProUGUI CartelNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_CartelNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_CartelNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x0600B4F4 RID: 46324 RVA: 0x002EF8EC File Offset: 0x002EDAEC
		// (set) Token: 0x0600B4F5 RID: 46325 RVA: 0x00053B30 File Offset: 0x00051D30
		public unsafe PreallocatedAction onPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onPause);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PreallocatedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onPause), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x0600B4F6 RID: 46326 RVA: 0x002EF91C File Offset: 0x002EDB1C
		// (set) Token: 0x0600B4F7 RID: 46327 RVA: 0x00053B4F File Offset: 0x00051D4F
		public unsafe PreallocatedAction onResume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onResume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PreallocatedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onResume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0600B4F8 RID: 46328 RVA: 0x002EF94C File Offset: 0x002EDB4C
		// (set) Token: 0x0600B4F9 RID: 46329 RVA: 0x00053B6E File Offset: 0x00051D6E
		public unsafe bool _togglePausePressedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr__togglePausePressedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr__togglePausePressedThisFrame)) = value;
			}
		}

		// Token: 0x04007C5B RID: 31835
		private static readonly IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x04007C5C RID: 31836
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007C5D RID: 31837
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007C5E RID: 31838
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x04007C5F RID: 31839
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04007C60 RID: 31840
		private static readonly IntPtr NativeFieldInfoPtr_TogglePauseAction;

		// Token: 0x04007C61 RID: 31841
		private static readonly IntPtr NativeFieldInfoPtr_CartelNameLabel;

		// Token: 0x04007C62 RID: 31842
		private static readonly IntPtr NativeFieldInfoPtr_onPause;

		// Token: 0x04007C63 RID: 31843
		private static readonly IntPtr NativeFieldInfoPtr_onResume;

		// Token: 0x04007C64 RID: 31844
		private static readonly IntPtr NativeFieldInfoPtr__togglePausePressedThisFrame;

		// Token: 0x04007C65 RID: 31845
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x04007C66 RID: 31846
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0;

		// Token: 0x04007C67 RID: 31847
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007C68 RID: 31848
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007C69 RID: 31849
		private static readonly IntPtr NativeMethodInfoPtr_OnGameLoseFocus_Private_Void_0;

		// Token: 0x04007C6A RID: 31850
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04007C6B RID: 31851
		private static readonly IntPtr NativeMethodInfoPtr_CanTogglePause_Private_Boolean_0;

		// Token: 0x04007C6C RID: 31852
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04007C6D RID: 31853
		private static readonly IntPtr NativeMethodInfoPtr_PrepForScreenshot_Private_Void_0;

		// Token: 0x04007C6E RID: 31854
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCartelName_Private_Void_0;

		// Token: 0x04007C6F RID: 31855
		private static readonly IntPtr NativeMethodInfoPtr_CleanupScreenshot_Private_Void_0;

		// Token: 0x04007C70 RID: 31856
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007C71 RID: 31857
		private static readonly IntPtr NativeMethodInfoPtr_CheckTogglePause_Private_Void_0;

		// Token: 0x04007C72 RID: 31858
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007C73 RID: 31859
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04007C74 RID: 31860
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

		// Token: 0x04007C75 RID: 31861
		private static readonly IntPtr NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0;

		// Token: 0x04007C76 RID: 31862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

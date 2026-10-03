using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Networking;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Multiplayer
{
	// Token: 0x020007C0 RID: 1984
	public class LobbyInterface : Singleton<LobbyInterface>
	{
		// Token: 0x0600C2B9 RID: 49849 RVA: 0x00318BE4 File Offset: 0x00316DE4
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyInterface()
		{
			Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Multiplayer", "LobbyInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr);
			LobbyInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "Container");
			LobbyInterface.NativeFieldInfoPtr_LobbyTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "LobbyTitle");
			LobbyInterface.NativeFieldInfoPtr_PlayerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "PlayerSlots");
			LobbyInterface.NativeFieldInfoPtr_InviteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "InviteButton");
			LobbyInterface.NativeFieldInfoPtr_LeaveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "LeaveButton");
			LobbyInterface.NativeFieldInfoPtr_InviteHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "InviteHint");
			LobbyInterface.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "Panel");
			LobbyInterface.NativeFieldInfoPtr_AttachedScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "AttachedScreen");
			LobbyInterface.NativeMethodInfoPtr_get_Lobby_Private_get_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688597);
			LobbyInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688598);
			LobbyInterface.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688599);
			LobbyInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688600);
			LobbyInterface.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688601);
			LobbyInterface.NativeMethodInfoPtr_LeaveClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688602);
			LobbyInterface.NativeMethodInfoPtr_InviteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688603);
			LobbyInterface.NativeMethodInfoPtr_DisplayPlayer_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688604);
			LobbyInterface.NativeMethodInfoPtr_ClearPlayer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688605);
			LobbyInterface.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688606);
			LobbyInterface.NativeMethodInfoPtr_UpdateButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688607);
			LobbyInterface.NativeMethodInfoPtr_UpdatePlayers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688608);
			LobbyInterface.NativeMethodInfoPtr_AttachToScreen_Public_Void_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688609);
			LobbyInterface.NativeMethodInfoPtr_DetachFromScreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688610);
			LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100688611);
		}

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x0600C2BA RID: 49850 RVA: 0x00318DE0 File Offset: 0x00316FE0
		public unsafe Lobby Lobby
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 322473, RefRangeEnd = 322488, XrefRangeStart = 322470, XrefRangeEnd = 322473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_get_Lobby_Private_get_Lobby_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lobby>(intPtr3) : null;
			}
		}

		// Token: 0x0600C2BB RID: 49851 RVA: 0x00318E20 File Offset: 0x00317020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322488, XrefRangeEnd = 322528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2BC RID: 49852 RVA: 0x00318E5C File Offset: 0x0031705C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322528, XrefRangeEnd = 322555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyInterface.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x00318E98 File Offset: 0x00317098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322555, XrefRangeEnd = 322565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2BE RID: 49854 RVA: 0x00318ECC File Offset: 0x003170CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322565, XrefRangeEnd = 322568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2BF RID: 49855 RVA: 0x00318F0C File Offset: 0x0031710C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322568, XrefRangeEnd = 322571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_LeaveClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2C0 RID: 49856 RVA: 0x00318F40 File Offset: 0x00317140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322571, XrefRangeEnd = 322578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InviteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_InviteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2C1 RID: 49857 RVA: 0x00318F74 File Offset: 0x00317174
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322590, RefRangeEnd = 322592, XrefRangeStart = 322578, XrefRangeEnd = 322590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayPlayer(int index, string playerID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_DisplayPlayer_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2C2 RID: 49858 RVA: 0x00318FC4 File Offset: 0x003171C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322596, RefRangeEnd = 322597, XrefRangeStart = 322592, XrefRangeEnd = 322596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPlayer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_ClearPlayer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2C3 RID: 49859 RVA: 0x00319004 File Offset: 0x00317204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322642, RefRangeEnd = 322643, XrefRangeStart = 322597, XrefRangeEnd = 322642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2C4 RID: 49860 RVA: 0x00319038 File Offset: 0x00317238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322643, XrefRangeEnd = 322655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdateButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2C5 RID: 49861 RVA: 0x0031906C File Offset: 0x0031726C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322672, RefRangeEnd = 322673, XrefRangeStart = 322655, XrefRangeEnd = 322672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdatePlayers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2C6 RID: 49862 RVA: 0x003190A0 File Offset: 0x003172A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322682, RefRangeEnd = 322683, XrefRangeStart = 322673, XrefRangeEnd = 322682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachToScreen(UIScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AttachToScreen_Public_Void_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2C7 RID: 49863 RVA: 0x003190E4 File Offset: 0x003172E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322689, RefRangeEnd = 322690, XrefRangeStart = 322683, XrefRangeEnd = 322689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetachFromScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_DetachFromScreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2C8 RID: 49864 RVA: 0x00319118 File Offset: 0x00317318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322690, XrefRangeEnd = 322693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2C9 RID: 49865 RVA: 0x0005BB17 File Offset: 0x00059D17
		public LobbyInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x0600C2CA RID: 49866 RVA: 0x00319154 File Offset: 0x00317354
		// (set) Token: 0x0600C2CB RID: 49867 RVA: 0x0005BB20 File Offset: 0x00059D20
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x0600C2CC RID: 49868 RVA: 0x00319184 File Offset: 0x00317384
		// (set) Token: 0x0600C2CD RID: 49869 RVA: 0x0005BB3F File Offset: 0x00059D3F
		public unsafe TextMeshProUGUI LobbyTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LobbyTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LobbyTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x0600C2CE RID: 49870 RVA: 0x003191B4 File Offset: 0x003173B4
		// (set) Token: 0x0600C2CF RID: 49871 RVA: 0x0005BB5E File Offset: 0x00059D5E
		public unsafe Il2CppReferenceArray<RectTransform> PlayerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_PlayerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_PlayerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x0600C2D0 RID: 49872 RVA: 0x003191E4 File Offset: 0x003173E4
		// (set) Token: 0x0600C2D1 RID: 49873 RVA: 0x0005BB7D File Offset: 0x00059D7D
		public unsafe Button InviteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x0600C2D2 RID: 49874 RVA: 0x00319214 File Offset: 0x00317414
		// (set) Token: 0x0600C2D3 RID: 49875 RVA: 0x0005BB9C File Offset: 0x00059D9C
		public unsafe Button LeaveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LeaveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LeaveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x0600C2D4 RID: 49876 RVA: 0x00319244 File Offset: 0x00317444
		// (set) Token: 0x0600C2D5 RID: 49877 RVA: 0x0005BBBB File Offset: 0x00059DBB
		public unsafe GameObject InviteHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x0600C2D6 RID: 49878 RVA: 0x00319274 File Offset: 0x00317474
		// (set) Token: 0x0600C2D7 RID: 49879 RVA: 0x0005BBDA File Offset: 0x00059DDA
		public unsafe UIPanel Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x0600C2D8 RID: 49880 RVA: 0x003192A4 File Offset: 0x003174A4
		// (set) Token: 0x0600C2D9 RID: 49881 RVA: 0x0005BBF9 File Offset: 0x00059DF9
		public unsafe UIScreen AttachedScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_AttachedScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_AttachedScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400850E RID: 34062
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400850F RID: 34063
		private static readonly IntPtr NativeFieldInfoPtr_LobbyTitle;

		// Token: 0x04008510 RID: 34064
		private static readonly IntPtr NativeFieldInfoPtr_PlayerSlots;

		// Token: 0x04008511 RID: 34065
		private static readonly IntPtr NativeFieldInfoPtr_InviteButton;

		// Token: 0x04008512 RID: 34066
		private static readonly IntPtr NativeFieldInfoPtr_LeaveButton;

		// Token: 0x04008513 RID: 34067
		private static readonly IntPtr NativeFieldInfoPtr_InviteHint;

		// Token: 0x04008514 RID: 34068
		private static readonly IntPtr NativeFieldInfoPtr_Panel;

		// Token: 0x04008515 RID: 34069
		private static readonly IntPtr NativeFieldInfoPtr_AttachedScreen;

		// Token: 0x04008516 RID: 34070
		private static readonly IntPtr NativeMethodInfoPtr_get_Lobby_Private_get_Lobby_0;

		// Token: 0x04008517 RID: 34071
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04008518 RID: 34072
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04008519 RID: 34073
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400851A RID: 34074
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x0400851B RID: 34075
		private static readonly IntPtr NativeMethodInfoPtr_LeaveClicked_Public_Void_0;

		// Token: 0x0400851C RID: 34076
		private static readonly IntPtr NativeMethodInfoPtr_InviteClicked_Public_Void_0;

		// Token: 0x0400851D RID: 34077
		private static readonly IntPtr NativeMethodInfoPtr_DisplayPlayer_Private_Void_Int32_String_0;

		// Token: 0x0400851E RID: 34078
		private static readonly IntPtr NativeMethodInfoPtr_ClearPlayer_Private_Void_Int32_0;

		// Token: 0x0400851F RID: 34079
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04008520 RID: 34080
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtons_Private_Void_0;

		// Token: 0x04008521 RID: 34081
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayers_Private_Void_0;

		// Token: 0x04008522 RID: 34082
		private static readonly IntPtr NativeMethodInfoPtr_AttachToScreen_Public_Void_UIScreen_0;

		// Token: 0x04008523 RID: 34083
		private static readonly IntPtr NativeMethodInfoPtr_DetachFromScreen_Public_Void_0;

		// Token: 0x04008524 RID: 34084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Gamepad;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000174 RID: 372
	public class Clickable : MonoBehaviour
	{
		// Token: 0x0600256B RID: 9579 RVA: 0x000F7278 File Offset: 0x000F5478
		// Note: this type is marked as 'beforefieldinit'.
		static Clickable()
		{
			Il2CppClassPointerStore<Clickable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Clickable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clickable>.NativeClassPtr);
			Clickable.NativeFieldInfoPtr_ClickableEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "ClickableEnabled");
			Clickable.NativeFieldInfoPtr_AutoCalculateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "AutoCalculateOffset");
			Clickable.NativeFieldInfoPtr_FlattenZOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "FlattenZOffset");
			Clickable.NativeFieldInfoPtr__gamepadLure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "_gamepadLure");
			Clickable.NativeFieldInfoPtr__gamepadLureLocationOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "_gamepadLureLocationOverride");
			Clickable.NativeFieldInfoPtr_onClickStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "onClickStart");
			Clickable.NativeFieldInfoPtr_onClickEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "onClickEnd");
			Clickable.NativeFieldInfoPtr__isLureActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "_isLureActive");
			Clickable.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			Clickable.NativeFieldInfoPtr__originalHitPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<originalHitPoint>k__BackingField");
			Clickable.NativeFieldInfoPtr__LurePositionOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<LurePositionOffset>k__BackingField");
			Clickable.NativeFieldInfoPtr__IsHeld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<IsHeld>k__BackingField");
			Clickable.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_New_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668156);
			Clickable.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_New_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668157);
			Clickable.NativeMethodInfoPtr_get_originalHitPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668158);
			Clickable.NativeMethodInfoPtr_set_originalHitPoint_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668159);
			Clickable.NativeMethodInfoPtr_get_GamepadLure_Public_get_IGamepadPointerLure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668160);
			Clickable.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668161);
			Clickable.NativeMethodInfoPtr_get_LurePositionOffset_Protected_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668162);
			Clickable.NativeMethodInfoPtr_set_LurePositionOffset_Protected_Virtual_New_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668163);
			Clickable.NativeMethodInfoPtr_get_IsHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668164);
			Clickable.NativeMethodInfoPtr_set_IsHeld_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668165);
			Clickable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Data_Private_Virtual_Final_New_get_GamepadPointerLureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668166);
			Clickable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_IsActive_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668167);
			Clickable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Position_Private_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668168);
			Clickable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Offset_Private_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668169);
			Clickable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668170);
			Clickable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668171);
			Clickable.NativeMethodInfoPtr_StartClick_Public_Virtual_New_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668172);
			Clickable.NativeMethodInfoPtr_EndClick_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668173);
			Clickable.NativeMethodInfoPtr_SetOriginalHitPoint_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668174);
			Clickable.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668175);
			Clickable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_SetActive_Private_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668176);
			Clickable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668177);
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000F7550 File Offset: 0x000F5750
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x000F7598 File Offset: 0x000F5798
		public unsafe virtual CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 44533, RefRangeEnd = 44544, XrefRangeStart = 44533, XrefRangeEnd = 44544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_New_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 44544, RefRangeEnd = 44553, XrefRangeStart = 44544, XrefRangeEnd = 44553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_New_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x000F75E4 File Offset: 0x000F57E4
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x000F7620 File Offset: 0x000F5820
		public unsafe Vector3 originalHitPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_originalHitPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 115486, RefRangeEnd = 115488, XrefRangeStart = 115486, XrefRangeEnd = 115486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_set_originalHitPoint_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x000F7660 File Offset: 0x000F5860
		public unsafe IGamepadPointerLure GamepadLure
		{
			[CallerCount(1485)]
			[CachedScanResults(RefRangeStart = 115488, RefRangeEnd = 116973, XrefRangeStart = 115488, XrefRangeEnd = 115488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_GamepadLure_Public_get_IGamepadPointerLure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGamepadPointerLure>(intPtr3) : null;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x000F76A0 File Offset: 0x000F58A0
		public unsafe virtual bool RegisterDefaultLureWhenEmpty
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x000F76E8 File Offset: 0x000F58E8
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x000F7730 File Offset: 0x000F5930
		public unsafe virtual Vector3 LurePositionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_get_LurePositionOffset_Protected_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_set_LurePositionOffset_Protected_Virtual_New_set_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000F777C File Offset: 0x000F597C
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x000F77B8 File Offset: 0x000F59B8
		public unsafe bool IsHeld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_IsHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_set_IsHeld_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000F77F8 File Offset: 0x000F59F8
		public unsafe virtual GamepadPointerLureData Data
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Data_Private_Virtual_Final_New_get_GamepadPointerLureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GamepadPointerLureData>(intPtr3) : null;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x000F7838 File Offset: 0x000F5A38
		public unsafe virtual bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_IsActive_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x000F7874 File Offset: 0x000F5A74
		public unsafe virtual Vector3 Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116973, XrefRangeEnd = 116978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Position_Private_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002579 RID: 9593 RVA: 0x000F78B0 File Offset: 0x000F5AB0
		public unsafe virtual Vector3 Offset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Offset_Private_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000F78EC File Offset: 0x000F5AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116978, XrefRangeEnd = 116983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000F7920 File Offset: 0x000F5B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116983, XrefRangeEnd = 117001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x000F795C File Offset: 0x000F5B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117004, RefRangeEnd = 117006, XrefRangeStart = 117001, XrefRangeEnd = 117004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_StartClick_Public_Virtual_New_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000F79A8 File Offset: 0x000F5BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117006, XrefRangeEnd = 117007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_EndClick_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000F79E4 File Offset: 0x000F5BE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115486, RefRangeEnd = 115488, XrefRangeStart = 115486, XrefRangeEnd = 115488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOriginalHitPoint(Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_SetOriginalHitPoint_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000F7A24 File Offset: 0x000F5C24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117016, RefRangeEnd = 117017, XrefRangeStart = 117007, XrefRangeEnd = 117016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000F7A60 File Offset: 0x000F5C60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 46711, RefRangeEnd = 46714, XrefRangeStart = 46711, XrefRangeEnd = 46714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ScheduleOne_Gamepad_IGamepadPointerLure_SetActive(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_SetActive_Private_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000F7AA0 File Offset: 0x000F5CA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117020, RefRangeEnd = 117022, XrefRangeStart = 117017, XrefRangeEnd = 117020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Clickable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Clickable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00013B16 File Offset: 0x00011D16
		public Clickable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x000F7ADC File Offset: 0x000F5CDC
		// (set) Token: 0x06002584 RID: 9604 RVA: 0x00013B1F File Offset: 0x00011D1F
		public unsafe bool ClickableEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_ClickableEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_ClickableEnabled)) = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x000F7B04 File Offset: 0x000F5D04
		// (set) Token: 0x06002586 RID: 9606 RVA: 0x00013B3A File Offset: 0x00011D3A
		public unsafe bool AutoCalculateOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_AutoCalculateOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_AutoCalculateOffset)) = value;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x000F7B2C File Offset: 0x000F5D2C
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x00013B55 File Offset: 0x00011D55
		public unsafe bool FlattenZOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_FlattenZOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_FlattenZOffset)) = value;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x000F7B54 File Offset: 0x000F5D54
		// (set) Token: 0x0600258A RID: 9610 RVA: 0x00013B70 File Offset: 0x00011D70
		public unsafe GamepadPointerLureData _gamepadLure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__gamepadLure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadPointerLureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__gamepadLure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x000F7B84 File Offset: 0x000F5D84
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x00013B8F File Offset: 0x00011D8F
		public unsafe Transform _gamepadLureLocationOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__gamepadLureLocationOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__gamepadLureLocationOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x000F7BB4 File Offset: 0x000F5DB4
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x00013BAE File Offset: 0x00011DAE
		public unsafe UnityEvent<RaycastHit> onClickStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x000F7BE4 File Offset: 0x000F5DE4
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x00013BCD File Offset: 0x00011DCD
		public unsafe UnityEvent onClickEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x000F7C14 File Offset: 0x000F5E14
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x00013BEC File Offset: 0x00011DEC
		public unsafe bool _isLureActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__isLureActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__isLureActive)) = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x000F7C3C File Offset: 0x000F5E3C
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x00013C07 File Offset: 0x00011E07
		public unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x000F7C64 File Offset: 0x000F5E64
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x00013C22 File Offset: 0x00011E22
		public unsafe Vector3 _originalHitPoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__originalHitPoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__originalHitPoint_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x000F7C8C File Offset: 0x000F5E8C
		// (set) Token: 0x06002598 RID: 9624 RVA: 0x00013C3D File Offset: 0x00011E3D
		public unsafe Vector3 _LurePositionOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__LurePositionOffset_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__LurePositionOffset_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x000F7CB4 File Offset: 0x000F5EB4
		// (set) Token: 0x0600259A RID: 9626 RVA: 0x00013C58 File Offset: 0x00011E58
		public unsafe bool _IsHeld_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__IsHeld_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__IsHeld_k__BackingField)) = value;
			}
		}

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeFieldInfoPtr_ClickableEnabled;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeFieldInfoPtr_AutoCalculateOffset;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeFieldInfoPtr_FlattenZOffset;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeFieldInfoPtr__gamepadLure;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeFieldInfoPtr__gamepadLureLocationOverride;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeFieldInfoPtr_onClickStart;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeFieldInfoPtr_onClickEnd;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeFieldInfoPtr__isLureActive;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeFieldInfoPtr__originalHitPoint_k__BackingField;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeFieldInfoPtr__LurePositionOffset_k__BackingField;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeFieldInfoPtr__IsHeld_k__BackingField;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_New_get_ECursorType_0;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_New_set_Void_ECursorType_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_get_originalHitPoint_Public_get_Vector3_0;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeMethodInfoPtr_set_originalHitPoint_Protected_set_Void_Vector3_0;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeMethodInfoPtr_get_GamepadLure_Public_get_IGamepadPointerLure_0;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeMethodInfoPtr_get_LurePositionOffset_Protected_Virtual_New_get_Vector3_0;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeMethodInfoPtr_set_LurePositionOffset_Protected_Virtual_New_set_Void_Vector3_0;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHeld_Public_get_Boolean_0;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHeld_Protected_set_Void_Boolean_0;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Data_Private_Virtual_Final_New_get_GamepadPointerLureData_0;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_IsActive_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Position_Private_Virtual_Final_New_get_Vector3_0;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Offset_Private_Virtual_Final_New_get_Vector3_0;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_New_Void_RaycastHit_0;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr_EndClick_Public_Virtual_New_Void_0;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr_SetOriginalHitPoint_Public_Void_Vector3_0;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_SetActive_Private_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

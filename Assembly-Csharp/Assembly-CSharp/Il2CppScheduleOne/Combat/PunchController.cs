using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000703 RID: 1795
	public class PunchController : MonoBehaviour
	{
		// Token: 0x0600AC63 RID: 44131 RVA: 0x002D5C90 File Offset: 0x002D3E90
		// Note: this type is marked as 'beforefieldinit'.
		static PunchController()
		{
			Il2CppClassPointerStore<PunchController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "PunchController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController>.NativeClassPtr);
			PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MAX_PUNCH_LOAD");
			PunchController.NativeFieldInfoPtr_MIN_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MIN_COOLDOWN");
			PunchController.NativeFieldInfoPtr_MAX_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MAX_COOLDOWN");
			PunchController.NativeFieldInfoPtr_PUNCH_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PUNCH_RANGE");
			PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PUNCH_DEBOUNCE");
			PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<PunchingEnabled>k__BackingField");
			PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<IsPunching>k__BackingField");
			PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "ViewmodelAvatarOffset");
			PunchController.NativeFieldInfoPtr_MinPunchDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinPunchDamage");
			PunchController.NativeFieldInfoPtr_MaxPunchDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxPunchDamage");
			PunchController.NativeFieldInfoPtr_MinPunchForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinPunchForce");
			PunchController.NativeFieldInfoPtr_MaxPunchForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxPunchForce");
			PunchController.NativeFieldInfoPtr_MinStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinStaminaCost");
			PunchController.NativeFieldInfoPtr_MaxStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxStaminaCost");
			PunchController.NativeFieldInfoPtr_PunchSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PunchSound");
			PunchController.NativeFieldInfoPtr_PunchAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PunchAnimator");
			PunchController.NativeFieldInfoPtr_punchLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "punchLoad");
			PunchController.NativeFieldInfoPtr_remainingCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "remainingCooldown");
			PunchController.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "player");
			PunchController.NativeFieldInfoPtr_punchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "punchRoutine");
			PunchController.NativeFieldInfoPtr_itemEquippedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "itemEquippedLastFrame");
			PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "timeSincePunchingEnabled");
			PunchController.NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686046);
			PunchController.NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686047);
			PunchController.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686048);
			PunchController.NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686049);
			PunchController.NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686050);
			PunchController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686051);
			PunchController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686052);
			PunchController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686053);
			PunchController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686054);
			PunchController.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686055);
			PunchController.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686056);
			PunchController.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686057);
			PunchController.NativeMethodInfoPtr_StartLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686058);
			PunchController.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686059);
			PunchController.NativeMethodInfoPtr_Punch_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686060);
			PunchController.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686061);
			PunchController.NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686062);
			PunchController.NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686063);
			PunchController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686064);
			PunchController.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100686065);
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600AC64 RID: 44132 RVA: 0x002D6008 File Offset: 0x002D4208
		// (set) Token: 0x0600AC65 RID: 44133 RVA: 0x002D6044 File Offset: 0x002D4244
		public unsafe bool PunchingEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600AC66 RID: 44134 RVA: 0x002D6084 File Offset: 0x002D4284
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600AC67 RID: 44135 RVA: 0x002D60C0 File Offset: 0x002D42C0
		// (set) Token: 0x0600AC68 RID: 44136 RVA: 0x002D60FC File Offset: 0x002D42FC
		public unsafe bool IsPunching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AC69 RID: 44137 RVA: 0x002D613C File Offset: 0x002D433C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295596, XrefRangeEnd = 295600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC6A RID: 44138 RVA: 0x002D6170 File Offset: 0x002D4370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295600, XrefRangeEnd = 295612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC6B RID: 44139 RVA: 0x002D61A4 File Offset: 0x002D43A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295612, XrefRangeEnd = 295620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC6C RID: 44140 RVA: 0x002D61D8 File Offset: 0x002D43D8
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC6D RID: 44141 RVA: 0x002D620C File Offset: 0x002D440C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295620, XrefRangeEnd = 295621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC6E RID: 44142 RVA: 0x002D6240 File Offset: 0x002D4440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295629, RefRangeEnd = 295630, XrefRangeStart = 295621, XrefRangeEnd = 295629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC6F RID: 44143 RVA: 0x002D6274 File Offset: 0x002D4474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295630, XrefRangeEnd = 295634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartLoading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AC70 RID: 44144 RVA: 0x002D62B0 File Offset: 0x002D44B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295634, XrefRangeEnd = 295665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_StartLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC71 RID: 44145 RVA: 0x002D62E4 File Offset: 0x002D44E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295665, XrefRangeEnd = 295699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC72 RID: 44146 RVA: 0x002D6318 File Offset: 0x002D4518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295717, RefRangeEnd = 295718, XrefRangeStart = 295699, XrefRangeEnd = 295717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Punch(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Punch_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC73 RID: 44147 RVA: 0x002D6358 File Offset: 0x002D4558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295718, XrefRangeEnd = 295798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteHit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC74 RID: 44148 RVA: 0x002D6398 File Offset: 0x002D4598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295814, RefRangeEnd = 295816, XrefRangeStart = 295798, XrefRangeEnd = 295814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPunchingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC75 RID: 44149 RVA: 0x002D63D8 File Offset: 0x002D45D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295859, RefRangeEnd = 295860, XrefRangeStart = 295816, XrefRangeEnd = 295859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldBeEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AC76 RID: 44150 RVA: 0x002D6414 File Offset: 0x002D4614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295860, XrefRangeEnd = 295861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PunchController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC77 RID: 44151 RVA: 0x002D6450 File Offset: 0x002D4650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295861, XrefRangeEnd = 295862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__31_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC78 RID: 44152 RVA: 0x0004ECED File Offset: 0x0004CEED
		public PunchController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600AC79 RID: 44153 RVA: 0x002D6484 File Offset: 0x002D4684
		// (set) Token: 0x0600AC7A RID: 44154 RVA: 0x0004ECF6 File Offset: 0x0004CEF6
		public unsafe static float MAX_PUNCH_LOAD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD, (void*)(&value));
			}
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600AC7B RID: 44155 RVA: 0x002D64A0 File Offset: 0x002D46A0
		// (set) Token: 0x0600AC7C RID: 44156 RVA: 0x0004ED04 File Offset: 0x0004CF04
		public unsafe static float MIN_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MIN_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MIN_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0600AC7D RID: 44157 RVA: 0x002D64BC File Offset: 0x002D46BC
		// (set) Token: 0x0600AC7E RID: 44158 RVA: 0x0004ED12 File Offset: 0x0004CF12
		public unsafe static float MAX_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MAX_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MAX_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0600AC7F RID: 44159 RVA: 0x002D64D8 File Offset: 0x002D46D8
		// (set) Token: 0x0600AC80 RID: 44160 RVA: 0x0004ED20 File Offset: 0x0004CF20
		public unsafe static float PUNCH_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_PUNCH_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_PUNCH_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600AC81 RID: 44161 RVA: 0x002D64F4 File Offset: 0x002D46F4
		// (set) Token: 0x0600AC82 RID: 44162 RVA: 0x0004ED2E File Offset: 0x0004CF2E
		public unsafe static float PUNCH_DEBOUNCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE, (void*)(&value));
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600AC83 RID: 44163 RVA: 0x002D6510 File Offset: 0x002D4710
		// (set) Token: 0x0600AC84 RID: 44164 RVA: 0x0004ED3C File Offset: 0x0004CF3C
		public unsafe bool _PunchingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600AC85 RID: 44165 RVA: 0x002D6538 File Offset: 0x002D4738
		// (set) Token: 0x0600AC86 RID: 44166 RVA: 0x0004ED57 File Offset: 0x0004CF57
		public unsafe bool _IsPunching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField)) = value;
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600AC87 RID: 44167 RVA: 0x002D6560 File Offset: 0x002D4760
		// (set) Token: 0x0600AC88 RID: 44168 RVA: 0x0004ED72 File Offset: 0x0004CF72
		public unsafe Vector3 ViewmodelAvatarOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset)) = value;
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600AC89 RID: 44169 RVA: 0x002D6588 File Offset: 0x002D4788
		// (set) Token: 0x0600AC8A RID: 44170 RVA: 0x0004ED8D File Offset: 0x0004CF8D
		public unsafe float MinPunchDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchDamage)) = value;
			}
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600AC8B RID: 44171 RVA: 0x002D65B0 File Offset: 0x002D47B0
		// (set) Token: 0x0600AC8C RID: 44172 RVA: 0x0004EDA8 File Offset: 0x0004CFA8
		public unsafe float MaxPunchDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchDamage)) = value;
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600AC8D RID: 44173 RVA: 0x002D65D8 File Offset: 0x002D47D8
		// (set) Token: 0x0600AC8E RID: 44174 RVA: 0x0004EDC3 File Offset: 0x0004CFC3
		public unsafe float MinPunchForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchForce)) = value;
			}
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600AC8F RID: 44175 RVA: 0x002D6600 File Offset: 0x002D4800
		// (set) Token: 0x0600AC90 RID: 44176 RVA: 0x0004EDDE File Offset: 0x0004CFDE
		public unsafe float MaxPunchForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchForce)) = value;
			}
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600AC91 RID: 44177 RVA: 0x002D6628 File Offset: 0x002D4828
		// (set) Token: 0x0600AC92 RID: 44178 RVA: 0x0004EDF9 File Offset: 0x0004CFF9
		public unsafe float MinStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinStaminaCost)) = value;
			}
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600AC93 RID: 44179 RVA: 0x002D6650 File Offset: 0x002D4850
		// (set) Token: 0x0600AC94 RID: 44180 RVA: 0x0004EE14 File Offset: 0x0004D014
		public unsafe float MaxStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxStaminaCost)) = value;
			}
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600AC95 RID: 44181 RVA: 0x002D6678 File Offset: 0x002D4878
		// (set) Token: 0x0600AC96 RID: 44182 RVA: 0x0004EE2F File Offset: 0x0004D02F
		public unsafe AudioSourceController PunchSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600AC97 RID: 44183 RVA: 0x002D66A8 File Offset: 0x002D48A8
		// (set) Token: 0x0600AC98 RID: 44184 RVA: 0x0004EE4E File Offset: 0x0004D04E
		public unsafe RuntimeAnimatorController PunchAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600AC99 RID: 44185 RVA: 0x002D66D8 File Offset: 0x002D48D8
		// (set) Token: 0x0600AC9A RID: 44186 RVA: 0x0004EE6D File Offset: 0x0004D06D
		public unsafe float punchLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchLoad)) = value;
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600AC9B RID: 44187 RVA: 0x002D6700 File Offset: 0x002D4900
		// (set) Token: 0x0600AC9C RID: 44188 RVA: 0x0004EE88 File Offset: 0x0004D088
		public unsafe float remainingCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_remainingCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_remainingCooldown)) = value;
			}
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600AC9D RID: 44189 RVA: 0x002D6728 File Offset: 0x002D4928
		// (set) Token: 0x0600AC9E RID: 44190 RVA: 0x0004EEA3 File Offset: 0x0004D0A3
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600AC9F RID: 44191 RVA: 0x002D6758 File Offset: 0x002D4958
		// (set) Token: 0x0600ACA0 RID: 44192 RVA: 0x0004EEC2 File Offset: 0x0004D0C2
		public unsafe Coroutine punchRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600ACA1 RID: 44193 RVA: 0x002D6788 File Offset: 0x002D4988
		// (set) Token: 0x0600ACA2 RID: 44194 RVA: 0x0004EEE1 File Offset: 0x0004D0E1
		public unsafe bool itemEquippedLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_itemEquippedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_itemEquippedLastFrame)) = value;
			}
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600ACA3 RID: 44195 RVA: 0x002D67B0 File Offset: 0x002D49B0
		// (set) Token: 0x0600ACA4 RID: 44196 RVA: 0x0004EEFC File Offset: 0x0004D0FC
		public unsafe float timeSincePunchingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled)) = value;
			}
		}

		// Token: 0x0400770F RID: 30479
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PUNCH_LOAD;

		// Token: 0x04007710 RID: 30480
		private static readonly IntPtr NativeFieldInfoPtr_MIN_COOLDOWN;

		// Token: 0x04007711 RID: 30481
		private static readonly IntPtr NativeFieldInfoPtr_MAX_COOLDOWN;

		// Token: 0x04007712 RID: 30482
		private static readonly IntPtr NativeFieldInfoPtr_PUNCH_RANGE;

		// Token: 0x04007713 RID: 30483
		private static readonly IntPtr NativeFieldInfoPtr_PUNCH_DEBOUNCE;

		// Token: 0x04007714 RID: 30484
		private static readonly IntPtr NativeFieldInfoPtr__PunchingEnabled_k__BackingField;

		// Token: 0x04007715 RID: 30485
		private static readonly IntPtr NativeFieldInfoPtr__IsPunching_k__BackingField;

		// Token: 0x04007716 RID: 30486
		private static readonly IntPtr NativeFieldInfoPtr_ViewmodelAvatarOffset;

		// Token: 0x04007717 RID: 30487
		private static readonly IntPtr NativeFieldInfoPtr_MinPunchDamage;

		// Token: 0x04007718 RID: 30488
		private static readonly IntPtr NativeFieldInfoPtr_MaxPunchDamage;

		// Token: 0x04007719 RID: 30489
		private static readonly IntPtr NativeFieldInfoPtr_MinPunchForce;

		// Token: 0x0400771A RID: 30490
		private static readonly IntPtr NativeFieldInfoPtr_MaxPunchForce;

		// Token: 0x0400771B RID: 30491
		private static readonly IntPtr NativeFieldInfoPtr_MinStaminaCost;

		// Token: 0x0400771C RID: 30492
		private static readonly IntPtr NativeFieldInfoPtr_MaxStaminaCost;

		// Token: 0x0400771D RID: 30493
		private static readonly IntPtr NativeFieldInfoPtr_PunchSound;

		// Token: 0x0400771E RID: 30494
		private static readonly IntPtr NativeFieldInfoPtr_PunchAnimator;

		// Token: 0x0400771F RID: 30495
		private static readonly IntPtr NativeFieldInfoPtr_punchLoad;

		// Token: 0x04007720 RID: 30496
		private static readonly IntPtr NativeFieldInfoPtr_remainingCooldown;

		// Token: 0x04007721 RID: 30497
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04007722 RID: 30498
		private static readonly IntPtr NativeFieldInfoPtr_punchRoutine;

		// Token: 0x04007723 RID: 30499
		private static readonly IntPtr NativeFieldInfoPtr_itemEquippedLastFrame;

		// Token: 0x04007724 RID: 30500
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePunchingEnabled;

		// Token: 0x04007725 RID: 30501
		private static readonly IntPtr NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0;

		// Token: 0x04007726 RID: 30502
		private static readonly IntPtr NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04007727 RID: 30503
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x04007728 RID: 30504
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0;

		// Token: 0x04007729 RID: 30505
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0;

		// Token: 0x0400772A RID: 30506
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400772B RID: 30507
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400772C RID: 30508
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400772D RID: 30509
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400772E RID: 30510
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCooldown_Private_Void_0;

		// Token: 0x0400772F RID: 30511
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04007730 RID: 30512
		private static readonly IntPtr NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0;

		// Token: 0x04007731 RID: 30513
		private static readonly IntPtr NativeMethodInfoPtr_StartLoad_Private_Void_0;

		// Token: 0x04007732 RID: 30514
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04007733 RID: 30515
		private static readonly IntPtr NativeMethodInfoPtr_Punch_Private_Void_Single_0;

		// Token: 0x04007734 RID: 30516
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0;

		// Token: 0x04007735 RID: 30517
		private static readonly IntPtr NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0;

		// Token: 0x04007736 RID: 30518
		private static readonly IntPtr NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0;

		// Token: 0x04007737 RID: 30519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007738 RID: 30520
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__31_0_Private_Void_0;

		// Token: 0x02000CA9 RID: 3241
		[ObfuscatedName("ScheduleOne.Combat.PunchController+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F341 RID: 62273 RVA: 0x003A9144 File Offset: 0x003A7344
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr);
				PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "power");
				PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, 100686066);
				PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, 100686067);
			}

			// Token: 0x0600F342 RID: 62274 RVA: 0x003A91C0 File Offset: 0x003A73C0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F343 RID: 62275 RVA: 0x003A91FC File Offset: 0x003A73FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295591, XrefRangeEnd = 295596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F344 RID: 62276 RVA: 0x00072D07 File Offset: 0x00070F07
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049D1 RID: 18897
			// (get) Token: 0x0600F345 RID: 62277 RVA: 0x003A923C File Offset: 0x003A743C
			// (set) Token: 0x0600F346 RID: 62278 RVA: 0x00072D10 File Offset: 0x00070F10
			public unsafe PunchController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PunchController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049D2 RID: 18898
			// (get) Token: 0x0600F347 RID: 62279 RVA: 0x003A926C File Offset: 0x003A746C
			// (set) Token: 0x0600F348 RID: 62280 RVA: 0x00072D2F File Offset: 0x00070F2F
			public unsafe float power
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power)) = value;
				}
			}

			// Token: 0x0400A4C8 RID: 42184
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A4C9 RID: 42185
			private static readonly IntPtr NativeFieldInfoPtr_power;

			// Token: 0x0400A4CA RID: 42186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A4CB RID: 42187
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E02 RID: 3586
			[ObfuscatedName("ScheduleOne.Combat.PunchController+<>c__DisplayClass39_0+<<Punch>g__PunchRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010264 RID: 66148 RVA: 0x003D4DC0 File Offset: 0x003D2FC0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "<<Punch>g__PunchRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686068);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686069);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686070);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686071);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686072);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686073);
				}

				// Token: 0x06010265 RID: 66149 RVA: 0x003D4EA0 File Offset: 0x003D30A0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010266 RID: 66150 RVA: 0x003D4EE8 File Offset: 0x003D30E8
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010267 RID: 66151 RVA: 0x003D4F1C File Offset: 0x003D311C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295570, XrefRangeEnd = 295586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004EE0 RID: 20192
				// (get) Token: 0x06010268 RID: 66152 RVA: 0x003D4F58 File Offset: 0x003D3158
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010269 RID: 66153 RVA: 0x003D4F98 File Offset: 0x003D3198
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295586, XrefRangeEnd = 295591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004EE1 RID: 20193
				// (get) Token: 0x0601026A RID: 66154 RVA: 0x003D4FCC File Offset: 0x003D31CC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601026B RID: 66155 RVA: 0x0007A7B9 File Offset: 0x000789B9
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004EDD RID: 20189
				// (get) Token: 0x0601026C RID: 66156 RVA: 0x003D500C File Offset: 0x003D320C
				// (set) Token: 0x0601026D RID: 66157 RVA: 0x0007A7C2 File Offset: 0x000789C2
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004EDE RID: 20190
				// (get) Token: 0x0601026E RID: 66158 RVA: 0x003D5034 File Offset: 0x003D3234
				// (set) Token: 0x0601026F RID: 66159 RVA: 0x0007A7DD File Offset: 0x000789DD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EDF RID: 20191
				// (get) Token: 0x06010270 RID: 66160 RVA: 0x003D5064 File Offset: 0x003D3264
				// (set) Token: 0x06010271 RID: 66161 RVA: 0x0007A7FC File Offset: 0x000789FC
				public unsafe PunchController.__c__DisplayClass39_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PunchController.__c__DisplayClass39_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ADF3 RID: 44531
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ADF4 RID: 44532
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ADF5 RID: 44533
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ADF6 RID: 44534
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ADF7 RID: 44535
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ADF8 RID: 44536
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ADF9 RID: 44537
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ADFA RID: 44538
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ADFB RID: 44539
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}

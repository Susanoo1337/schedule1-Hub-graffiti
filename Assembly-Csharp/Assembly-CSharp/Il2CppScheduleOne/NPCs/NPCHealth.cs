using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020005D6 RID: 1494
	public class NPCHealth : NetworkBehaviour
	{
		// Token: 0x060091F6 RID: 37366 RVA: 0x00278244 File Offset: 0x00276444
		// Note: this type is marked as 'beforefieldinit'.
		static NPCHealth()
		{
			Il2CppClassPointerStore<NPCHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCHealth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr);
			NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "REVIVE_DAYS");
			NPCHealth.NativeFieldInfoPtr__Health_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<Health>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<IsDead>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<IsKnockedOut>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<DaysPassedSinceDeath>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__HoursSinceAttackedByPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<HoursSinceAttackedByPlayer>k__BackingField");
			NPCHealth.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "npc");
			NPCHealth.NativeFieldInfoPtr_onDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onDie");
			NPCHealth.NativeFieldInfoPtr_onKnockedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onKnockedOut");
			NPCHealth.NativeFieldInfoPtr_onDieOrKnockedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onDieOrKnockedOut");
			NPCHealth.NativeFieldInfoPtr_onRevive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onRevive");
			NPCHealth.NativeFieldInfoPtr_onTakeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onTakeDamage");
			NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "AfflictedWithLethalEffect");
			NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "syncVar___<Health>k__BackingField");
			NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted");
			NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted");
			NPCHealth.NativeMethodInfoPtr_get_Health_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682308);
			NPCHealth.NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682309);
			NPCHealth.NativeMethodInfoPtr_get_NormalizedHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682310);
			NPCHealth.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682311);
			NPCHealth.NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682312);
			NPCHealth.NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682313);
			NPCHealth.NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682314);
			NPCHealth.NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682315);
			NPCHealth.NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682316);
			NPCHealth.NativeMethodInfoPtr_get_HoursSinceAttackedByPlayer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682317);
			NPCHealth.NativeMethodInfoPtr_set_HoursSinceAttackedByPlayer_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682318);
			NPCHealth.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682319);
			NPCHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682320);
			NPCHealth.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682321);
			NPCHealth.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682322);
			NPCHealth.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682323);
			NPCHealth.NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682324);
			NPCHealth.NativeMethodInfoPtr_AfflictWithLethalEffect_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682325);
			NPCHealth.NativeMethodInfoPtr_OnHourPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682326);
			NPCHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682327);
			NPCHealth.NativeMethodInfoPtr_SleepStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682328);
			NPCHealth.NativeMethodInfoPtr_NotifyAttackedByPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682329);
			NPCHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682330);
			NPCHealth.NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682331);
			NPCHealth.NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682332);
			NPCHealth.NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682333);
			NPCHealth.NativeMethodInfoPtr_RestoreHealth_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682334);
			NPCHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682335);
			NPCHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682336);
			NPCHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682337);
			NPCHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682338);
			NPCHealth.NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682339);
			NPCHealth.NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682340);
			NPCHealth.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682341);
			NPCHealth.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100682342);
		}

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x060091F7 RID: 37367 RVA: 0x00278670 File Offset: 0x00276870
		// (set) Token: 0x060091F8 RID: 37368 RVA: 0x002786AC File Offset: 0x002768AC
		public unsafe float Health
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 267160, RefRangeEnd = 267163, XrefRangeStart = 267160, XrefRangeEnd = 267160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_Health_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 267170, RefRangeEnd = 267178, XrefRangeStart = 267163, XrefRangeEnd = 267170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x060091F9 RID: 37369 RVA: 0x002786EC File Offset: 0x002768EC
		public unsafe float NormalizedHealth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 267180, RefRangeEnd = 267183, XrefRangeStart = 267178, XrefRangeEnd = 267180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_NormalizedHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x060091FA RID: 37370 RVA: 0x00278728 File Offset: 0x00276928
		// (set) Token: 0x060091FB RID: 37371 RVA: 0x00278764 File Offset: 0x00276964
		public unsafe bool IsDead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x060091FC RID: 37372 RVA: 0x002787A4 File Offset: 0x002769A4
		// (set) Token: 0x060091FD RID: 37373 RVA: 0x002787E0 File Offset: 0x002769E0
		public unsafe bool IsKnockedOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x060091FE RID: 37374 RVA: 0x00278820 File Offset: 0x00276A20
		// (set) Token: 0x060091FF RID: 37375 RVA: 0x0027885C File Offset: 0x00276A5C
		public unsafe int DaysPassedSinceDeath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x06009200 RID: 37376 RVA: 0x0027889C File Offset: 0x00276A9C
		// (set) Token: 0x06009201 RID: 37377 RVA: 0x002788D8 File Offset: 0x00276AD8
		public unsafe int HoursSinceAttackedByPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_HoursSinceAttackedByPlayer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_HoursSinceAttackedByPlayer_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x06009202 RID: 37378 RVA: 0x00278918 File Offset: 0x00276B18
		public unsafe float MaxHealth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 267184, RefRangeEnd = 267185, XrefRangeStart = 267183, XrefRangeEnd = 267184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x00278954 File Offset: 0x00276B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267185, XrefRangeEnd = 267186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x00278990 File Offset: 0x00276B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267186, XrefRangeEnd = 267215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x002789C4 File Offset: 0x00276BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267215, XrefRangeEnd = 267233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x002789F8 File Offset: 0x00276BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267233, XrefRangeEnd = 267237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x00278A34 File Offset: 0x00276C34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267238, RefRangeEnd = 267240, XrefRangeStart = 267237, XrefRangeEnd = 267238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NPCHealthData healthData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(healthData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x00278A78 File Offset: 0x00276C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267240, XrefRangeEnd = 267245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AfflictWithLethalEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_AfflictWithLethalEffect_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x00278AB8 File Offset: 0x00276CB8
		[CallerCount(0)]
		public unsafe virtual void OnHourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_OnHourPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x00278AF4 File Offset: 0x00276CF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267251, RefRangeEnd = 267253, XrefRangeStart = 267245, XrefRangeEnd = 267251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAfflictedWithLethalEffect(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x00278B34 File Offset: 0x00276D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267253, XrefRangeEnd = 267260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_SleepStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x00278B68 File Offset: 0x00276D68
		[CallerCount(0)]
		public unsafe virtual void NotifyAttackedByPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NotifyAttackedByPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600920D RID: 37389 RVA: 0x00278BB8 File Offset: 0x00276DB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 267264, RefRangeEnd = 267267, XrefRangeStart = 267260, XrefRangeEnd = 267264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeDamage(float damage, bool isLethal = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLethal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600920E RID: 37390 RVA: 0x00278C04 File Offset: 0x00276E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267267, XrefRangeEnd = 267280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600920F RID: 37391 RVA: 0x00278C40 File Offset: 0x00276E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267280, XrefRangeEnd = 267292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void KnockOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x00278C7C File Offset: 0x00276E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267292, XrefRangeEnd = 267305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Revive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x00278CB8 File Offset: 0x00276EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267308, RefRangeEnd = 267309, XrefRangeStart = 267305, XrefRangeEnd = 267308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreHealth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_RestoreHealth_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009212 RID: 37394 RVA: 0x00278CEC File Offset: 0x00276EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267309, XrefRangeEnd = 267310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009213 RID: 37395 RVA: 0x00278D28 File Offset: 0x00276F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267310, XrefRangeEnd = 267326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x00278D64 File Offset: 0x00276F64
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x00278DA0 File Offset: 0x00276FA0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x06009216 RID: 37398 RVA: 0x00278DDC File Offset: 0x00276FDC
		// (set) Token: 0x06009217 RID: 37399 RVA: 0x00278E18 File Offset: 0x00277018
		public unsafe float SyncAccessor_<Health>k__BackingField
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 267160, RefRangeEnd = 267163, XrefRangeStart = 267160, XrefRangeEnd = 267163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267326, XrefRangeEnd = 267334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x00278E64 File Offset: 0x00277064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267334, XrefRangeEnd = 267335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_NPCs_NPCHealth(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009219 RID: 37401 RVA: 0x00278ED8 File Offset: 0x002770D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267384, RefRangeEnd = 267385, XrefRangeStart = 267335, XrefRangeEnd = 267384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x00044974 File Offset: 0x00042B74
		public NPCHealth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x0600921B RID: 37403 RVA: 0x00278F14 File Offset: 0x00277114
		// (set) Token: 0x0600921C RID: 37404 RVA: 0x0004497D File Offset: 0x00042B7D
		public unsafe static int REVIVE_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS, (void*)(&value));
			}
		}

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x0600921D RID: 37405 RVA: 0x00278F30 File Offset: 0x00277130
		// (set) Token: 0x0600921E RID: 37406 RVA: 0x0004498B File Offset: 0x00042B8B
		public unsafe float _Health_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__Health_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__Health_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x0600921F RID: 37407 RVA: 0x00278F58 File Offset: 0x00277158
		// (set) Token: 0x06009220 RID: 37408 RVA: 0x000449A6 File Offset: 0x00042BA6
		public unsafe bool _IsDead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x06009221 RID: 37409 RVA: 0x00278F80 File Offset: 0x00277180
		// (set) Token: 0x06009222 RID: 37410 RVA: 0x000449C1 File Offset: 0x00042BC1
		public unsafe bool _IsKnockedOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x06009223 RID: 37411 RVA: 0x00278FA8 File Offset: 0x002771A8
		// (set) Token: 0x06009224 RID: 37412 RVA: 0x000449DC File Offset: 0x00042BDC
		public unsafe int _DaysPassedSinceDeath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x06009225 RID: 37413 RVA: 0x00278FD0 File Offset: 0x002771D0
		// (set) Token: 0x06009226 RID: 37414 RVA: 0x000449F7 File Offset: 0x00042BF7
		public unsafe int _HoursSinceAttackedByPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__HoursSinceAttackedByPlayer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__HoursSinceAttackedByPlayer_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x06009227 RID: 37415 RVA: 0x00278FF8 File Offset: 0x002771F8
		// (set) Token: 0x06009228 RID: 37416 RVA: 0x00044A12 File Offset: 0x00042C12
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x06009229 RID: 37417 RVA: 0x00279028 File Offset: 0x00277228
		// (set) Token: 0x0600922A RID: 37418 RVA: 0x00044A31 File Offset: 0x00042C31
		public unsafe UnityEvent onDie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onDie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onDie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x0600922B RID: 37419 RVA: 0x00279058 File Offset: 0x00277258
		// (set) Token: 0x0600922C RID: 37420 RVA: 0x00044A50 File Offset: 0x00042C50
		public unsafe UnityEvent onKnockedOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onKnockedOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onKnockedOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x0600922D RID: 37421 RVA: 0x00279088 File Offset: 0x00277288
		// (set) Token: 0x0600922E RID: 37422 RVA: 0x00044A6F File Offset: 0x00042C6F
		public unsafe UnityEvent onDieOrKnockedOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onDieOrKnockedOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onDieOrKnockedOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x0600922F RID: 37423 RVA: 0x002790B8 File Offset: 0x002772B8
		// (set) Token: 0x06009230 RID: 37424 RVA: 0x00044A8E File Offset: 0x00042C8E
		public unsafe UnityEvent onRevive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onRevive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onRevive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x06009231 RID: 37425 RVA: 0x002790E8 File Offset: 0x002772E8
		// (set) Token: 0x06009232 RID: 37426 RVA: 0x00044AAD File Offset: 0x00042CAD
		public unsafe Action<float> onTakeDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onTakeDamage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onTakeDamage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x06009233 RID: 37427 RVA: 0x00279118 File Offset: 0x00277318
		// (set) Token: 0x06009234 RID: 37428 RVA: 0x00044ACC File Offset: 0x00042CCC
		public unsafe bool AfflictedWithLethalEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect)) = value;
			}
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x06009235 RID: 37429 RVA: 0x00279140 File Offset: 0x00277340
		// (set) Token: 0x06009236 RID: 37430 RVA: 0x00044AE7 File Offset: 0x00042CE7
		public unsafe SyncVar<float> syncVar____Health_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x06009237 RID: 37431 RVA: 0x00279170 File Offset: 0x00277370
		// (set) Token: 0x06009238 RID: 37432 RVA: 0x00044B06 File Offset: 0x00042D06
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x06009239 RID: 37433 RVA: 0x00279198 File Offset: 0x00277398
		// (set) Token: 0x0600923A RID: 37434 RVA: 0x00044B21 File Offset: 0x00042D21
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006468 RID: 25704
		private static readonly IntPtr NativeFieldInfoPtr_REVIVE_DAYS;

		// Token: 0x04006469 RID: 25705
		private static readonly IntPtr NativeFieldInfoPtr__Health_k__BackingField;

		// Token: 0x0400646A RID: 25706
		private static readonly IntPtr NativeFieldInfoPtr__IsDead_k__BackingField;

		// Token: 0x0400646B RID: 25707
		private static readonly IntPtr NativeFieldInfoPtr__IsKnockedOut_k__BackingField;

		// Token: 0x0400646C RID: 25708
		private static readonly IntPtr NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField;

		// Token: 0x0400646D RID: 25709
		private static readonly IntPtr NativeFieldInfoPtr__HoursSinceAttackedByPlayer_k__BackingField;

		// Token: 0x0400646E RID: 25710
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x0400646F RID: 25711
		private static readonly IntPtr NativeFieldInfoPtr_onDie;

		// Token: 0x04006470 RID: 25712
		private static readonly IntPtr NativeFieldInfoPtr_onKnockedOut;

		// Token: 0x04006471 RID: 25713
		private static readonly IntPtr NativeFieldInfoPtr_onDieOrKnockedOut;

		// Token: 0x04006472 RID: 25714
		private static readonly IntPtr NativeFieldInfoPtr_onRevive;

		// Token: 0x04006473 RID: 25715
		private static readonly IntPtr NativeFieldInfoPtr_onTakeDamage;

		// Token: 0x04006474 RID: 25716
		private static readonly IntPtr NativeFieldInfoPtr_AfflictedWithLethalEffect;

		// Token: 0x04006475 RID: 25717
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Health_k__BackingField;

		// Token: 0x04006476 RID: 25718
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006477 RID: 25719
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006478 RID: 25720
		private static readonly IntPtr NativeMethodInfoPtr_get_Health_Public_get_Single_0;

		// Token: 0x04006479 RID: 25721
		private static readonly IntPtr NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0;

		// Token: 0x0400647A RID: 25722
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedHealth_Public_get_Single_0;

		// Token: 0x0400647B RID: 25723
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0;

		// Token: 0x0400647C RID: 25724
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0;

		// Token: 0x0400647D RID: 25725
		private static readonly IntPtr NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0;

		// Token: 0x0400647E RID: 25726
		private static readonly IntPtr NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0;

		// Token: 0x0400647F RID: 25727
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0;

		// Token: 0x04006480 RID: 25728
		private static readonly IntPtr NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0;

		// Token: 0x04006481 RID: 25729
		private static readonly IntPtr NativeMethodInfoPtr_get_HoursSinceAttackedByPlayer_Public_get_Int32_0;

		// Token: 0x04006482 RID: 25730
		private static readonly IntPtr NativeMethodInfoPtr_set_HoursSinceAttackedByPlayer_Private_set_Void_Int32_0;

		// Token: 0x04006483 RID: 25731
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0;

		// Token: 0x04006484 RID: 25732
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006485 RID: 25733
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006486 RID: 25734
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006487 RID: 25735
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04006488 RID: 25736
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0;

		// Token: 0x04006489 RID: 25737
		private static readonly IntPtr NativeMethodInfoPtr_AfflictWithLethalEffect_Private_IEnumerator_0;

		// Token: 0x0400648A RID: 25738
		private static readonly IntPtr NativeMethodInfoPtr_OnHourPass_Protected_Virtual_New_Void_1;

		// Token: 0x0400648B RID: 25739
		private static readonly IntPtr NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0;

		// Token: 0x0400648C RID: 25740
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Public_Void_0;

		// Token: 0x0400648D RID: 25741
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAttackedByPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400648E RID: 25742
		private static readonly IntPtr NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0;

		// Token: 0x0400648F RID: 25743
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0;

		// Token: 0x04006490 RID: 25744
		private static readonly IntPtr NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0;

		// Token: 0x04006491 RID: 25745
		private static readonly IntPtr NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0;

		// Token: 0x04006492 RID: 25746
		private static readonly IntPtr NativeMethodInfoPtr_RestoreHealth_Public_Void_0;

		// Token: 0x04006493 RID: 25747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006494 RID: 25748
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006495 RID: 25749
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006496 RID: 25750
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006497 RID: 25751
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0;

		// Token: 0x04006498 RID: 25752
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04006499 RID: 25753
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x0400649A RID: 25754
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000C21 RID: 3105
		[ObfuscatedName("ScheduleOne.NPCs.NPCHealth+<AfflictWithLethalEffect>d__37")]
		public sealed class _AfflictWithLethalEffect_d__37 : Object
		{
			// Token: 0x0600EE8F RID: 61071 RVA: 0x0039B100 File Offset: 0x00399300
			// Note: this type is marked as 'beforefieldinit'.
			static _AfflictWithLethalEffect_d__37()
			{
				Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<AfflictWithLethalEffect>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr);
				NPCHealth._AfflictWithLethalEffect_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr, "<>1__state");
				NPCHealth._AfflictWithLethalEffect_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr, "<>2__current");
				NPCHealth._AfflictWithLethalEffect_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr, "<>4__this");
				NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr, 100682343);
				NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr, 100682344);
				NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr, 100682345);
				NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr, 100682346);
				NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr, 100682347);
				NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr, 100682348);
			}

			// Token: 0x0600EE90 RID: 61072 RVA: 0x0039B1E0 File Offset: 0x003993E0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AfflictWithLethalEffect_d__37(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCHealth._AfflictWithLethalEffect_d__37>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE91 RID: 61073 RVA: 0x0039B228 File Offset: 0x00399428
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE92 RID: 61074 RVA: 0x0039B25C File Offset: 0x0039945C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267152, XrefRangeEnd = 267155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004859 RID: 18521
			// (get) Token: 0x0600EE93 RID: 61075 RVA: 0x0039B298 File Offset: 0x00399498
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE94 RID: 61076 RVA: 0x0039B2D8 File Offset: 0x003994D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267155, XrefRangeEnd = 267160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700485A RID: 18522
			// (get) Token: 0x0600EE95 RID: 61077 RVA: 0x0039B30C File Offset: 0x0039950C
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth._AfflictWithLethalEffect_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE96 RID: 61078 RVA: 0x000709E4 File Offset: 0x0006EBE4
			public _AfflictWithLethalEffect_d__37(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004856 RID: 18518
			// (get) Token: 0x0600EE97 RID: 61079 RVA: 0x0039B34C File Offset: 0x0039954C
			// (set) Token: 0x0600EE98 RID: 61080 RVA: 0x000709ED File Offset: 0x0006EBED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth._AfflictWithLethalEffect_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth._AfflictWithLethalEffect_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004857 RID: 18519
			// (get) Token: 0x0600EE99 RID: 61081 RVA: 0x0039B374 File Offset: 0x00399574
			// (set) Token: 0x0600EE9A RID: 61082 RVA: 0x00070A08 File Offset: 0x0006EC08
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth._AfflictWithLethalEffect_d__37.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth._AfflictWithLethalEffect_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004858 RID: 18520
			// (get) Token: 0x0600EE9B RID: 61083 RVA: 0x0039B3A4 File Offset: 0x003995A4
			// (set) Token: 0x0600EE9C RID: 61084 RVA: 0x00070A27 File Offset: 0x0006EC27
			public unsafe NPCHealth __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth._AfflictWithLethalEffect_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCHealth>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth._AfflictWithLethalEffect_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A183 RID: 41347
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A184 RID: 41348
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A185 RID: 41349
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A186 RID: 41350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A187 RID: 41351
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A188 RID: 41352
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A189 RID: 41353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A18A RID: 41354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A18B RID: 41355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

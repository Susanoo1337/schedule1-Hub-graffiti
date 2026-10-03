using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts.Health
{
	// Token: 0x02000330 RID: 816
	public class PlayerHealth : NetworkBehaviour
	{
		// Token: 0x060045AB RID: 17835 RVA: 0x001684C4 File Offset: 0x001666C4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerHealth()
		{
			Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts.Health", "PlayerHealth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr);
			PlayerHealth.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "MaxHealth");
			PlayerHealth.NativeFieldInfoPtr_HealthRecoveryPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "HealthRecoveryPerMinute");
			PlayerHealth.NativeFieldInfoPtr_CanRespawnInSinglePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "CanRespawnInSinglePlayer");
			PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<IsAlive>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<CurrentHealth>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<TimeSinceLastDamage>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "Player");
			PlayerHealth.NativeFieldInfoPtr_onHealthChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onHealthChanged");
			PlayerHealth.NativeFieldInfoPtr_onDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onDie");
			PlayerHealth.NativeFieldInfoPtr_onRevive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onRevive");
			PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "AfflictedWithLethalEffect");
			PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted");
			PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted");
			PlayerHealth.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672269);
			PlayerHealth.NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672270);
			PlayerHealth.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672271);
			PlayerHealth.NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672272);
			PlayerHealth.NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672273);
			PlayerHealth.NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672274);
			PlayerHealth.NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672275);
			PlayerHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672276);
			PlayerHealth.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672277);
			PlayerHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672278);
			PlayerHealth.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672279);
			PlayerHealth.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672280);
			PlayerHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672281);
			PlayerHealth.NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672282);
			PlayerHealth.NativeMethodInfoPtr_SetHealth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672283);
			PlayerHealth.NativeMethodInfoPtr_SendDie_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672284);
			PlayerHealth.NativeMethodInfoPtr_Die_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672285);
			PlayerHealth.NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672286);
			PlayerHealth.NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672287);
			PlayerHealth.NativeMethodInfoPtr_PlayBloodMist_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672288);
			PlayerHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672289);
			PlayerHealth.NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672290);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672291);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672292);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672293);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672294);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672295);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672296);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672297);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672298);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672299);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672300);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672301);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672302);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672303);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672304);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672305);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672306);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672307);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672308);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672309);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672310);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672311);
			PlayerHealth.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100672312);
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x060045AC RID: 17836 RVA: 0x00168968 File Offset: 0x00166B68
		// (set) Token: 0x060045AD RID: 17837 RVA: 0x001689A4 File Offset: 0x00166BA4
		public unsafe bool IsAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x001689E4 File Offset: 0x00166BE4
		// (set) Token: 0x060045AF RID: 17839 RVA: 0x00168A20 File Offset: 0x00166C20
		public unsafe float CurrentHealth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75479, RefRangeEnd = 75481, XrefRangeStart = 75479, XrefRangeEnd = 75481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x00168A60 File Offset: 0x00166C60
		// (set) Token: 0x060045B1 RID: 17841 RVA: 0x00168A9C File Offset: 0x00166C9C
		public unsafe float TimeSinceLastDamage
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 75486, RefRangeEnd = 75489, XrefRangeStart = 75486, XrefRangeEnd = 75489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x00168ADC File Offset: 0x00166CDC
		public unsafe bool CanTakeDamage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164756, XrefRangeEnd = 164762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00168B18 File Offset: 0x00166D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164762, XrefRangeEnd = 164774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x00168B54 File Offset: 0x00166D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164774, XrefRangeEnd = 164796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00168B88 File Offset: 0x00166D88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 164808, RefRangeEnd = 164812, XrefRangeStart = 164796, XrefRangeEnd = 164808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeDamage(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x00168BE4 File Offset: 0x00166DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164812, XrefRangeEnd = 164834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x00168C18 File Offset: 0x00166E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164834, XrefRangeEnd = 164844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00168C4C File Offset: 0x00166E4C
		[CallerCount(0)]
		public unsafe void SetAfflictedWithLethalEffect(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00168C8C File Offset: 0x00166E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164854, RefRangeEnd = 164855, XrefRangeStart = 164844, XrefRangeEnd = 164854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecoverHealth(float recovery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recovery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x00168CCC File Offset: 0x00166ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164860, RefRangeEnd = 164861, XrefRangeStart = 164855, XrefRangeEnd = 164860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHealth(float health)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref health;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SetHealth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00168D0C File Offset: 0x00166F0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 164882, RefRangeEnd = 164885, XrefRangeStart = 164861, XrefRangeEnd = 164882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SendDie_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00168D40 File Offset: 0x00166F40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164906, RefRangeEnd = 164908, XrefRangeStart = 164885, XrefRangeEnd = 164906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Die_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x00168D74 File Offset: 0x00166F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164911, RefRangeEnd = 164912, XrefRangeStart = 164908, XrefRangeEnd = 164911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRevive(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00168DC0 File Offset: 0x00166FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164912, XrefRangeEnd = 164914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Revive(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x00168E0C File Offset: 0x0016700C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164914, XrefRangeEnd = 164923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBloodMist()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_PlayBloodMist_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00168E40 File Offset: 0x00167040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164923, XrefRangeEnd = 164924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x00168E7C File Offset: 0x0016707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164924, XrefRangeEnd = 164928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__22_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00168EB0 File Offset: 0x001670B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164928, XrefRangeEnd = 164966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00168EEC File Offset: 0x001670EC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00168F28 File Offset: 0x00167128
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x00168F64 File Offset: 0x00167164
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 164808, RefRangeEnd = 164812, XrefRangeStart = 164808, XrefRangeEnd = 164812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x00168FC0 File Offset: 0x001671C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165011, RefRangeEnd = 165012, XrefRangeStart = 164966, XrefRangeEnd = 165011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x0016901C File Offset: 0x0016721C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165012, XrefRangeEnd = 165015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_TakeDamage_3505310624(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x0016906C File Offset: 0x0016726C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165015, XrefRangeEnd = 165024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDie_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x001690A0 File Offset: 0x001672A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164906, RefRangeEnd = 164908, XrefRangeStart = 164906, XrefRangeEnd = 164908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDie_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x001690D4 File Offset: 0x001672D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165024, XrefRangeEnd = 165027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDie_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x00169138 File Offset: 0x00167338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165027, XrefRangeEnd = 165036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Die_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x0016916C File Offset: 0x0016736C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 165051, RefRangeEnd = 165054, XrefRangeStart = 165036, XrefRangeEnd = 165051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Die_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x001691A0 File Offset: 0x001673A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165054, XrefRangeEnd = 165057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Die_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x001691F0 File Offset: 0x001673F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165081, RefRangeEnd = 165082, XrefRangeStart = 165057, XrefRangeEnd = 165081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x0016923C File Offset: 0x0016743C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x00169288 File Offset: 0x00167488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165082, XrefRangeEnd = 165091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRevive_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x001692EC File Offset: 0x001674EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 165115, RefRangeEnd = 165119, XrefRangeStart = 165091, XrefRangeEnd = 165115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Revive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x00169338 File Offset: 0x00167538
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 165144, RefRangeEnd = 165149, XrefRangeStart = 165119, XrefRangeEnd = 165144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Revive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x00169384 File Offset: 0x00167584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165149, XrefRangeEnd = 165157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Revive_3848837105(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x001693D4 File Offset: 0x001675D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlayBloodMist_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x00169408 File Offset: 0x00167608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165157, XrefRangeEnd = 165164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlayBloodMist_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x0016943C File Offset: 0x0016763C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165164, XrefRangeEnd = 165171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlayBloodMist_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x0016948C File Offset: 0x0016768C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165171, XrefRangeEnd = 165183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x00021FBD File Offset: 0x000201BD
		public PlayerHealth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x060045D9 RID: 17881 RVA: 0x001694C0 File Offset: 0x001676C0
		// (set) Token: 0x060045DA RID: 17882 RVA: 0x00021FC6 File Offset: 0x000201C6
		public unsafe static float MaxHealth
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerHealth.NativeFieldInfoPtr_MaxHealth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerHealth.NativeFieldInfoPtr_MaxHealth, (void*)(&value));
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x001694DC File Offset: 0x001676DC
		// (set) Token: 0x060045DC RID: 17884 RVA: 0x00021FD4 File Offset: 0x000201D4
		public unsafe static float HealthRecoveryPerMinute
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerHealth.NativeFieldInfoPtr_HealthRecoveryPerMinute, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerHealth.NativeFieldInfoPtr_HealthRecoveryPerMinute, (void*)(&value));
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x060045DD RID: 17885 RVA: 0x001694F8 File Offset: 0x001676F8
		// (set) Token: 0x060045DE RID: 17886 RVA: 0x00021FE2 File Offset: 0x000201E2
		public unsafe static bool CanRespawnInSinglePlayer
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(PlayerHealth.NativeFieldInfoPtr_CanRespawnInSinglePlayer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerHealth.NativeFieldInfoPtr_CanRespawnInSinglePlayer, (void*)(&value));
			}
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x00169514 File Offset: 0x00167714
		// (set) Token: 0x060045E0 RID: 17888 RVA: 0x00021FF0 File Offset: 0x000201F0
		public unsafe bool _IsAlive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField)) = value;
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x0016953C File Offset: 0x0016773C
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x0002200B File Offset: 0x0002020B
		public unsafe float _CurrentHealth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField)) = value;
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x00169564 File Offset: 0x00167764
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x00022026 File Offset: 0x00020226
		public unsafe float _TimeSinceLastDamage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField)) = value;
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x0016958C File Offset: 0x0016778C
		// (set) Token: 0x060045E6 RID: 17894 RVA: 0x00022041 File Offset: 0x00020241
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x001695BC File Offset: 0x001677BC
		// (set) Token: 0x060045E8 RID: 17896 RVA: 0x00022060 File Offset: 0x00020260
		public unsafe UnityEvent<float> onHealthChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onHealthChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onHealthChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x060045E9 RID: 17897 RVA: 0x001695EC File Offset: 0x001677EC
		// (set) Token: 0x060045EA RID: 17898 RVA: 0x0002207F File Offset: 0x0002027F
		public unsafe UnityEvent onDie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onDie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onDie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x060045EB RID: 17899 RVA: 0x0016961C File Offset: 0x0016781C
		// (set) Token: 0x060045EC RID: 17900 RVA: 0x0002209E File Offset: 0x0002029E
		public unsafe UnityEvent onRevive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onRevive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onRevive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x0016964C File Offset: 0x0016784C
		// (set) Token: 0x060045EE RID: 17902 RVA: 0x000220BD File Offset: 0x000202BD
		public unsafe bool AfflictedWithLethalEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect)) = value;
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x060045EF RID: 17903 RVA: 0x00169674 File Offset: 0x00167874
		// (set) Token: 0x060045F0 RID: 17904 RVA: 0x000220D8 File Offset: 0x000202D8
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x060045F1 RID: 17905 RVA: 0x0016969C File Offset: 0x0016789C
		// (set) Token: 0x060045F2 RID: 17906 RVA: 0x000220F3 File Offset: 0x000202F3
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002F6B RID: 12139
		private static readonly IntPtr NativeFieldInfoPtr_MaxHealth;

		// Token: 0x04002F6C RID: 12140
		private static readonly IntPtr NativeFieldInfoPtr_HealthRecoveryPerMinute;

		// Token: 0x04002F6D RID: 12141
		private static readonly IntPtr NativeFieldInfoPtr_CanRespawnInSinglePlayer;

		// Token: 0x04002F6E RID: 12142
		private static readonly IntPtr NativeFieldInfoPtr__IsAlive_k__BackingField;

		// Token: 0x04002F6F RID: 12143
		private static readonly IntPtr NativeFieldInfoPtr__CurrentHealth_k__BackingField;

		// Token: 0x04002F70 RID: 12144
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField;

		// Token: 0x04002F71 RID: 12145
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04002F72 RID: 12146
		private static readonly IntPtr NativeFieldInfoPtr_onHealthChanged;

		// Token: 0x04002F73 RID: 12147
		private static readonly IntPtr NativeFieldInfoPtr_onDie;

		// Token: 0x04002F74 RID: 12148
		private static readonly IntPtr NativeFieldInfoPtr_onRevive;

		// Token: 0x04002F75 RID: 12149
		private static readonly IntPtr NativeFieldInfoPtr_AfflictedWithLethalEffect;

		// Token: 0x04002F76 RID: 12150
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002F77 RID: 12151
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002F78 RID: 12152
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;

		// Token: 0x04002F79 RID: 12153
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0;

		// Token: 0x04002F7A RID: 12154
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0;

		// Token: 0x04002F7B RID: 12155
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0;

		// Token: 0x04002F7C RID: 12156
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0;

		// Token: 0x04002F7D RID: 12157
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0;

		// Token: 0x04002F7E RID: 12158
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0;

		// Token: 0x04002F7F RID: 12159
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002F80 RID: 12160
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002F81 RID: 12161
		private static readonly IntPtr NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x04002F82 RID: 12162
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002F83 RID: 12163
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04002F84 RID: 12164
		private static readonly IntPtr NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0;

		// Token: 0x04002F85 RID: 12165
		private static readonly IntPtr NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0;

		// Token: 0x04002F86 RID: 12166
		private static readonly IntPtr NativeMethodInfoPtr_SetHealth_Public_Void_Single_0;

		// Token: 0x04002F87 RID: 12167
		private static readonly IntPtr NativeMethodInfoPtr_SendDie_Public_Void_0;

		// Token: 0x04002F88 RID: 12168
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Void_0;

		// Token: 0x04002F89 RID: 12169
		private static readonly IntPtr NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04002F8A RID: 12170
		private static readonly IntPtr NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04002F8B RID: 12171
		private static readonly IntPtr NativeMethodInfoPtr_PlayBloodMist_Public_Void_0;

		// Token: 0x04002F8C RID: 12172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F8D RID: 12173
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0;

		// Token: 0x04002F8E RID: 12174
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002F8F RID: 12175
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002F90 RID: 12176
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002F91 RID: 12177
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0;

		// Token: 0x04002F92 RID: 12178
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x04002F93 RID: 12179
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F94 RID: 12180
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0;

		// Token: 0x04002F95 RID: 12181
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0;

		// Token: 0x04002F96 RID: 12182
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F97 RID: 12183
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0;

		// Token: 0x04002F98 RID: 12184
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0;

		// Token: 0x04002F99 RID: 12185
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F9A RID: 12186
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04002F9B RID: 12187
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04002F9C RID: 12188
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F9D RID: 12189
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04002F9E RID: 12190
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04002F9F RID: 12191
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002FA0 RID: 12192
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0;

		// Token: 0x04002FA1 RID: 12193
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0;

		// Token: 0x04002FA2 RID: 12194
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002FA3 RID: 12195
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}

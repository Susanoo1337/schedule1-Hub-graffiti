using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Core.Audio;
using Il2CppScheduleOne.Core.Weather;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006DC RID: 1756
	public class ThunderController : WeatherEffectController
	{
		// Token: 0x0600A920 RID: 43296 RVA: 0x002CB98C File Offset: 0x002C9B8C
		// Note: this type is marked as 'beforefieldinit'.
		static ThunderController()
		{
			Il2CppClassPointerStore<ThunderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "ThunderController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThunderController>.NativeClassPtr);
			ThunderController.NativeFieldInfoPtr__npcLightningStrikeDistanceFromPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_npcLightningStrikeDistanceFromPlayer");
			ThunderController.NativeFieldInfoPtr__maxThunderDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_maxThunderDelay");
			ThunderController.NativeFieldInfoPtr__timeBetweenThunders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_timeBetweenThunders");
			ThunderController.NativeFieldInfoPtr__chanceForLightingStrike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_chanceForLightingStrike");
			ThunderController.NativeFieldInfoPtr__chanceForLightingToHitPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_chanceForLightingToHitPlayer");
			ThunderController.NativeFieldInfoPtr__chanceForLightingToHitNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_chanceForLightingToHitNPC");
			ThunderController.NativeFieldInfoPtr__sqrDistanceToPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_sqrDistanceToPlayer");
			ThunderController.NativeFieldInfoPtr__thundertimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_thundertimer");
			ThunderController.NativeFieldInfoPtr__timeUntilNextThunder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_timeUntilNextThunder");
			ThunderController.NativeFieldInfoPtr__effectNormalisedDistanceToPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_effectNormalisedDistanceToPlayer");
			ThunderController.NativeFieldInfoPtr__thunderAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_thunderAudio");
			ThunderController.NativeFieldInfoPtr__lightningAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_lightningAudio");
			ThunderController.NativeFieldInfoPtr__lightningEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_lightningEffect");
			ThunderController.NativeFieldInfoPtr__thunderEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_thunderEffect");
			ThunderController.NativeFieldInfoPtr__debugThunderLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "_debugThunderLocation");
			ThunderController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Weather.ThunderControllerAssembly-CSharp.dll_Excuted");
			ThunderController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Weather.ThunderControllerAssembly-CSharp.dll_Excuted");
			ThunderController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685716);
			ThunderController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685717);
			ThunderController.NativeMethodInfoPtr_Initialise_Public_Void_WeatherVolume_ThunderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685718);
			ThunderController.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685719);
			ThunderController.NativeMethodInfoPtr_TriggerThunder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685720);
			ThunderController.NativeMethodInfoPtr_TriggerRandomLightningStrike_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685721);
			ThunderController.NativeMethodInfoPtr_TriggerRandomPlayerLightningStrike_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685722);
			ThunderController.NativeMethodInfoPtr_TriggerEntityLightningStrike_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685723);
			ThunderController.NativeMethodInfoPtr_TriggerRandomNPCLightningStrike_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685724);
			ThunderController.NativeMethodInfoPtr_TriggerLightningStrike_Server_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685725);
			ThunderController.NativeMethodInfoPtr_TriggerLightningStrike_Client_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685726);
			ThunderController.NativeMethodInfoPtr_TriggerDistantThunder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685727);
			ThunderController.NativeMethodInfoPtr_TriggerDistantThunder_Client_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685728);
			ThunderController.NativeMethodInfoPtr_RandomiseThunderTimer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685729);
			ThunderController.NativeMethodInfoPtr_UpdateAudio_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685730);
			ThunderController.NativeMethodInfoPtr_GetRandomPointInVolume_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685731);
			ThunderController.NativeMethodInfoPtr_UpdateAudio_Private_Boolean_AudioSourceController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685732);
			ThunderController.NativeMethodInfoPtr_UpdateProperties_Public_Virtual_Void_Vector3_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685733);
			ThunderController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685734);
			ThunderController.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Player_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685735);
			ThunderController.NativeMethodInfoPtr_Method_Internal_Static_Boolean_NPC_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685736);
			ThunderController.NativeMethodInfoPtr__TriggerLightningStrike_Client_b__25_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685737);
			ThunderController.NativeMethodInfoPtr__TriggerDistantThunder_Client_b__27_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685738);
			ThunderController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685739);
			ThunderController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685740);
			ThunderController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685741);
			ThunderController.NativeMethodInfoPtr_RpcWriter___Server_TriggerLightningStrike_Server_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685742);
			ThunderController.NativeMethodInfoPtr_RpcLogic___TriggerLightningStrike_Server_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685743);
			ThunderController.NativeMethodInfoPtr_RpcReader___Server_TriggerLightningStrike_Server_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685744);
			ThunderController.NativeMethodInfoPtr_RpcWriter___Observers_TriggerLightningStrike_Client_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685745);
			ThunderController.NativeMethodInfoPtr_RpcLogic___TriggerLightningStrike_Client_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685746);
			ThunderController.NativeMethodInfoPtr_RpcReader___Observers_TriggerLightningStrike_Client_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685747);
			ThunderController.NativeMethodInfoPtr_RpcWriter___Observers_TriggerDistantThunder_Client_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685748);
			ThunderController.NativeMethodInfoPtr_RpcLogic___TriggerDistantThunder_Client_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685749);
			ThunderController.NativeMethodInfoPtr_RpcReader___Observers_TriggerDistantThunder_Client_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685750);
			ThunderController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, 100685751);
		}

		// Token: 0x0600A921 RID: 43297 RVA: 0x002CBDE0 File Offset: 0x002C9FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292926, XrefRangeEnd = 292927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThunderController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A922 RID: 43298 RVA: 0x002CBE1C File Offset: 0x002CA01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292927, XrefRangeEnd = 292933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A923 RID: 43299 RVA: 0x002CBE50 File Offset: 0x002CA050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292933, XrefRangeEnd = 292934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialise(WeatherVolume mainVolume, ThunderSettings thunderSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mainVolume);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thunderSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_Initialise_Public_Void_WeatherVolume_ThunderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A924 RID: 43300 RVA: 0x002CBEA4 File Offset: 0x002CA0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292934, XrefRangeEnd = 292938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThunderController.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A925 RID: 43301 RVA: 0x002CBEE0 File Offset: 0x002CA0E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292962, RefRangeEnd = 292963, XrefRangeStart = 292938, XrefRangeEnd = 292962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerThunder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_TriggerThunder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A926 RID: 43302 RVA: 0x002CBF14 File Offset: 0x002CA114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292971, RefRangeEnd = 292972, XrefRangeStart = 292963, XrefRangeEnd = 292971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerRandomLightningStrike()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_TriggerRandomLightningStrike_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A927 RID: 43303 RVA: 0x002CBF48 File Offset: 0x002CA148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292972, XrefRangeEnd = 293002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerRandomPlayerLightningStrike()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_TriggerRandomPlayerLightningStrike_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A928 RID: 43304 RVA: 0x002CBF7C File Offset: 0x002CA17C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293004, RefRangeEnd = 293005, XrefRangeStart = 293002, XrefRangeEnd = 293004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerEntityLightningStrike(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_TriggerEntityLightningStrike_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A929 RID: 43305 RVA: 0x002CBFBC File Offset: 0x002CA1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293005, XrefRangeEnd = 293040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerRandomNPCLightningStrike()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_TriggerRandomNPCLightningStrike_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A92A RID: 43306 RVA: 0x002CBFF0 File Offset: 0x002CA1F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293052, RefRangeEnd = 293055, XrefRangeStart = 293040, XrefRangeEnd = 293052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerLightningStrike_Server(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_TriggerLightningStrike_Server_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A92B RID: 43307 RVA: 0x002CC030 File Offset: 0x002CA230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293055, XrefRangeEnd = 293067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerLightningStrike_Client(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_TriggerLightningStrike_Client_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A92C RID: 43308 RVA: 0x002CC070 File Offset: 0x002CA270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293080, RefRangeEnd = 293081, XrefRangeStart = 293067, XrefRangeEnd = 293080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerDistantThunder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_TriggerDistantThunder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A92D RID: 43309 RVA: 0x002CC0A4 File Offset: 0x002CA2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293081, XrefRangeEnd = 293093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerDistantThunder_Client(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_TriggerDistantThunder_Client_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A92E RID: 43310 RVA: 0x002CC0E4 File Offset: 0x002CA2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293093, XrefRangeEnd = 293094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomiseThunderTimer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_RandomiseThunderTimer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A92F RID: 43311 RVA: 0x002CC118 File Offset: 0x002CA318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293094, XrefRangeEnd = 293115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool UpdateAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThunderController.NativeMethodInfoPtr_UpdateAudio_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A930 RID: 43312 RVA: 0x002CC160 File Offset: 0x002CA360
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293120, RefRangeEnd = 293123, XrefRangeStart = 293115, XrefRangeEnd = 293120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomPointInVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_GetRandomPointInVolume_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A931 RID: 43313 RVA: 0x002CC19C File Offset: 0x002CA39C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293162, RefRangeEnd = 293163, XrefRangeStart = 293123, XrefRangeEnd = 293162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateAudio(AudioSourceController audioSource, bool useEffectDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioSource);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useEffectDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_UpdateAudio_Private_Boolean_AudioSourceController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x002CC1F8 File Offset: 0x002CA3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293163, XrefRangeEnd = 293168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateProperties(Vector3 anchorPosition, Vector3 playerPosition, float sqrDistanceToPlayer, float enclosureBlend, float enclosurePan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref anchorPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sqrDistanceToPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enclosureBlend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enclosurePan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThunderController.NativeMethodInfoPtr_UpdateProperties_Public_Virtual_Void_Vector3_Vector3_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x002CC27C File Offset: 0x002CA47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293168, XrefRangeEnd = 293169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThunderController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThunderController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x002CC2B8 File Offset: 0x002CA4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293169, XrefRangeEnd = 293173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Player_PDM_0(Player player)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Player_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A935 RID: 43317 RVA: 0x002CC2FC File Offset: 0x002CA4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293173, XrefRangeEnd = 293181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_NPC_PDM_0(NPC npc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_Method_Internal_Static_Boolean_NPC_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A936 RID: 43318 RVA: 0x002CC340 File Offset: 0x002CA540
		[CallerCount(0)]
		public unsafe void _TriggerLightningStrike_Client_b__25_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr__TriggerLightningStrike_Client_b__25_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A937 RID: 43319 RVA: 0x002CC374 File Offset: 0x002CA574
		[CallerCount(0)]
		public unsafe void _TriggerDistantThunder_Client_b__27_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr__TriggerDistantThunder_Client_b__27_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A938 RID: 43320 RVA: 0x002CC3A8 File Offset: 0x002CA5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293181, XrefRangeEnd = 293202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThunderController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A939 RID: 43321 RVA: 0x002CC3E4 File Offset: 0x002CA5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293202, XrefRangeEnd = 293203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThunderController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A93A RID: 43322 RVA: 0x002CC420 File Offset: 0x002CA620
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThunderController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A93B RID: 43323 RVA: 0x002CC45C File Offset: 0x002CA65C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293052, RefRangeEnd = 293055, XrefRangeStart = 293052, XrefRangeEnd = 293055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_TriggerLightningStrike_Server_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_RpcWriter___Server_TriggerLightningStrike_Server_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A93C RID: 43324 RVA: 0x002CC49C File Offset: 0x002CA69C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293235, RefRangeEnd = 293236, XrefRangeStart = 293203, XrefRangeEnd = 293235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TriggerLightningStrike_Server_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_RpcLogic___TriggerLightningStrike_Server_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A93D RID: 43325 RVA: 0x002CC4DC File Offset: 0x002CA6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293236, XrefRangeEnd = 293241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_TriggerLightningStrike_Server_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_RpcReader___Server_TriggerLightningStrike_Server_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A93E RID: 43326 RVA: 0x002CC540 File Offset: 0x002CA740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_TriggerLightningStrike_Client_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_RpcWriter___Observers_TriggerLightningStrike_Client_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A93F RID: 43327 RVA: 0x002CC580 File Offset: 0x002CA780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293261, RefRangeEnd = 293262, XrefRangeStart = 293241, XrefRangeEnd = 293261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TriggerLightningStrike_Client_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_RpcLogic___TriggerLightningStrike_Client_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A940 RID: 43328 RVA: 0x002CC5C0 File Offset: 0x002CA7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293262, XrefRangeEnd = 293267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_TriggerLightningStrike_Client_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_RpcReader___Observers_TriggerLightningStrike_Client_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A941 RID: 43329 RVA: 0x002CC610 File Offset: 0x002CA810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_TriggerDistantThunder_Client_4276783012(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_RpcWriter___Observers_TriggerDistantThunder_Client_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A942 RID: 43330 RVA: 0x002CC650 File Offset: 0x002CA850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293280, RefRangeEnd = 293281, XrefRangeStart = 293267, XrefRangeEnd = 293280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TriggerDistantThunder_Client_4276783012(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_RpcLogic___TriggerDistantThunder_Client_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A943 RID: 43331 RVA: 0x002CC690 File Offset: 0x002CA890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293281, XrefRangeEnd = 293286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_TriggerDistantThunder_Client_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.NativeMethodInfoPtr_RpcReader___Observers_TriggerDistantThunder_Client_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A944 RID: 43332 RVA: 0x002CC6E0 File Offset: 0x002CA8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293364, RefRangeEnd = 293365, XrefRangeStart = 293286, XrefRangeEnd = 293364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThunderController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A945 RID: 43333 RVA: 0x0004D0F5 File Offset: 0x0004B2F5
		public ThunderController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600A946 RID: 43334 RVA: 0x002CC71C File Offset: 0x002CA91C
		// (set) Token: 0x0600A947 RID: 43335 RVA: 0x0004D0FE File Offset: 0x0004B2FE
		public unsafe static float _npcLightningStrikeDistanceFromPlayer
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ThunderController.NativeFieldInfoPtr__npcLightningStrikeDistanceFromPlayer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThunderController.NativeFieldInfoPtr__npcLightningStrikeDistanceFromPlayer, (void*)(&value));
			}
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600A948 RID: 43336 RVA: 0x002CC738 File Offset: 0x002CA938
		// (set) Token: 0x0600A949 RID: 43337 RVA: 0x0004D10C File Offset: 0x0004B30C
		public unsafe float _maxThunderDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__maxThunderDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__maxThunderDelay)) = value;
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600A94A RID: 43338 RVA: 0x002CC760 File Offset: 0x002CA960
		// (set) Token: 0x0600A94B RID: 43339 RVA: 0x0004D127 File Offset: 0x0004B327
		public unsafe Vector2 _timeBetweenThunders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__timeBetweenThunders);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__timeBetweenThunders)) = value;
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600A94C RID: 43340 RVA: 0x002CC788 File Offset: 0x002CA988
		// (set) Token: 0x0600A94D RID: 43341 RVA: 0x0004D142 File Offset: 0x0004B342
		public unsafe float _chanceForLightingStrike
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__chanceForLightingStrike);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__chanceForLightingStrike)) = value;
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600A94E RID: 43342 RVA: 0x002CC7B0 File Offset: 0x002CA9B0
		// (set) Token: 0x0600A94F RID: 43343 RVA: 0x0004D15D File Offset: 0x0004B35D
		public unsafe float _chanceForLightingToHitPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__chanceForLightingToHitPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__chanceForLightingToHitPlayer)) = value;
			}
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600A950 RID: 43344 RVA: 0x002CC7D8 File Offset: 0x002CA9D8
		// (set) Token: 0x0600A951 RID: 43345 RVA: 0x0004D178 File Offset: 0x0004B378
		public unsafe float _chanceForLightingToHitNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__chanceForLightingToHitNPC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__chanceForLightingToHitNPC)) = value;
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600A952 RID: 43346 RVA: 0x002CC800 File Offset: 0x002CAA00
		// (set) Token: 0x0600A953 RID: 43347 RVA: 0x0004D193 File Offset: 0x0004B393
		public unsafe float _sqrDistanceToPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__sqrDistanceToPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__sqrDistanceToPlayer)) = value;
			}
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600A954 RID: 43348 RVA: 0x002CC828 File Offset: 0x002CAA28
		// (set) Token: 0x0600A955 RID: 43349 RVA: 0x0004D1AE File Offset: 0x0004B3AE
		public unsafe float _thundertimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__thundertimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__thundertimer)) = value;
			}
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600A956 RID: 43350 RVA: 0x002CC850 File Offset: 0x002CAA50
		// (set) Token: 0x0600A957 RID: 43351 RVA: 0x0004D1C9 File Offset: 0x0004B3C9
		public unsafe float _timeUntilNextThunder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__timeUntilNextThunder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__timeUntilNextThunder)) = value;
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600A958 RID: 43352 RVA: 0x002CC878 File Offset: 0x002CAA78
		// (set) Token: 0x0600A959 RID: 43353 RVA: 0x0004D1E4 File Offset: 0x0004B3E4
		public unsafe float _effectNormalisedDistanceToPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__effectNormalisedDistanceToPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__effectNormalisedDistanceToPlayer)) = value;
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600A95A RID: 43354 RVA: 0x002CC8A0 File Offset: 0x002CAAA0
		// (set) Token: 0x0600A95B RID: 43355 RVA: 0x0004D1FF File Offset: 0x0004B3FF
		public unsafe RandomizedAudioSourceController _thunderAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__thunderAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomizedAudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__thunderAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600A95C RID: 43356 RVA: 0x002CC8D0 File Offset: 0x002CAAD0
		// (set) Token: 0x0600A95D RID: 43357 RVA: 0x0004D21E File Offset: 0x0004B41E
		public unsafe RandomizedAudioSourceController _lightningAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__lightningAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomizedAudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__lightningAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600A95E RID: 43358 RVA: 0x002CC900 File Offset: 0x002CAB00
		// (set) Token: 0x0600A95F RID: 43359 RVA: 0x0004D23D File Offset: 0x0004B43D
		public unsafe VFXEffectHandler _lightningEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__lightningEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXEffectHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__lightningEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600A960 RID: 43360 RVA: 0x002CC930 File Offset: 0x002CAB30
		// (set) Token: 0x0600A961 RID: 43361 RVA: 0x0004D25C File Offset: 0x0004B45C
		public unsafe VFXEffectHandler _thunderEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__thunderEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXEffectHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__thunderEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600A962 RID: 43362 RVA: 0x002CC960 File Offset: 0x002CAB60
		// (set) Token: 0x0600A963 RID: 43363 RVA: 0x0004D27B File Offset: 0x0004B47B
		public unsafe Vector3 _debugThunderLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__debugThunderLocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr__debugThunderLocation)) = value;
			}
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600A964 RID: 43364 RVA: 0x002CC988 File Offset: 0x002CAB88
		// (set) Token: 0x0600A965 RID: 43365 RVA: 0x0004D296 File Offset: 0x0004B496
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600A966 RID: 43366 RVA: 0x002CC9B0 File Offset: 0x002CABB0
		// (set) Token: 0x0600A967 RID: 43367 RVA: 0x0004D2B1 File Offset: 0x0004B4B1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040074E5 RID: 29925
		private static readonly IntPtr NativeFieldInfoPtr__npcLightningStrikeDistanceFromPlayer;

		// Token: 0x040074E6 RID: 29926
		private static readonly IntPtr NativeFieldInfoPtr__maxThunderDelay;

		// Token: 0x040074E7 RID: 29927
		private static readonly IntPtr NativeFieldInfoPtr__timeBetweenThunders;

		// Token: 0x040074E8 RID: 29928
		private static readonly IntPtr NativeFieldInfoPtr__chanceForLightingStrike;

		// Token: 0x040074E9 RID: 29929
		private static readonly IntPtr NativeFieldInfoPtr__chanceForLightingToHitPlayer;

		// Token: 0x040074EA RID: 29930
		private static readonly IntPtr NativeFieldInfoPtr__chanceForLightingToHitNPC;

		// Token: 0x040074EB RID: 29931
		private static readonly IntPtr NativeFieldInfoPtr__sqrDistanceToPlayer;

		// Token: 0x040074EC RID: 29932
		private static readonly IntPtr NativeFieldInfoPtr__thundertimer;

		// Token: 0x040074ED RID: 29933
		private static readonly IntPtr NativeFieldInfoPtr__timeUntilNextThunder;

		// Token: 0x040074EE RID: 29934
		private static readonly IntPtr NativeFieldInfoPtr__effectNormalisedDistanceToPlayer;

		// Token: 0x040074EF RID: 29935
		private static readonly IntPtr NativeFieldInfoPtr__thunderAudio;

		// Token: 0x040074F0 RID: 29936
		private static readonly IntPtr NativeFieldInfoPtr__lightningAudio;

		// Token: 0x040074F1 RID: 29937
		private static readonly IntPtr NativeFieldInfoPtr__lightningEffect;

		// Token: 0x040074F2 RID: 29938
		private static readonly IntPtr NativeFieldInfoPtr__thunderEffect;

		// Token: 0x040074F3 RID: 29939
		private static readonly IntPtr NativeFieldInfoPtr__debugThunderLocation;

		// Token: 0x040074F4 RID: 29940
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040074F5 RID: 29941
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040074F6 RID: 29942
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040074F7 RID: 29943
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040074F8 RID: 29944
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Void_WeatherVolume_ThunderSettings_0;

		// Token: 0x040074F9 RID: 29945
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_1;

		// Token: 0x040074FA RID: 29946
		private static readonly IntPtr NativeMethodInfoPtr_TriggerThunder_Private_Void_0;

		// Token: 0x040074FB RID: 29947
		private static readonly IntPtr NativeMethodInfoPtr_TriggerRandomLightningStrike_Public_Void_0;

		// Token: 0x040074FC RID: 29948
		private static readonly IntPtr NativeMethodInfoPtr_TriggerRandomPlayerLightningStrike_Public_Void_0;

		// Token: 0x040074FD RID: 29949
		private static readonly IntPtr NativeMethodInfoPtr_TriggerEntityLightningStrike_Public_Void_Vector3_0;

		// Token: 0x040074FE RID: 29950
		private static readonly IntPtr NativeMethodInfoPtr_TriggerRandomNPCLightningStrike_Public_Void_0;

		// Token: 0x040074FF RID: 29951
		private static readonly IntPtr NativeMethodInfoPtr_TriggerLightningStrike_Server_Private_Void_Vector3_0;

		// Token: 0x04007500 RID: 29952
		private static readonly IntPtr NativeMethodInfoPtr_TriggerLightningStrike_Client_Private_Void_Vector3_0;

		// Token: 0x04007501 RID: 29953
		private static readonly IntPtr NativeMethodInfoPtr_TriggerDistantThunder_Public_Void_0;

		// Token: 0x04007502 RID: 29954
		private static readonly IntPtr NativeMethodInfoPtr_TriggerDistantThunder_Client_Private_Void_Vector3_0;

		// Token: 0x04007503 RID: 29955
		private static readonly IntPtr NativeMethodInfoPtr_RandomiseThunderTimer_Private_Void_0;

		// Token: 0x04007504 RID: 29956
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAudio_Public_Virtual_Boolean_0;

		// Token: 0x04007505 RID: 29957
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomPointInVolume_Private_Vector3_0;

		// Token: 0x04007506 RID: 29958
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAudio_Private_Boolean_AudioSourceController_Boolean_0;

		// Token: 0x04007507 RID: 29959
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProperties_Public_Virtual_Void_Vector3_Vector3_Single_Single_Single_0;

		// Token: 0x04007508 RID: 29960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007509 RID: 29961
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Player_PDM_0;

		// Token: 0x0400750A RID: 29962
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_NPC_PDM_0;

		// Token: 0x0400750B RID: 29963
		private static readonly IntPtr NativeMethodInfoPtr__TriggerLightningStrike_Client_b__25_0_Private_Void_0;

		// Token: 0x0400750C RID: 29964
		private static readonly IntPtr NativeMethodInfoPtr__TriggerDistantThunder_Client_b__27_0_Private_Void_0;

		// Token: 0x0400750D RID: 29965
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400750E RID: 29966
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400750F RID: 29967
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007510 RID: 29968
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_TriggerLightningStrike_Server_4276783012_Private_Void_Vector3_0;

		// Token: 0x04007511 RID: 29969
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TriggerLightningStrike_Server_4276783012_Private_Void_Vector3_0;

		// Token: 0x04007512 RID: 29970
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_TriggerLightningStrike_Server_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007513 RID: 29971
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_TriggerLightningStrike_Client_4276783012_Private_Void_Vector3_0;

		// Token: 0x04007514 RID: 29972
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TriggerLightningStrike_Client_4276783012_Private_Void_Vector3_0;

		// Token: 0x04007515 RID: 29973
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_TriggerLightningStrike_Client_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007516 RID: 29974
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_TriggerDistantThunder_Client_4276783012_Private_Void_Vector3_0;

		// Token: 0x04007517 RID: 29975
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TriggerDistantThunder_Client_4276783012_Private_Void_Vector3_0;

		// Token: 0x04007518 RID: 29976
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_TriggerDistantThunder_Client_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007519 RID: 29977
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C89 RID: 3209
		[ObfuscatedName("ScheduleOne.Weather.ThunderController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F288 RID: 62088 RVA: 0x003A6FF4 File Offset: 0x003A51F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr);
				ThunderController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, "<>9");
				ThunderController.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, "<>9__15_0");
				ThunderController.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, "<>9__15_1");
				ThunderController.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, "<>9__15_2");
				ThunderController.__c.NativeFieldInfoPtr___9__15_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, "<>9__15_3");
				ThunderController.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, "<>9__21_0");
				ThunderController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, 100685753);
				ThunderController.__c.NativeMethodInfoPtr__Awake_b__15_0_Internal_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, 100685754);
				ThunderController.__c.NativeMethodInfoPtr__Awake_b__15_1_Internal_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, 100685755);
				ThunderController.__c.NativeMethodInfoPtr__Awake_b__15_2_Internal_Boolean_VFXEffectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, 100685756);
				ThunderController.__c.NativeMethodInfoPtr__Awake_b__15_3_Internal_Boolean_VFXEffectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, 100685757);
				ThunderController.__c.NativeMethodInfoPtr__TriggerRandomPlayerLightningStrike_b__21_0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr, 100685758);
			}

			// Token: 0x0600F289 RID: 62089 RVA: 0x003A7110 File Offset: 0x003A5310
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThunderController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F28A RID: 62090 RVA: 0x003A714C File Offset: 0x003A534C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292883, XrefRangeEnd = 292887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__15_0(AudioSourceController s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c.NativeMethodInfoPtr__Awake_b__15_0_Internal_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F28B RID: 62091 RVA: 0x003A719C File Offset: 0x003A539C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292887, XrefRangeEnd = 292891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__15_1(AudioSourceController s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c.NativeMethodInfoPtr__Awake_b__15_1_Internal_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F28C RID: 62092 RVA: 0x003A71EC File Offset: 0x003A53EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292891, XrefRangeEnd = 292895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__15_2(VFXEffectHandler e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c.NativeMethodInfoPtr__Awake_b__15_2_Internal_Boolean_VFXEffectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F28D RID: 62093 RVA: 0x003A723C File Offset: 0x003A543C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292895, XrefRangeEnd = 292899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__15_3(VFXEffectHandler e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c.NativeMethodInfoPtr__Awake_b__15_3_Internal_Boolean_VFXEffectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F28E RID: 62094 RVA: 0x003A728C File Offset: 0x003A548C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292899, XrefRangeEnd = 292903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TriggerRandomPlayerLightningStrike_b__21_0(Player x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c.NativeMethodInfoPtr__TriggerRandomPlayerLightningStrike_b__21_0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F28F RID: 62095 RVA: 0x0007274A File Offset: 0x0007094A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700499C RID: 18844
			// (get) Token: 0x0600F290 RID: 62096 RVA: 0x003A72DC File Offset: 0x003A54DC
			// (set) Token: 0x0600F291 RID: 62097 RVA: 0x00072753 File Offset: 0x00070953
			public unsafe static ThunderController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ThunderController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThunderController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThunderController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700499D RID: 18845
			// (get) Token: 0x0600F292 RID: 62098 RVA: 0x003A7304 File Offset: 0x003A5504
			// (set) Token: 0x0600F293 RID: 62099 RVA: 0x00072765 File Offset: 0x00070965
			public unsafe static Predicate<AudioSourceController> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ThunderController.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AudioSourceController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThunderController.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700499E RID: 18846
			// (get) Token: 0x0600F294 RID: 62100 RVA: 0x003A732C File Offset: 0x003A552C
			// (set) Token: 0x0600F295 RID: 62101 RVA: 0x00072777 File Offset: 0x00070977
			public unsafe static Predicate<AudioSourceController> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ThunderController.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AudioSourceController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThunderController.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700499F RID: 18847
			// (get) Token: 0x0600F296 RID: 62102 RVA: 0x003A7354 File Offset: 0x003A5554
			// (set) Token: 0x0600F297 RID: 62103 RVA: 0x00072789 File Offset: 0x00070989
			public unsafe static Predicate<VFXEffectHandler> __9__15_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ThunderController.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<VFXEffectHandler>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThunderController.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049A0 RID: 18848
			// (get) Token: 0x0600F298 RID: 62104 RVA: 0x003A737C File Offset: 0x003A557C
			// (set) Token: 0x0600F299 RID: 62105 RVA: 0x0007279B File Offset: 0x0007099B
			public unsafe static Predicate<VFXEffectHandler> __9__15_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ThunderController.__c.NativeFieldInfoPtr___9__15_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<VFXEffectHandler>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThunderController.__c.NativeFieldInfoPtr___9__15_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049A1 RID: 18849
			// (get) Token: 0x0600F29A RID: 62106 RVA: 0x003A73A4 File Offset: 0x003A55A4
			// (set) Token: 0x0600F29B RID: 62107 RVA: 0x000727AD File Offset: 0x000709AD
			public unsafe static Func<Player, bool> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ThunderController.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Player, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThunderController.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A410 RID: 42000
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A411 RID: 42001
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400A412 RID: 42002
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x0400A413 RID: 42003
			private static readonly IntPtr NativeFieldInfoPtr___9__15_2;

			// Token: 0x0400A414 RID: 42004
			private static readonly IntPtr NativeFieldInfoPtr___9__15_3;

			// Token: 0x0400A415 RID: 42005
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x0400A416 RID: 42006
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A417 RID: 42007
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__15_0_Internal_Boolean_AudioSourceController_0;

			// Token: 0x0400A418 RID: 42008
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__15_1_Internal_Boolean_AudioSourceController_0;

			// Token: 0x0400A419 RID: 42009
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__15_2_Internal_Boolean_VFXEffectHandler_0;

			// Token: 0x0400A41A RID: 42010
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__15_3_Internal_Boolean_VFXEffectHandler_0;

			// Token: 0x0400A41B RID: 42011
			private static readonly IntPtr NativeMethodInfoPtr__TriggerRandomPlayerLightningStrike_b__21_0_Internal_Boolean_Player_0;
		}

		// Token: 0x02000C8A RID: 3210
		[ObfuscatedName("ScheduleOne.Weather.ThunderController+<>c__DisplayClass23_0")]
		public new sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F29C RID: 62108 RVA: 0x003A73CC File Offset: 0x003A55CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<ThunderController.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThunderController.__c__DisplayClass23_0>.NativeClassPtr);
				ThunderController.__c__DisplayClass23_0.NativeFieldInfoPtr_plr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController.__c__DisplayClass23_0>.NativeClassPtr, "plr");
				ThunderController.__c__DisplayClass23_0.NativeFieldInfoPtr_lightningStrikeDistanceSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController.__c__DisplayClass23_0>.NativeClassPtr, "lightningStrikeDistanceSqr");
				ThunderController.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c__DisplayClass23_0>.NativeClassPtr, 100685759);
				ThunderController.__c__DisplayClass23_0.NativeMethodInfoPtr__TriggerRandomNPCLightningStrike_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c__DisplayClass23_0>.NativeClassPtr, 100685760);
			}

			// Token: 0x0600F29D RID: 62109 RVA: 0x003A7448 File Offset: 0x003A5648
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThunderController.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F29E RID: 62110 RVA: 0x003A7484 File Offset: 0x003A5684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292903, XrefRangeEnd = 292916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TriggerRandomNPCLightningStrike_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c__DisplayClass23_0.NativeMethodInfoPtr__TriggerRandomNPCLightningStrike_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F29F RID: 62111 RVA: 0x000727BF File Offset: 0x000709BF
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049A2 RID: 18850
			// (get) Token: 0x0600F2A0 RID: 62112 RVA: 0x003A74D4 File Offset: 0x003A56D4
			// (set) Token: 0x0600F2A1 RID: 62113 RVA: 0x000727C8 File Offset: 0x000709C8
			public unsafe Player plr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.__c__DisplayClass23_0.NativeFieldInfoPtr_plr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.__c__DisplayClass23_0.NativeFieldInfoPtr_plr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049A3 RID: 18851
			// (get) Token: 0x0600F2A2 RID: 62114 RVA: 0x003A7504 File Offset: 0x003A5704
			// (set) Token: 0x0600F2A3 RID: 62115 RVA: 0x000727E7 File Offset: 0x000709E7
			public unsafe float lightningStrikeDistanceSqr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.__c__DisplayClass23_0.NativeFieldInfoPtr_lightningStrikeDistanceSqr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.__c__DisplayClass23_0.NativeFieldInfoPtr_lightningStrikeDistanceSqr)) = value;
				}
			}

			// Token: 0x0400A41C RID: 42012
			private static readonly IntPtr NativeFieldInfoPtr_plr;

			// Token: 0x0400A41D RID: 42013
			private static readonly IntPtr NativeFieldInfoPtr_lightningStrikeDistanceSqr;

			// Token: 0x0400A41E RID: 42014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A41F RID: 42015
			private static readonly IntPtr NativeMethodInfoPtr__TriggerRandomNPCLightningStrike_b__0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000C8B RID: 3211
		[ObfuscatedName("ScheduleOne.Weather.ThunderController+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2A4 RID: 62116 RVA: 0x003A752C File Offset: 0x003A572C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<ThunderController.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThunderController>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThunderController.__c__DisplayClass31_0>.NativeClassPtr);
				ThunderController.__c__DisplayClass31_0.NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThunderController.__c__DisplayClass31_0>.NativeClassPtr, "audioSource");
				ThunderController.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c__DisplayClass31_0>.NativeClassPtr, 100685761);
				ThunderController.__c__DisplayClass31_0.NativeMethodInfoPtr__UpdateAudio_b__0_Internal_Boolean_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c__DisplayClass31_0>.NativeClassPtr, 100685762);
				ThunderController.__c__DisplayClass31_0.NativeMethodInfoPtr__UpdateAudio_b__1_Internal_Boolean_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThunderController.__c__DisplayClass31_0>.NativeClassPtr, 100685763);
			}

			// Token: 0x0600F2A5 RID: 62117 RVA: 0x003A75A8 File Offset: 0x003A57A8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThunderController.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2A6 RID: 62118 RVA: 0x003A75E4 File Offset: 0x003A57E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292916, XrefRangeEnd = 292921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateAudio_b__0(Il2CppScheduleOne.Core.Audio.AudioSettings s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c__DisplayClass31_0.NativeMethodInfoPtr__UpdateAudio_b__0_Internal_Boolean_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2A7 RID: 62119 RVA: 0x003A7634 File Offset: 0x003A5834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292921, XrefRangeEnd = 292926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateAudio_b__1(Il2CppScheduleOne.Core.Audio.AudioSettings s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThunderController.__c__DisplayClass31_0.NativeMethodInfoPtr__UpdateAudio_b__1_Internal_Boolean_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2A8 RID: 62120 RVA: 0x00072802 File Offset: 0x00070A02
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049A4 RID: 18852
			// (get) Token: 0x0600F2A9 RID: 62121 RVA: 0x003A7684 File Offset: 0x003A5884
			// (set) Token: 0x0600F2AA RID: 62122 RVA: 0x0007280B File Offset: 0x00070A0B
			public unsafe AudioSourceController audioSource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.__c__DisplayClass31_0.NativeFieldInfoPtr_audioSource);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThunderController.__c__DisplayClass31_0.NativeFieldInfoPtr_audioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A420 RID: 42016
			private static readonly IntPtr NativeFieldInfoPtr_audioSource;

			// Token: 0x0400A421 RID: 42017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A422 RID: 42018
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAudio_b__0_Internal_Boolean_AudioSettings_0;

			// Token: 0x0400A423 RID: 42019
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAudio_b__1_Internal_Boolean_AudioSettings_0;
		}
	}
}

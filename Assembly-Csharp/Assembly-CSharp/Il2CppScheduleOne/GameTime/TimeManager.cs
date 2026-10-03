using System;
using Il2Cpp;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x0200010D RID: 269
	public class TimeManager : NetworkSingleton<TimeManager>
	{
		// Token: 0x060019D0 RID: 6608 RVA: 0x000CFFE0 File Offset: 0x000CE1E0
		// Note: this type is marked as 'beforefieldinit'.
		static TimeManager()
		{
			Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "TimeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr);
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultCycleDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "DefaultCycleDuration");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TickDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "TickDuration");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_EndOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "EndOfDay");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_WakeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "WakeTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CycleDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "CycleDuration");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DefaultTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<DefaultTime>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__defaultDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "_defaultDay");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<CurrentTime>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<ElapsedDays>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__IsSleepInProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<IsSleepInProgress>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<Playtime>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostSleepDone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<HostSleepDone>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeSpeedMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeSpeedMultiplier>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinSum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<DailyMinSum>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__lastMinWaitExcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "_lastMinWaitExcess");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__stopMinPassWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "_stopMinPassWait");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__secondsOnCurrentMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "_secondsOnCurrentMinute");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onMinutePass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUncappedMinutePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onUncappedMinutePass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTick");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTimeChanged");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTimeSkip");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTimeSet");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onHourPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onDayPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onWeekPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onUpdate");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onFixedUpdate");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onSleepStart");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onSleepEnd");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "loader");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<LoadOrder>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted");
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_MinuteDuration_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666726);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DefaultTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666727);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_DefaultTime_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666728);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666729);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_CurrentTime_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666730);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666731);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666732);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_ElapsedDays_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666733);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666734);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666735);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_NormalizedTimeOfDay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666736);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666737);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsSleepInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666738);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_IsSleepInProgress_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666739);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Playtime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666740);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_Playtime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666741);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HostSleepDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666742);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HostSleepDone_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666743);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666744);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeSpeedMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666745);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DailyMinSum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666746);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_DailyMinSum_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666747);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get__minuteStaggerTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666748);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get__tickStaggerTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666749);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666750);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666751);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666752);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666753);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666754);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666755);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666756);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666757);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666758);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666759);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666760);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666761);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666762);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666763);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666764);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666765);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666766);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666767);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeData_Client_Private_Void_NetworkConnection_Int32_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666768);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666769);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666770);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666771);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666772);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_ShouldMinutePass_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666773);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_PassMinute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666774);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_PassMinute_Client_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666775);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeAndSync_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666776);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTime_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666777);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666778);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666779);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666780);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666781);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeSpeedMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666782);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetCycleDuration_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666783);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_CheckSleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666784);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StartSleep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666785);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetHostSleepDone_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666786);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SkipForwardToTime_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666787);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnTimeSkip_Client_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666788);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666789);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666790);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666791);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666792);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666793);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666794);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetMinutesToDisplayTime_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666795);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666796);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666797);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Load_Public_Void_TimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666798);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666799);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__TimeLoop_b__105_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666801);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666802);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__StartSleep_b__118_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666803);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666804);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666805);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666806);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetTimeData_Client_1794730778_Private_Void_NetworkConnection_Int32_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666807);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetTimeData_Client_1794730778_Private_Void_NetworkConnection_Int32_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666808);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetTimeData_Client_1794730778_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666809);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Target_SetTimeData_Client_1794730778_Private_Void_NetworkConnection_Int32_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666810);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Target_SetTimeData_Client_1794730778_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666811);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_PassMinute_Client_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666812);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___PassMinute_Client_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666813);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_PassMinute_Client_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666814);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666815);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666816);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666817);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666818);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666819);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666820);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_OnTimeSkip_Client_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666821);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___OnTimeSkip_Client_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666822);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_OnTimeSkip_Client_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666823);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666824);
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x000D0A9C File Offset: 0x000CEC9C
		public unsafe static float MinuteDuration
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99595, RefRangeEnd = 99597, XrefRangeStart = 99591, XrefRangeEnd = 99595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_MinuteDuration_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x000D0ACC File Offset: 0x000CECCC
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x000D0B08 File Offset: 0x000CED08
		public unsafe int DefaultTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DefaultTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_DefaultTime_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x000D0B48 File Offset: 0x000CED48
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x000D0B84 File Offset: 0x000CED84
		public unsafe int CurrentTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_CurrentTime_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x000D0BC4 File Offset: 0x000CEDC4
		public unsafe EDay CurrentDay
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 99597, RefRangeEnd = 99601, XrefRangeStart = 99597, XrefRangeEnd = 99597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x000D0C00 File Offset: 0x000CEE00
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x000D0C3C File Offset: 0x000CEE3C
		public unsafe int ElapsedDays
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_ElapsedDays_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x000D0C7C File Offset: 0x000CEE7C
		public unsafe bool IsEndOfDay
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 99601, RefRangeEnd = 99607, XrefRangeStart = 99601, XrefRangeEnd = 99601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x000D0CB8 File Offset: 0x000CEEB8
		public unsafe bool IsNight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99607, RefRangeEnd = 99609, XrefRangeStart = 99607, XrefRangeEnd = 99607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x000D0CF4 File Offset: 0x000CEEF4
		public unsafe float NormalizedTimeOfDay
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 99617, RefRangeEnd = 99633, XrefRangeStart = 99609, XrefRangeEnd = 99617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_NormalizedTimeOfDay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x000D0D30 File Offset: 0x000CEF30
		public unsafe int DayIndex
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 99597, RefRangeEnd = 99601, XrefRangeStart = 99597, XrefRangeEnd = 99601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x000D0D6C File Offset: 0x000CEF6C
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x000D0DA8 File Offset: 0x000CEFA8
		public unsafe bool IsSleepInProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99633, RefRangeEnd = 99634, XrefRangeStart = 99633, XrefRangeEnd = 99633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsSleepInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_IsSleepInProgress_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x000D0DE8 File Offset: 0x000CEFE8
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x000D0E24 File Offset: 0x000CF024
		public unsafe float Playtime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Playtime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_Playtime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x000D0E64 File Offset: 0x000CF064
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x000D0EA0 File Offset: 0x000CF0A0
		public unsafe bool HostSleepDone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HostSleepDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HostSleepDone_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x000D0EE0 File Offset: 0x000CF0E0
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x000D0F1C File Offset: 0x000CF11C
		public unsafe float TimeSpeedMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeSpeedMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeSpeedMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x000D0F5C File Offset: 0x000CF15C
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x000D0F98 File Offset: 0x000CF198
		public unsafe int DailyMinSum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DailyMinSum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_DailyMinSum_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x000D0FD8 File Offset: 0x000CF1D8
		public unsafe float _minuteStaggerTime
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 99642, RefRangeEnd = 99646, XrefRangeStart = 99634, XrefRangeEnd = 99642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get__minuteStaggerTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x000D1014 File Offset: 0x000CF214
		public unsafe float _tickStaggerTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get__tickStaggerTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x000D1050 File Offset: 0x000CF250
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99646, XrefRangeEnd = 99648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x000D1088 File Offset: 0x000CF288
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99648, XrefRangeEnd = 99650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x000D10C0 File Offset: 0x000CF2C0
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x000D1100 File Offset: 0x000CF300
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x000D113C File Offset: 0x000CF33C
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x000D117C File Offset: 0x000CF37C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99650, XrefRangeEnd = 99651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x000D11C0 File Offset: 0x000CF3C0
		// (set) Token: 0x060019F0 RID: 6640 RVA: 0x000D1200 File Offset: 0x000CF400
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 75688, RefRangeEnd = 75698, XrefRangeStart = 75688, XrefRangeEnd = 75698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99651, XrefRangeEnd = 99652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x000D1244 File Offset: 0x000CF444
		// (set) Token: 0x060019F2 RID: 6642 RVA: 0x000D1280 File Offset: 0x000CF480
		public unsafe virtual bool HasChanged
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99652, RefRangeEnd = 99653, XrefRangeStart = 99652, XrefRangeEnd = 99652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x000D12C0 File Offset: 0x000CF4C0
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x000D12FC File Offset: 0x000CF4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99653, XrefRangeEnd = 99668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x000D1338 File Offset: 0x000CF538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99668, XrefRangeEnd = 99684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x000D1374 File Offset: 0x000CF574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99684, XrefRangeEnd = 99690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000D13B0 File Offset: 0x000CF5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99690, XrefRangeEnd = 99694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000D1400 File Offset: 0x000CF600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99694, XrefRangeEnd = 99701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x000D143C File Offset: 0x000CF63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99701, XrefRangeEnd = 99708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x000D1478 File Offset: 0x000CF678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99708, XrefRangeEnd = 99721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000D14AC File Offset: 0x000CF6AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 99772, RefRangeEnd = 99775, XrefRangeStart = 99721, XrefRangeEnd = 99772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeData_Client(NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverTick;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeData_Client_Private_Void_NetworkConnection_Int32_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x000D1518 File Offset: 0x000CF718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99775, XrefRangeEnd = 99799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x000D1554 File Offset: 0x000CF754
		[CallerCount(0)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000D1590 File Offset: 0x000CF790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99799, XrefRangeEnd = 99804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TickLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000D15D0 File Offset: 0x000CF7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99804, XrefRangeEnd = 99809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TimeLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000D1610 File Offset: 0x000CF810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99809, XrefRangeEnd = 99813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldMinutePass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_ShouldMinutePass_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x000D164C File Offset: 0x000CF84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99813, XrefRangeEnd = 99836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassMinute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_PassMinute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x000D1680 File Offset: 0x000CF880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99836, XrefRangeEnd = 99859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassMinute_Client(int oldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_PassMinute_Client_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x000D16C0 File Offset: 0x000CF8C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99865, RefRangeEnd = 99866, XrefRangeStart = 99859, XrefRangeEnd = 99865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeAndSync(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeAndSync_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x000D1700 File Offset: 0x000CF900
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 99884, RefRangeEnd = 99890, XrefRangeStart = 99866, XrefRangeEnd = 99884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTime_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x000D1740 File Offset: 0x000CF940
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 99893, RefRangeEnd = 99929, XrefRangeStart = 99890, XrefRangeEnd = 99893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentTimeWithinRange(int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x000D1798 File Offset: 0x000CF998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99932, RefRangeEnd = 99933, XrefRangeStart = 99929, XrefRangeEnd = 99932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentDateWithinRange(GameDateTime start, GameDateTime end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x000D17F0 File Offset: 0x000CF9F0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 99933, RefRangeEnd = 99948, XrefRangeStart = 99933, XrefRangeEnd = 99933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime GetDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x000D182C File Offset: 0x000CFA2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99948, RefRangeEnd = 99952, XrefRangeStart = 99948, XrefRangeEnd = 99948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalMinSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000D1868 File Offset: 0x000CFA68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 99955, RefRangeEnd = 99960, XrefRangeStart = 99952, XrefRangeEnd = 99955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeSpeedMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeSpeedMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x000D18A8 File Offset: 0x000CFAA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99981, RefRangeEnd = 99982, XrefRangeStart = 99960, XrefRangeEnd = 99981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCycleDuration(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetCycleDuration_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x000D18E8 File Offset: 0x000CFAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99982, XrefRangeEnd = 100004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_CheckSleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000D191C File Offset: 0x000CFB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100025, RefRangeEnd = 100026, XrefRangeStart = 100004, XrefRangeEnd = 100025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StartSleep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x000D1950 File Offset: 0x000CFB50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100048, RefRangeEnd = 100049, XrefRangeStart = 100026, XrefRangeEnd = 100048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHostSleepDone(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref done;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetHostSleepDone_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x000D1990 File Offset: 0x000CFB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100049, XrefRangeEnd = 100082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipForwardToTime(int newTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SkipForwardToTime_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x000D19D0 File Offset: 0x000CFBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100082, XrefRangeEnd = 100107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimeSkip_Client(int oldTime, int newTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnTimeSkip_Client_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x000D1A1C File Offset: 0x000CFC1C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 100107, RefRangeEnd = 100116, XrefRangeStart = 100107, XrefRangeEnd = 100107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGivenTimeWithinRange(int givenTime, int min, int max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref givenTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x000D1A78 File Offset: 0x000CFC78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100122, RefRangeEnd = 100123, XrefRangeStart = 100116, XrefRangeEnd = 100122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid24HourTime(string input)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x000D1ABC File Offset: 0x000CFCBC
		[CallerCount(0)]
		public unsafe static bool IsValid24HourTime(int time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x000D1AFC File Offset: 0x000CFCFC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 100151, RefRangeEnd = 100167, XrefRangeStart = 100123, XrefRangeEnd = 100151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Get12HourTime(float _time, bool appendDesignator = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendDesignator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x000D1B44 File Offset: 0x000CFD44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100167, RefRangeEnd = 100169, XrefRangeStart = 100167, XrefRangeEnd = 100167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Get24HourTimeFromMinSum(int minSum)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minSum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x000D1B84 File Offset: 0x000CFD84
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 100169, RefRangeEnd = 100189, XrefRangeStart = 100169, XrefRangeEnd = 100169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMinSumFrom24HourTime(int _time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000D1BC4 File Offset: 0x000CFDC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100196, RefRangeEnd = 100197, XrefRangeStart = 100189, XrefRangeEnd = 100196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMinutesToDisplayTime(int minutes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minutes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetMinutesToDisplayTime_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x000D1BFC File Offset: 0x000CFDFC
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 100202, RefRangeEnd = 100231, XrefRangeStart = 100197, XrefRangeEnd = 100202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddMinutesTo24HourTime(int time, int minsToAdd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsToAdd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x000D1C48 File Offset: 0x000CFE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100231, XrefRangeEnd = 100237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x000D1C8C File Offset: 0x000CFE8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100238, RefRangeEnd = 100239, XrefRangeStart = 100237, XrefRangeEnd = 100238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(TimeData timeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(timeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Load_Public_Void_TimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000D1CD0 File Offset: 0x000CFED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100239, XrefRangeEnd = 100272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x000D1D0C File Offset: 0x000CFF0C
		[CallerCount(0)]
		public unsafe bool _TimeLoop_b__105_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__TimeLoop_b__105_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x000D1D48 File Offset: 0x000CFF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100272, XrefRangeEnd = 100277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000D1D88 File Offset: 0x000CFF88
		[CallerCount(0)]
		public unsafe bool _StartSleep_b__118_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__StartSleep_b__118_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000D1DC4 File Offset: 0x000CFFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100277, XrefRangeEnd = 100338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000D1E00 File Offset: 0x000D0000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100338, XrefRangeEnd = 100341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x000D1E3C File Offset: 0x000D003C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x000D1E78 File Offset: 0x000D0078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100341, XrefRangeEnd = 100357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTimeData_Client_1794730778(NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverTick;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetTimeData_Client_1794730778_Private_Void_NetworkConnection_Int32_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000D1EE4 File Offset: 0x000D00E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100396, RefRangeEnd = 100399, XrefRangeStart = 100357, XrefRangeEnd = 100396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTimeData_Client_1794730778(NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverTick;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetTimeData_Client_1794730778_Private_Void_NetworkConnection_Int32_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000D1F50 File Offset: 0x000D0150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100399, XrefRangeEnd = 100407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTimeData_Client_1794730778(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetTimeData_Client_1794730778_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000D1FA0 File Offset: 0x000D01A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100407, XrefRangeEnd = 100423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetTimeData_Client_1794730778(NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverTick;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Target_SetTimeData_Client_1794730778_Private_Void_NetworkConnection_Int32_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000D200C File Offset: 0x000D020C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100423, XrefRangeEnd = 100431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetTimeData_Client_1794730778(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Target_SetTimeData_Client_1794730778_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x000D205C File Offset: 0x000D025C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100431, XrefRangeEnd = 100442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PassMinute_Client_3316948804(int oldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_PassMinute_Client_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000D209C File Offset: 0x000D029C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100455, RefRangeEnd = 100459, XrefRangeStart = 100442, XrefRangeEnd = 100455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PassMinute_Client_3316948804(int oldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___PassMinute_Client_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x000D20DC File Offset: 0x000D02DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100459, XrefRangeEnd = 100464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PassMinute_Client_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_PassMinute_Client_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000D212C File Offset: 0x000D032C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100464, XrefRangeEnd = 100473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000D2160 File Offset: 0x000D0360
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100507, RefRangeEnd = 100511, XrefRangeStart = 100473, XrefRangeEnd = 100507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x000D2194 File Offset: 0x000D0394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100511, XrefRangeEnd = 100514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x000D21E4 File Offset: 0x000D03E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100514, XrefRangeEnd = 100524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetHostSleepDone_1140765316(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref done;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x000D2224 File Offset: 0x000D0424
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100535, RefRangeEnd = 100538, XrefRangeStart = 100524, XrefRangeEnd = 100535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHostSleepDone_1140765316(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref done;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000D2264 File Offset: 0x000D0464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100538, XrefRangeEnd = 100541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetHostSleepDone_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x000D22B4 File Offset: 0x000D04B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100541, XrefRangeEnd = 100554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_OnTimeSkip_Client_1692629761(int oldTime, int newTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_OnTimeSkip_Client_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x000D2300 File Offset: 0x000D0500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100583, RefRangeEnd = 100586, XrefRangeStart = 100554, XrefRangeEnd = 100583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___OnTimeSkip_Client_1692629761(int oldTime, int newTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___OnTimeSkip_Client_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x000D234C File Offset: 0x000D054C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100586, XrefRangeEnd = 100593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_OnTimeSkip_Client_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_OnTimeSkip_Client_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x000D239C File Offset: 0x000D059C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100593, XrefRangeEnd = 100608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0000E2C7 File Offset: 0x0000C4C7
		public TimeManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x000D23D8 File Offset: 0x000D05D8
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x0000E2D0 File Offset: 0x0000C4D0
		public unsafe static float DefaultCycleDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultCycleDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultCycleDuration, (void*)(&value));
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x000D23F4 File Offset: 0x000D05F4
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x0000E2DE File Offset: 0x0000C4DE
		public unsafe static float TickDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TickDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TickDuration, (void*)(&value));
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x000D2410 File Offset: 0x000D0610
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x0000E2EC File Offset: 0x0000C4EC
		public unsafe static int EndOfDay
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_EndOfDay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_EndOfDay, (void*)(&value));
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x000D242C File Offset: 0x000D062C
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x0000E2FA File Offset: 0x0000C4FA
		public unsafe static int WakeTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_WakeTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_WakeTime, (void*)(&value));
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x000D2448 File Offset: 0x000D0648
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x0000E308 File Offset: 0x0000C508
		public unsafe static float CycleDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CycleDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CycleDuration, (void*)(&value));
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x000D2464 File Offset: 0x000D0664
		// (set) Token: 0x06001A3F RID: 6719 RVA: 0x0000E316 File Offset: 0x0000C516
		public unsafe int _DefaultTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DefaultTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DefaultTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x000D248C File Offset: 0x000D068C
		// (set) Token: 0x06001A41 RID: 6721 RVA: 0x0000E331 File Offset: 0x0000C531
		public unsafe EDay _defaultDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__defaultDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__defaultDay)) = value;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x000D24B4 File Offset: 0x000D06B4
		// (set) Token: 0x06001A43 RID: 6723 RVA: 0x0000E34C File Offset: 0x0000C54C
		public unsafe int _CurrentTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x000D24DC File Offset: 0x000D06DC
		// (set) Token: 0x06001A45 RID: 6725 RVA: 0x0000E367 File Offset: 0x0000C567
		public unsafe int _ElapsedDays_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField)) = value;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x000D2504 File Offset: 0x000D0704
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x0000E382 File Offset: 0x0000C582
		public unsafe bool _IsSleepInProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__IsSleepInProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__IsSleepInProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x000D252C File Offset: 0x000D072C
		// (set) Token: 0x06001A49 RID: 6729 RVA: 0x0000E39D File Offset: 0x0000C59D
		public unsafe float _Playtime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x000D2554 File Offset: 0x000D0754
		// (set) Token: 0x06001A4B RID: 6731 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		public unsafe bool _HostSleepDone_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostSleepDone_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostSleepDone_k__BackingField)) = value;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x000D257C File Offset: 0x000D077C
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x0000E3D3 File Offset: 0x0000C5D3
		public unsafe float _TimeSpeedMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeSpeedMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeSpeedMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x000D25A4 File Offset: 0x000D07A4
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0000E3EE File Offset: 0x0000C5EE
		public unsafe int _DailyMinSum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinSum_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinSum_k__BackingField)) = value;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x000D25CC File Offset: 0x000D07CC
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x0000E409 File Offset: 0x0000C609
		public unsafe float _lastMinWaitExcess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__lastMinWaitExcess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__lastMinWaitExcess)) = value;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x000D25F4 File Offset: 0x000D07F4
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0000E424 File Offset: 0x0000C624
		public unsafe bool _stopMinPassWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__stopMinPassWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__stopMinPassWait)) = value;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x000D261C File Offset: 0x000D081C
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x0000E43F File Offset: 0x0000C63F
		public unsafe float _secondsOnCurrentMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__secondsOnCurrentMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__secondsOnCurrentMinute)) = value;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x000D2644 File Offset: 0x000D0844
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0000E45A File Offset: 0x0000C65A
		public unsafe ActionList onMinutePass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x000D2674 File Offset: 0x000D0874
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x0000E479 File Offset: 0x0000C679
		public unsafe ActionList onUncappedMinutePass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUncappedMinutePass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUncappedMinutePass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x000D26A4 File Offset: 0x000D08A4
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x0000E498 File Offset: 0x0000C698
		public unsafe ActionList onTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x000D26D4 File Offset: 0x000D08D4
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0000E4B7 File Offset: 0x0000C6B7
		public unsafe Action onTimeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x000D2704 File Offset: 0x000D0904
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0000E4D6 File Offset: 0x0000C6D6
		public unsafe Action<int> onTimeSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x000D2734 File Offset: 0x000D0934
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0000E4F5 File Offset: 0x0000C6F5
		public unsafe Action onTimeSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x000D2764 File Offset: 0x000D0964
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0000E514 File Offset: 0x0000C714
		public unsafe Action onHourPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x000D2794 File Offset: 0x000D0994
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0000E533 File Offset: 0x0000C733
		public unsafe Action onDayPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x000D27C4 File Offset: 0x000D09C4
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0000E552 File Offset: 0x0000C752
		public unsafe Action onWeekPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x000D27F4 File Offset: 0x000D09F4
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0000E571 File Offset: 0x0000C771
		public unsafe Action onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x000D2824 File Offset: 0x000D0A24
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0000E590 File Offset: 0x0000C790
		public unsafe Action onFixedUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x000D2854 File Offset: 0x000D0A54
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0000E5AF File Offset: 0x0000C7AF
		public unsafe Action onSleepStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x000D2884 File Offset: 0x000D0A84
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x0000E5CE File Offset: 0x0000C7CE
		public unsafe Action onSleepEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x000D28B4 File Offset: 0x000D0AB4
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0000E5ED File Offset: 0x0000C7ED
		public unsafe TimeLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x000D28E4 File Offset: 0x000D0AE4
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0000E60C File Offset: 0x0000C80C
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x000D2914 File Offset: 0x000D0B14
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x0000E62B File Offset: 0x0000C82B
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x000D2944 File Offset: 0x000D0B44
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x0000E64A File Offset: 0x0000C84A
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x000D296C File Offset: 0x000D0B6C
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0000E665 File Offset: 0x0000C865
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x000D2994 File Offset: 0x000D0B94
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0000E680 File Offset: 0x0000C880
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x000D29BC File Offset: 0x000D0BBC
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0000E69B File Offset: 0x0000C89B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCycleDuration;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeFieldInfoPtr_TickDuration;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeFieldInfoPtr_EndOfDay;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeFieldInfoPtr_WakeTime;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeFieldInfoPtr_CycleDuration;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeFieldInfoPtr__DefaultTime_k__BackingField;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeFieldInfoPtr__defaultDay;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTime_k__BackingField;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeFieldInfoPtr__ElapsedDays_k__BackingField;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeFieldInfoPtr__IsSleepInProgress_k__BackingField;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeFieldInfoPtr__Playtime_k__BackingField;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeFieldInfoPtr__HostSleepDone_k__BackingField;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeFieldInfoPtr__TimeSpeedMultiplier_k__BackingField;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeFieldInfoPtr__DailyMinSum_k__BackingField;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeFieldInfoPtr__lastMinWaitExcess;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeFieldInfoPtr__stopMinPassWait;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeFieldInfoPtr__secondsOnCurrentMinute;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeFieldInfoPtr_onMinutePass;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeFieldInfoPtr_onUncappedMinutePass;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeFieldInfoPtr_onTick;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeFieldInfoPtr_onTimeChanged;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeFieldInfoPtr_onTimeSkip;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeFieldInfoPtr_onTimeSet;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeFieldInfoPtr_onHourPass;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeFieldInfoPtr_onDayPass;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeFieldInfoPtr_onWeekPass;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeFieldInfoPtr_onFixedUpdate;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeFieldInfoPtr_onSleepStart;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeFieldInfoPtr_onSleepEnd;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_get_MinuteDuration_Public_Static_get_Single_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultTime_Public_get_Int32_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultTime_Private_set_Void_Int32_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTime_Private_set_Void_Int32_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_set_ElapsedDays_Private_set_Void_Int32_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedTimeOfDay_Public_get_Single_0;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSleepInProgress_Public_get_Boolean_0;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSleepInProgress_Private_set_Void_Boolean_0;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr_get_Playtime_Public_get_Single_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_set_Playtime_Private_set_Void_Single_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_get_HostSleepDone_Public_get_Boolean_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr_set_HostSleepDone_Private_set_Void_Boolean_0;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSpeedMultiplier_Public_get_Single_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSpeedMultiplier_Private_set_Void_Single_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_get_DailyMinSum_Public_get_Int32_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_set_DailyMinSum_Private_set_Void_Int32_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_get__minuteStaggerTime_Private_get_Single_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_get__tickStaggerTime_Private_get_Single_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeData_Client_Private_Void_NetworkConnection_Int32_Int32_UInt32_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_ShouldMinutePass_Private_Boolean_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_PassMinute_Private_Void_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_PassMinute_Client_Private_Void_Int32_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeAndSync_Public_Void_Int32_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Private_Void_Int32_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeSpeedMultiplier_Public_Void_Single_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_SetCycleDuration_Public_Void_Single_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_CheckSleepStart_Private_Void_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_StartSleep_Public_Void_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_SetHostSleepDone_Public_Void_Boolean_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_SkipForwardToTime_Private_Void_Int32_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSkip_Client_Private_Void_Int32_Int32_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_Int32_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_GetMinutesToDisplayTime_Public_Static_String_Int32_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_TimeData_0;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr__TimeLoop_b__105_1_Private_Boolean_0;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr__StartSleep_b__118_1_Private_Boolean_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTimeData_Client_1794730778_Private_Void_NetworkConnection_Int32_Int32_UInt32_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTimeData_Client_1794730778_Private_Void_NetworkConnection_Int32_Int32_UInt32_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTimeData_Client_1794730778_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetTimeData_Client_1794730778_Private_Void_NetworkConnection_Int32_Int32_UInt32_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetTimeData_Client_1794730778_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PassMinute_Client_3316948804_Private_Void_Int32_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PassMinute_Client_3316948804_Private_Void_Int32_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PassMinute_Client_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Public_Void_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Public_Void_Boolean_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_OnTimeSkip_Client_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___OnTimeSkip_Client_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_OnTimeSkip_Client_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000941 RID: 2369
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<<StartSleep>g__WaitForSleepEnd|118_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique : Object
		{
			// Token: 0x0600D837 RID: 55351 RVA: 0x0035BE10 File Offset: 0x0035A010
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<<StartSleep>g__WaitForSleepEnd|118_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr, 100666825);
				Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr, 100666826);
				Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr, 100666827);
				Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr, 100666828);
				Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr, 100666829);
				Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr, 100666830);
			}

			// Token: 0x0600D838 RID: 55352 RVA: 0x0035BEF0 File Offset: 0x0035A0F0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D839 RID: 55353 RVA: 0x0035BF38 File Offset: 0x0035A138
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D83A RID: 55354 RVA: 0x0035BF6C File Offset: 0x0035A16C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99429, XrefRangeEnd = 99444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700420B RID: 16907
			// (get) Token: 0x0600D83B RID: 55355 RVA: 0x0035BFA8 File Offset: 0x0035A1A8
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D83C RID: 55356 RVA: 0x0035BFE8 File Offset: 0x0035A1E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99444, XrefRangeEnd = 99449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700420C RID: 16908
			// (get) Token: 0x0600D83D RID: 55357 RVA: 0x0035C01C File Offset: 0x0035A21C
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D83E RID: 55358 RVA: 0x00065AA0 File Offset: 0x00063CA0
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004208 RID: 16904
			// (get) Token: 0x0600D83F RID: 55359 RVA: 0x0035C05C File Offset: 0x0035A25C
			// (set) Token: 0x0600D840 RID: 55360 RVA: 0x00065AA9 File Offset: 0x00063CA9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004209 RID: 16905
			// (get) Token: 0x0600D841 RID: 55361 RVA: 0x0035C084 File Offset: 0x0035A284
			// (set) Token: 0x0600D842 RID: 55362 RVA: 0x00065AC4 File Offset: 0x00063CC4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420A RID: 16906
			// (get) Token: 0x0600D843 RID: 55363 RVA: 0x0035C0B4 File Offset: 0x0035A2B4
			// (set) Token: 0x0600D844 RID: 55364 RVA: 0x00065AE3 File Offset: 0x00063CE3
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400937A RID: 37754
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400937B RID: 37755
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400937C RID: 37756
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400937D RID: 37757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400937E RID: 37758
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400937F RID: 37759
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009380 RID: 37760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009381 RID: 37761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009382 RID: 37762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000942 RID: 2370
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D845 RID: 55365 RVA: 0x0035C0E4 File Offset: 0x0035A2E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__104_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9__104_0");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__105_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9__105_0");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__105_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9__105_2");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100666832);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TickLoop_b__104_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100666833);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TimeLoop_b__105_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100666834);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TimeLoop_b__105_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100666835);
			}

			// Token: 0x0600D846 RID: 55366 RVA: 0x0035C1B0 File Offset: 0x0035A3B0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D847 RID: 55367 RVA: 0x0035C1EC File Offset: 0x0035A3EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99449, XrefRangeEnd = 99450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TickLoop_b__104_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TickLoop_b__104_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D848 RID: 55368 RVA: 0x0035C228 File Offset: 0x0035A428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99450, XrefRangeEnd = 99454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TimeLoop_b__105_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TimeLoop_b__105_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D849 RID: 55369 RVA: 0x0035C264 File Offset: 0x0035A464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TimeLoop_b__105_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TimeLoop_b__105_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D84A RID: 55370 RVA: 0x00065B02 File Offset: 0x00063D02
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700420D RID: 16909
			// (get) Token: 0x0600D84B RID: 55371 RVA: 0x0035C2A0 File Offset: 0x0035A4A0
			// (set) Token: 0x0600D84C RID: 55372 RVA: 0x00065B0B File Offset: 0x00063D0B
			public unsafe static TimeManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420E RID: 16910
			// (get) Token: 0x0600D84D RID: 55373 RVA: 0x0035C2C8 File Offset: 0x0035A4C8
			// (set) Token: 0x0600D84E RID: 55374 RVA: 0x00065B1D File Offset: 0x00063D1D
			public unsafe static Func<bool> __9__104_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__104_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__104_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420F RID: 16911
			// (get) Token: 0x0600D84F RID: 55375 RVA: 0x0035C2F0 File Offset: 0x0035A4F0
			// (set) Token: 0x0600D850 RID: 55376 RVA: 0x00065B2F File Offset: 0x00063D2F
			public unsafe static Func<bool> __9__105_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__105_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__105_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004210 RID: 16912
			// (get) Token: 0x0600D851 RID: 55377 RVA: 0x0035C318 File Offset: 0x0035A518
			// (set) Token: 0x0600D852 RID: 55378 RVA: 0x00065B41 File Offset: 0x00063D41
			public unsafe static Func<bool> __9__105_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__105_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__105_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009383 RID: 37763
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009384 RID: 37764
			private static readonly IntPtr NativeFieldInfoPtr___9__104_0;

			// Token: 0x04009385 RID: 37765
			private static readonly IntPtr NativeFieldInfoPtr___9__105_0;

			// Token: 0x04009386 RID: 37766
			private static readonly IntPtr NativeFieldInfoPtr___9__105_2;

			// Token: 0x04009387 RID: 37767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009388 RID: 37768
			private static readonly IntPtr NativeMethodInfoPtr__TickLoop_b__104_0_Internal_Boolean_0;

			// Token: 0x04009389 RID: 37769
			private static readonly IntPtr NativeMethodInfoPtr__TimeLoop_b__105_0_Internal_Boolean_0;

			// Token: 0x0400938A RID: 37770
			private static readonly IntPtr NativeMethodInfoPtr__TimeLoop_b__105_2_Internal_Boolean_0;
		}

		// Token: 0x02000943 RID: 2371
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<TickLoop>d__104")]
		public sealed class _TickLoop_d__104 : Object
		{
			// Token: 0x0600D853 RID: 55379 RVA: 0x0035C340 File Offset: 0x0035A540
			// Note: this type is marked as 'beforefieldinit'.
			static _TickLoop_d__104()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TickLoop>d__104");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr__lastWaitExcess_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, "<lastWaitExcess>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr__timeToWait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, "<timeToWait>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr__timeOnWaitStart_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, "<timeOnWaitStart>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, 100666836);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, 100666837);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, 100666838);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, 100666839);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, 100666840);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr, 100666841);
			}

			// Token: 0x0600D854 RID: 55380 RVA: 0x0035C45C File Offset: 0x0035A65C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TickLoop_d__104(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D855 RID: 55381 RVA: 0x0035C4A4 File Offset: 0x0035A6A4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D856 RID: 55382 RVA: 0x0035C4D8 File Offset: 0x0035A6D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99454, XrefRangeEnd = 99469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004217 RID: 16919
			// (get) Token: 0x0600D857 RID: 55383 RVA: 0x0035C514 File Offset: 0x0035A714
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D858 RID: 55384 RVA: 0x0035C554 File Offset: 0x0035A754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99469, XrefRangeEnd = 99474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004218 RID: 16920
			// (get) Token: 0x0600D859 RID: 55385 RVA: 0x0035C588 File Offset: 0x0035A788
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D85A RID: 55386 RVA: 0x00065B53 File Offset: 0x00063D53
			public _TickLoop_d__104(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004211 RID: 16913
			// (get) Token: 0x0600D85B RID: 55387 RVA: 0x0035C5C8 File Offset: 0x0035A7C8
			// (set) Token: 0x0600D85C RID: 55388 RVA: 0x00065B5C File Offset: 0x00063D5C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004212 RID: 16914
			// (get) Token: 0x0600D85D RID: 55389 RVA: 0x0035C5F0 File Offset: 0x0035A7F0
			// (set) Token: 0x0600D85E RID: 55390 RVA: 0x00065B77 File Offset: 0x00063D77
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004213 RID: 16915
			// (get) Token: 0x0600D85F RID: 55391 RVA: 0x0035C620 File Offset: 0x0035A820
			// (set) Token: 0x0600D860 RID: 55392 RVA: 0x00065B96 File Offset: 0x00063D96
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004214 RID: 16916
			// (get) Token: 0x0600D861 RID: 55393 RVA: 0x0035C650 File Offset: 0x0035A850
			// (set) Token: 0x0600D862 RID: 55394 RVA: 0x00065BB5 File Offset: 0x00063DB5
			public unsafe float _lastWaitExcess_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr__lastWaitExcess_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr__lastWaitExcess_5__2)) = value;
				}
			}

			// Token: 0x17004215 RID: 16917
			// (get) Token: 0x0600D863 RID: 55395 RVA: 0x0035C678 File Offset: 0x0035A878
			// (set) Token: 0x0600D864 RID: 55396 RVA: 0x00065BD0 File Offset: 0x00063DD0
			public unsafe float _timeToWait_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr__timeToWait_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr__timeToWait_5__3)) = value;
				}
			}

			// Token: 0x17004216 RID: 16918
			// (get) Token: 0x0600D865 RID: 55397 RVA: 0x0035C6A0 File Offset: 0x0035A8A0
			// (set) Token: 0x0600D866 RID: 55398 RVA: 0x00065BEB File Offset: 0x00063DEB
			public unsafe float _timeOnWaitStart_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr__timeOnWaitStart_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__104.NativeFieldInfoPtr__timeOnWaitStart_5__4)) = value;
				}
			}

			// Token: 0x0400938B RID: 37771
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400938C RID: 37772
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400938D RID: 37773
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400938E RID: 37774
			private static readonly IntPtr NativeFieldInfoPtr__lastWaitExcess_5__2;

			// Token: 0x0400938F RID: 37775
			private static readonly IntPtr NativeFieldInfoPtr__timeToWait_5__3;

			// Token: 0x04009390 RID: 37776
			private static readonly IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__4;

			// Token: 0x04009391 RID: 37777
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009392 RID: 37778
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009393 RID: 37779
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009394 RID: 37780
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009395 RID: 37781
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009396 RID: 37782
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000944 RID: 2372
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<TimeLoop>d__105")]
		public sealed class _TimeLoop_d__105 : Object
		{
			// Token: 0x0600D867 RID: 55399 RVA: 0x0035C6C8 File Offset: 0x0035A8C8
			// Note: this type is marked as 'beforefieldinit'.
			static _TimeLoop_d__105()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeLoop>d__105");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr__timeToWait_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, "<timeToWait>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr__timeOnWaitStart_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, "<timeOnWaitStart>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, "<i>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, 100666842);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, 100666843);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, 100666844);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, 100666845);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, 100666846);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr, 100666847);
			}

			// Token: 0x0600D868 RID: 55400 RVA: 0x0035C7E4 File Offset: 0x0035A9E4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TimeLoop_d__105(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D869 RID: 55401 RVA: 0x0035C82C File Offset: 0x0035AA2C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D86A RID: 55402 RVA: 0x0035C860 File Offset: 0x0035AA60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99474, XrefRangeEnd = 99586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700421F RID: 16927
			// (get) Token: 0x0600D86B RID: 55403 RVA: 0x0035C89C File Offset: 0x0035AA9C
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D86C RID: 55404 RVA: 0x0035C8DC File Offset: 0x0035AADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99586, XrefRangeEnd = 99591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004220 RID: 16928
			// (get) Token: 0x0600D86D RID: 55405 RVA: 0x0035C910 File Offset: 0x0035AB10
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D86E RID: 55406 RVA: 0x00065C06 File Offset: 0x00063E06
			public _TimeLoop_d__105(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004219 RID: 16921
			// (get) Token: 0x0600D86F RID: 55407 RVA: 0x0035C950 File Offset: 0x0035AB50
			// (set) Token: 0x0600D870 RID: 55408 RVA: 0x00065C0F File Offset: 0x00063E0F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700421A RID: 16922
			// (get) Token: 0x0600D871 RID: 55409 RVA: 0x0035C978 File Offset: 0x0035AB78
			// (set) Token: 0x0600D872 RID: 55410 RVA: 0x00065C2A File Offset: 0x00063E2A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421B RID: 16923
			// (get) Token: 0x0600D873 RID: 55411 RVA: 0x0035C9A8 File Offset: 0x0035ABA8
			// (set) Token: 0x0600D874 RID: 55412 RVA: 0x00065C49 File Offset: 0x00063E49
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421C RID: 16924
			// (get) Token: 0x0600D875 RID: 55413 RVA: 0x0035C9D8 File Offset: 0x0035ABD8
			// (set) Token: 0x0600D876 RID: 55414 RVA: 0x00065C68 File Offset: 0x00063E68
			public unsafe float _timeToWait_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr__timeToWait_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr__timeToWait_5__2)) = value;
				}
			}

			// Token: 0x1700421D RID: 16925
			// (get) Token: 0x0600D877 RID: 55415 RVA: 0x0035CA00 File Offset: 0x0035AC00
			// (set) Token: 0x0600D878 RID: 55416 RVA: 0x00065C83 File Offset: 0x00063E83
			public unsafe float _timeOnWaitStart_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr__timeOnWaitStart_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr__timeOnWaitStart_5__3)) = value;
				}
			}

			// Token: 0x1700421E RID: 16926
			// (get) Token: 0x0600D879 RID: 55417 RVA: 0x0035CA28 File Offset: 0x0035AC28
			// (set) Token: 0x0600D87A RID: 55418 RVA: 0x00065C9E File Offset: 0x00063E9E
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__105.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04009397 RID: 37783
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009398 RID: 37784
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009399 RID: 37785
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400939A RID: 37786
			private static readonly IntPtr NativeFieldInfoPtr__timeToWait_5__2;

			// Token: 0x0400939B RID: 37787
			private static readonly IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__3;

			// Token: 0x0400939C RID: 37788
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400939D RID: 37789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400939E RID: 37790
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400939F RID: 37791
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040093A0 RID: 37792
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040093A1 RID: 37793
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093A2 RID: 37794
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

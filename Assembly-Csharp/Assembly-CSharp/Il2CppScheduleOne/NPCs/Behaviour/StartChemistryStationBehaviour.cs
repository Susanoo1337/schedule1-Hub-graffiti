using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000670 RID: 1648
	public class StartChemistryStationBehaviour : Behaviour
	{
		// Token: 0x06009E77 RID: 40567 RVA: 0x002A4DC8 File Offset: 0x002A2FC8
		// Note: this type is marked as 'beforefieldinit'.
		static StartChemistryStationBehaviour()
		{
			Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "StartChemistryStationBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr);
			StartChemistryStationBehaviour.NativeFieldInfoPtr_PLACE_INGREDIENTS_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "PLACE_INGREDIENTS_TIME");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_STIR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "STIR_TIME");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_BURNER_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "BURNER_TIME");
			StartChemistryStationBehaviour.NativeFieldInfoPtr__targetStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "<targetStation>k__BackingField");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_chemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "chemist");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_cookRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "cookRoutine");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_beaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "beaker");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted");
			StartChemistryStationBehaviour.NativeMethodInfoPtr_get_targetStation_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684153);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_set_targetStation_Private_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684154);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684155);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_SetTargetStation_Public_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684156);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684157);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684158);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684159);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_StartCook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684160);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_SetupBeaker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684161);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_FillBeaker_Private_Void_StationRecipe_Beaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684162);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_CanCookStart_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684163);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_StopCook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684164);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684165);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_IsAtStation_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684166);
			StartChemistryStationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684167);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684168);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684169);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684170);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684171);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartCook_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684172);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcLogic___StartCook_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684173);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartCook_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684174);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100684175);
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x06009E78 RID: 40568 RVA: 0x002A5078 File Offset: 0x002A3278
		// (set) Token: 0x06009E79 RID: 40569 RVA: 0x002A50B8 File Offset: 0x002A32B8
		public unsafe ChemistryStation targetStation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_get_targetStation_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_set_targetStation_Private_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009E7A RID: 40570 RVA: 0x002A50FC File Offset: 0x002A32FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280788, XrefRangeEnd = 280795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E7B RID: 40571 RVA: 0x002A5138 File Offset: 0x002A3338
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetStation(ChemistryStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_SetTargetStation_Public_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E7C RID: 40572 RVA: 0x002A517C File Offset: 0x002A337C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280795, XrefRangeEnd = 280809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E7D RID: 40573 RVA: 0x002A51B8 File Offset: 0x002A33B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280809, XrefRangeEnd = 280846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E7E RID: 40574 RVA: 0x002A51F4 File Offset: 0x002A33F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280846, XrefRangeEnd = 280850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E7F RID: 40575 RVA: 0x002A5230 File Offset: 0x002A3430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280850, XrefRangeEnd = 280871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_StartCook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E80 RID: 40576 RVA: 0x002A5264 File Offset: 0x002A3464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280871, XrefRangeEnd = 280886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupBeaker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_SetupBeaker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E81 RID: 40577 RVA: 0x002A5298 File Offset: 0x002A3498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280938, RefRangeEnd = 280939, XrefRangeStart = 280886, XrefRangeEnd = 280938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillBeaker(StationRecipe recipe, Beaker beaker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beaker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_FillBeaker_Private_Void_StationRecipe_Beaker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E82 RID: 40578 RVA: 0x002A52EC File Offset: 0x002A34EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280959, RefRangeEnd = 280960, XrefRangeStart = 280939, XrefRangeEnd = 280959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCookStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_CanCookStart_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009E83 RID: 40579 RVA: 0x002A5328 File Offset: 0x002A3528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280967, RefRangeEnd = 280969, XrefRangeStart = 280960, XrefRangeEnd = 280967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_StopCook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E84 RID: 40580 RVA: 0x002A535C File Offset: 0x002A355C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280977, RefRangeEnd = 280979, XrefRangeStart = 280969, XrefRangeEnd = 280977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetStationAccessPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009E85 RID: 40581 RVA: 0x002A5398 File Offset: 0x002A3598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280979, XrefRangeEnd = 280992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_IsAtStation_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x002A53D4 File Offset: 0x002A35D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276250, XrefRangeEnd = 276252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartChemistryStationBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x002A5410 File Offset: 0x002A3610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280992, XrefRangeEnd = 280997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x002A5450 File Offset: 0x002A3650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280997, XrefRangeEnd = 281005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E89 RID: 40585 RVA: 0x002A548C File Offset: 0x002A368C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x002A54C8 File Offset: 0x002A36C8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E8B RID: 40587 RVA: 0x002A5504 File Offset: 0x002A3704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281005, XrefRangeEnd = 281014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartCook_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartCook_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x002A5538 File Offset: 0x002A3738
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281025, RefRangeEnd = 281028, XrefRangeStart = 281014, XrefRangeEnd = 281025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartCook_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcLogic___StartCook_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E8D RID: 40589 RVA: 0x002A556C File Offset: 0x002A376C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281028, XrefRangeEnd = 281031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartCook_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E8E RID: 40590 RVA: 0x002A55BC File Offset: 0x002A37BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281031, XrefRangeEnd = 281038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E8F RID: 40591 RVA: 0x0004923D File Offset: 0x0004743D
		public StartChemistryStationBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x06009E90 RID: 40592 RVA: 0x002A55F8 File Offset: 0x002A37F8
		// (set) Token: 0x06009E91 RID: 40593 RVA: 0x00049246 File Offset: 0x00047446
		public unsafe static float PLACE_INGREDIENTS_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_PLACE_INGREDIENTS_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_PLACE_INGREDIENTS_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x06009E92 RID: 40594 RVA: 0x002A5614 File Offset: 0x002A3814
		// (set) Token: 0x06009E93 RID: 40595 RVA: 0x00049254 File Offset: 0x00047454
		public unsafe static float STIR_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_STIR_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_STIR_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x06009E94 RID: 40596 RVA: 0x002A5630 File Offset: 0x002A3830
		// (set) Token: 0x06009E95 RID: 40597 RVA: 0x00049262 File Offset: 0x00047462
		public unsafe static float BURNER_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_BURNER_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_BURNER_TIME, (void*)(&value));
			}
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x06009E96 RID: 40598 RVA: 0x002A564C File Offset: 0x002A384C
		// (set) Token: 0x06009E97 RID: 40599 RVA: 0x00049270 File Offset: 0x00047470
		public unsafe ChemistryStation _targetStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr__targetStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr__targetStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x06009E98 RID: 40600 RVA: 0x002A567C File Offset: 0x002A387C
		// (set) Token: 0x06009E99 RID: 40601 RVA: 0x0004928F File Offset: 0x0004748F
		public unsafe Chemist chemist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_chemist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_chemist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x06009E9A RID: 40602 RVA: 0x002A56AC File Offset: 0x002A38AC
		// (set) Token: 0x06009E9B RID: 40603 RVA: 0x000492AE File Offset: 0x000474AE
		public unsafe Coroutine cookRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_cookRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_cookRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x06009E9C RID: 40604 RVA: 0x002A56DC File Offset: 0x002A38DC
		// (set) Token: 0x06009E9D RID: 40605 RVA: 0x000492CD File Offset: 0x000474CD
		public unsafe Beaker beaker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_beaker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_beaker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x06009E9E RID: 40606 RVA: 0x002A570C File Offset: 0x002A390C
		// (set) Token: 0x06009E9F RID: 40607 RVA: 0x000492EC File Offset: 0x000474EC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x06009EA0 RID: 40608 RVA: 0x002A5734 File Offset: 0x002A3934
		// (set) Token: 0x06009EA1 RID: 40609 RVA: 0x00049307 File Offset: 0x00047507
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006D3B RID: 27963
		private static readonly IntPtr NativeFieldInfoPtr_PLACE_INGREDIENTS_TIME;

		// Token: 0x04006D3C RID: 27964
		private static readonly IntPtr NativeFieldInfoPtr_STIR_TIME;

		// Token: 0x04006D3D RID: 27965
		private static readonly IntPtr NativeFieldInfoPtr_BURNER_TIME;

		// Token: 0x04006D3E RID: 27966
		private static readonly IntPtr NativeFieldInfoPtr__targetStation_k__BackingField;

		// Token: 0x04006D3F RID: 27967
		private static readonly IntPtr NativeFieldInfoPtr_chemist;

		// Token: 0x04006D40 RID: 27968
		private static readonly IntPtr NativeFieldInfoPtr_cookRoutine;

		// Token: 0x04006D41 RID: 27969
		private static readonly IntPtr NativeFieldInfoPtr_beaker;

		// Token: 0x04006D42 RID: 27970
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006D43 RID: 27971
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006D44 RID: 27972
		private static readonly IntPtr NativeMethodInfoPtr_get_targetStation_Public_get_ChemistryStation_0;

		// Token: 0x04006D45 RID: 27973
		private static readonly IntPtr NativeMethodInfoPtr_set_targetStation_Private_set_Void_ChemistryStation_0;

		// Token: 0x04006D46 RID: 27974
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006D47 RID: 27975
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetStation_Public_Void_ChemistryStation_0;

		// Token: 0x04006D48 RID: 27976
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006D49 RID: 27977
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x04006D4A RID: 27978
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04006D4B RID: 27979
		private static readonly IntPtr NativeMethodInfoPtr_StartCook_Private_Void_0;

		// Token: 0x04006D4C RID: 27980
		private static readonly IntPtr NativeMethodInfoPtr_SetupBeaker_Private_Void_0;

		// Token: 0x04006D4D RID: 27981
		private static readonly IntPtr NativeMethodInfoPtr_FillBeaker_Private_Void_StationRecipe_Beaker_0;

		// Token: 0x04006D4E RID: 27982
		private static readonly IntPtr NativeMethodInfoPtr_CanCookStart_Private_Boolean_0;

		// Token: 0x04006D4F RID: 27983
		private static readonly IntPtr NativeMethodInfoPtr_StopCook_Private_Void_0;

		// Token: 0x04006D50 RID: 27984
		private static readonly IntPtr NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0;

		// Token: 0x04006D51 RID: 27985
		private static readonly IntPtr NativeMethodInfoPtr_IsAtStation_Private_Boolean_0;

		// Token: 0x04006D52 RID: 27986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006D53 RID: 27987
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006D54 RID: 27988
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006D55 RID: 27989
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006D56 RID: 27990
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006D57 RID: 27991
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartCook_2166136261_Private_Void_0;

		// Token: 0x04006D58 RID: 27992
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartCook_2166136261_Private_Void_0;

		// Token: 0x04006D59 RID: 27993
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartCook_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006D5A RID: 27994
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C5B RID: 3163
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviour+<<StartCook>g__CookRoutine|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F0C3 RID: 61635 RVA: 0x003A1C44 File Offset: 0x0039FE44
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique()
			{
				Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "<<StartCook>g__CookRoutine|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, "<>1__state");
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, "<>2__current");
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, "<>4__this");
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr__recipe_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, "<recipe>5__2");
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr__speedMultiplier_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, "<speedMultiplier>5__3");
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, 100684176);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, 100684177);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, 100684178);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, 100684179);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, 100684180);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr, 100684181);
			}

			// Token: 0x0600F0C4 RID: 61636 RVA: 0x003A1D4C File Offset: 0x0039FF4C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F0C5 RID: 61637 RVA: 0x003A1D94 File Offset: 0x0039FF94
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F0C6 RID: 61638 RVA: 0x003A1DC8 File Offset: 0x0039FFC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280672, XrefRangeEnd = 280783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004912 RID: 18706
			// (get) Token: 0x0600F0C7 RID: 61639 RVA: 0x003A1E04 File Offset: 0x003A0004
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F0C8 RID: 61640 RVA: 0x003A1E44 File Offset: 0x003A0044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280783, XrefRangeEnd = 280788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004913 RID: 18707
			// (get) Token: 0x0600F0C9 RID: 61641 RVA: 0x003A1E78 File Offset: 0x003A0078
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F0CA RID: 61642 RVA: 0x000719F5 File Offset: 0x0006FBF5
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700490D RID: 18701
			// (get) Token: 0x0600F0CB RID: 61643 RVA: 0x003A1EB8 File Offset: 0x003A00B8
			// (set) Token: 0x0600F0CC RID: 61644 RVA: 0x000719FE File Offset: 0x0006FBFE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700490E RID: 18702
			// (get) Token: 0x0600F0CD RID: 61645 RVA: 0x003A1EE0 File Offset: 0x003A00E0
			// (set) Token: 0x0600F0CE RID: 61646 RVA: 0x00071A19 File Offset: 0x0006FC19
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700490F RID: 18703
			// (get) Token: 0x0600F0CF RID: 61647 RVA: 0x003A1F10 File Offset: 0x003A0110
			// (set) Token: 0x0600F0D0 RID: 61648 RVA: 0x00071A38 File Offset: 0x0006FC38
			public unsafe StartChemistryStationBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartChemistryStationBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004910 RID: 18704
			// (get) Token: 0x0600F0D1 RID: 61649 RVA: 0x003A1F40 File Offset: 0x003A0140
			// (set) Token: 0x0600F0D2 RID: 61650 RVA: 0x00071A57 File Offset: 0x0006FC57
			public unsafe StationRecipe _recipe_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr__recipe_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr__recipe_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004911 RID: 18705
			// (get) Token: 0x0600F0D3 RID: 61651 RVA: 0x003A1F70 File Offset: 0x003A0170
			// (set) Token: 0x0600F0D4 RID: 61652 RVA: 0x00071A76 File Offset: 0x0006FC76
			public unsafe float _speedMultiplier_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr__speedMultiplier_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStSiStObObUnique.NativeFieldInfoPtr__speedMultiplier_5__3)) = value;
				}
			}

			// Token: 0x0400A2FC RID: 41724
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A2FD RID: 41725
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A2FE RID: 41726
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A2FF RID: 41727
			private static readonly IntPtr NativeFieldInfoPtr__recipe_5__2;

			// Token: 0x0400A300 RID: 41728
			private static readonly IntPtr NativeFieldInfoPtr__speedMultiplier_5__3;

			// Token: 0x0400A301 RID: 41729
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A302 RID: 41730
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A303 RID: 41731
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A304 RID: 41732
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A305 RID: 41733
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A306 RID: 41734
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

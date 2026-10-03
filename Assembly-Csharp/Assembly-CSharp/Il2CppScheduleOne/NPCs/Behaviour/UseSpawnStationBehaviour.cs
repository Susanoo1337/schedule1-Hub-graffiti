using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000675 RID: 1653
	public class UseSpawnStationBehaviour : Behaviour
	{
		// Token: 0x06009F3A RID: 40762 RVA: 0x002A7C30 File Offset: 0x002A5E30
		// Note: this type is marked as 'beforefieldinit'.
		static UseSpawnStationBehaviour()
		{
			Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "UseSpawnStationBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr);
			UseSpawnStationBehaviour.NativeFieldInfoPtr_TaskDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, "TaskDuration");
			UseSpawnStationBehaviour.NativeFieldInfoPtr_ProximityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, "ProximityThreshold");
			UseSpawnStationBehaviour.NativeFieldInfoPtr_AnimationBoolName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, "AnimationBoolName");
			UseSpawnStationBehaviour.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, "<Station>k__BackingField");
			UseSpawnStationBehaviour.NativeFieldInfoPtr__currentlyUsingStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, "_currentlyUsingStation");
			UseSpawnStationBehaviour.NativeFieldInfoPtr__workRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, "_workRoutine");
			UseSpawnStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UseSpawnStationBehaviourAssembly-CSharp.dll_Excuted");
			UseSpawnStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UseSpawnStationBehaviourAssembly-CSharp.dll_Excuted");
			UseSpawnStationBehaviour.NativeMethodInfoPtr_get_Station_Public_get_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684302);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_set_Station_Protected_set_Void_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684303);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_AssignStation_Public_Void_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684304);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684305);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684306);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684307);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684308);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684309);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_IsAtStation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684310);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_GoToStation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684311);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_BeginWork_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684312);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_StopWork_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684313);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_IsStationReady_Public_Boolean_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684314);
			UseSpawnStationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684315);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684316);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684317);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684318);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684319);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_BeginWork_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684320);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_RpcLogic___BeginWork_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684321);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_RpcReader___Observers_BeginWork_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684322);
			UseSpawnStationBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, 100684323);
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x06009F3B RID: 40763 RVA: 0x002A7EB8 File Offset: 0x002A60B8
		// (set) Token: 0x06009F3C RID: 40764 RVA: 0x002A7EF8 File Offset: 0x002A60F8
		public unsafe MushroomSpawnStation Station
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_get_Station_Public_get_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MushroomSpawnStation>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_set_Station_Protected_set_Void_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009F3D RID: 40765 RVA: 0x002A7F3C File Offset: 0x002A613C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281929, RefRangeEnd = 281930, XrefRangeStart = 281916, XrefRangeEnd = 281929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignStation(MushroomSpawnStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_AssignStation_Public_Void_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F3E RID: 40766 RVA: 0x002A7F80 File Offset: 0x002A6180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseSpawnStationBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F3F RID: 40767 RVA: 0x002A7FBC File Offset: 0x002A61BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281930, XrefRangeEnd = 281933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseSpawnStationBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F40 RID: 40768 RVA: 0x002A7FF8 File Offset: 0x002A61F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseSpawnStationBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x002A8034 File Offset: 0x002A6234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281933, XrefRangeEnd = 281935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseSpawnStationBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x002A8070 File Offset: 0x002A6270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281935, XrefRangeEnd = 281955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseSpawnStationBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F43 RID: 40771 RVA: 0x002A80AC File Offset: 0x002A62AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281955, XrefRangeEnd = 281963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_IsAtStation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009F44 RID: 40772 RVA: 0x002A80E8 File Offset: 0x002A62E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281963, XrefRangeEnd = 281969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_GoToStation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F45 RID: 40773 RVA: 0x002A811C File Offset: 0x002A631C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281969, XrefRangeEnd = 281990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginWork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_BeginWork_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F46 RID: 40774 RVA: 0x002A8150 File Offset: 0x002A6350
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282006, RefRangeEnd = 282008, XrefRangeStart = 281990, XrefRangeEnd = 282006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopWork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_StopWork_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F47 RID: 40775 RVA: 0x002A8184 File Offset: 0x002A6384
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 282022, RefRangeEnd = 282026, XrefRangeStart = 282008, XrefRangeEnd = 282022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStationReady(MushroomSpawnStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_IsStationReady_Public_Boolean_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009F48 RID: 40776 RVA: 0x002A81D4 File Offset: 0x002A63D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276250, XrefRangeEnd = 276252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseSpawnStationBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F49 RID: 40777 RVA: 0x002A8210 File Offset: 0x002A6410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282031, RefRangeEnd = 282032, XrefRangeStart = 282026, XrefRangeEnd = 282031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009F4A RID: 40778 RVA: 0x002A8250 File Offset: 0x002A6450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282032, XrefRangeEnd = 282040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseSpawnStationBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x002A828C File Offset: 0x002A648C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseSpawnStationBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x002A82C8 File Offset: 0x002A64C8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseSpawnStationBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F4D RID: 40781 RVA: 0x002A8304 File Offset: 0x002A6504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282040, XrefRangeEnd = 282049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginWork_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_BeginWork_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F4E RID: 40782 RVA: 0x002A8338 File Offset: 0x002A6538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282056, RefRangeEnd = 282058, XrefRangeStart = 282049, XrefRangeEnd = 282056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginWork_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_RpcLogic___BeginWork_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F4F RID: 40783 RVA: 0x002A836C File Offset: 0x002A656C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282058, XrefRangeEnd = 282061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginWork_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.NativeMethodInfoPtr_RpcReader___Observers_BeginWork_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x002A83BC File Offset: 0x002A65BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseSpawnStationBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F51 RID: 40785 RVA: 0x000495C2 File Offset: 0x000477C2
		public UseSpawnStationBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x06009F52 RID: 40786 RVA: 0x002A83F8 File Offset: 0x002A65F8
		// (set) Token: 0x06009F53 RID: 40787 RVA: 0x000495CB File Offset: 0x000477CB
		public unsafe static float TaskDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UseSpawnStationBehaviour.NativeFieldInfoPtr_TaskDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UseSpawnStationBehaviour.NativeFieldInfoPtr_TaskDuration, (void*)(&value));
			}
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x06009F54 RID: 40788 RVA: 0x002A8414 File Offset: 0x002A6614
		// (set) Token: 0x06009F55 RID: 40789 RVA: 0x000495D9 File Offset: 0x000477D9
		public unsafe static float ProximityThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UseSpawnStationBehaviour.NativeFieldInfoPtr_ProximityThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UseSpawnStationBehaviour.NativeFieldInfoPtr_ProximityThreshold, (void*)(&value));
			}
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x06009F56 RID: 40790 RVA: 0x002A8430 File Offset: 0x002A6630
		// (set) Token: 0x06009F57 RID: 40791 RVA: 0x000495E7 File Offset: 0x000477E7
		public unsafe static string AnimationBoolName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UseSpawnStationBehaviour.NativeFieldInfoPtr_AnimationBoolName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UseSpawnStationBehaviour.NativeFieldInfoPtr_AnimationBoolName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x06009F58 RID: 40792 RVA: 0x002A8450 File Offset: 0x002A6650
		// (set) Token: 0x06009F59 RID: 40793 RVA: 0x000495F9 File Offset: 0x000477F9
		public unsafe MushroomSpawnStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomSpawnStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x06009F5A RID: 40794 RVA: 0x002A8480 File Offset: 0x002A6680
		// (set) Token: 0x06009F5B RID: 40795 RVA: 0x00049618 File Offset: 0x00047818
		public unsafe bool _currentlyUsingStation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.NativeFieldInfoPtr__currentlyUsingStation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.NativeFieldInfoPtr__currentlyUsingStation)) = value;
			}
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x06009F5C RID: 40796 RVA: 0x002A84A8 File Offset: 0x002A66A8
		// (set) Token: 0x06009F5D RID: 40797 RVA: 0x00049633 File Offset: 0x00047833
		public unsafe Coroutine _workRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.NativeFieldInfoPtr__workRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.NativeFieldInfoPtr__workRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x06009F5E RID: 40798 RVA: 0x002A84D8 File Offset: 0x002A66D8
		// (set) Token: 0x06009F5F RID: 40799 RVA: 0x00049652 File Offset: 0x00047852
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x06009F60 RID: 40800 RVA: 0x002A8500 File Offset: 0x002A6700
		// (set) Token: 0x06009F61 RID: 40801 RVA: 0x0004966D File Offset: 0x0004786D
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006DD3 RID: 28115
		private static readonly IntPtr NativeFieldInfoPtr_TaskDuration;

		// Token: 0x04006DD4 RID: 28116
		private static readonly IntPtr NativeFieldInfoPtr_ProximityThreshold;

		// Token: 0x04006DD5 RID: 28117
		private static readonly IntPtr NativeFieldInfoPtr_AnimationBoolName;

		// Token: 0x04006DD6 RID: 28118
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04006DD7 RID: 28119
		private static readonly IntPtr NativeFieldInfoPtr__currentlyUsingStation;

		// Token: 0x04006DD8 RID: 28120
		private static readonly IntPtr NativeFieldInfoPtr__workRoutine;

		// Token: 0x04006DD9 RID: 28121
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006DDA RID: 28122
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006DDB RID: 28123
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_MushroomSpawnStation_0;

		// Token: 0x04006DDC RID: 28124
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Protected_set_Void_MushroomSpawnStation_0;

		// Token: 0x04006DDD RID: 28125
		private static readonly IntPtr NativeMethodInfoPtr_AssignStation_Public_Void_MushroomSpawnStation_0;

		// Token: 0x04006DDE RID: 28126
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006DDF RID: 28127
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006DE0 RID: 28128
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04006DE1 RID: 28129
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x04006DE2 RID: 28130
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x04006DE3 RID: 28131
		private static readonly IntPtr NativeMethodInfoPtr_IsAtStation_Public_Boolean_0;

		// Token: 0x04006DE4 RID: 28132
		private static readonly IntPtr NativeMethodInfoPtr_GoToStation_Public_Void_0;

		// Token: 0x04006DE5 RID: 28133
		private static readonly IntPtr NativeMethodInfoPtr_BeginWork_Public_Void_0;

		// Token: 0x04006DE6 RID: 28134
		private static readonly IntPtr NativeMethodInfoPtr_StopWork_Private_Void_0;

		// Token: 0x04006DE7 RID: 28135
		private static readonly IntPtr NativeMethodInfoPtr_IsStationReady_Public_Boolean_MushroomSpawnStation_0;

		// Token: 0x04006DE8 RID: 28136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006DE9 RID: 28137
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_0;

		// Token: 0x04006DEA RID: 28138
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006DEB RID: 28139
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006DEC RID: 28140
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006DED RID: 28141
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginWork_2166136261_Private_Void_0;

		// Token: 0x04006DEE RID: 28142
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginWork_2166136261_Public_Void_0;

		// Token: 0x04006DEF RID: 28143
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginWork_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006DF0 RID: 28144
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C60 RID: 3168
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.UseSpawnStationBehaviour+<<BeginWork>g__Package|17_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F117 RID: 61719 RVA: 0x003A2C24 File Offset: 0x003A0E24
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique()
			{
				Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UseSpawnStationBehaviour>.NativeClassPtr, "<<BeginWork>g__Package|17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr);
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, "<>1__state");
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, "<>2__current");
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, "<>4__this");
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr__scaledTaskDuration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, "<scaledTaskDuration>5__2");
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr__progress_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, "<progress>5__3");
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, 100684324);
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, 100684325);
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, 100684326);
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, 100684327);
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, 100684328);
				UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr, 100684329);
			}

			// Token: 0x0600F118 RID: 61720 RVA: 0x003A2D2C File Offset: 0x003A0F2C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F119 RID: 61721 RVA: 0x003A2D74 File Offset: 0x003A0F74
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F11A RID: 61722 RVA: 0x003A2DA8 File Offset: 0x003A0FA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281895, XrefRangeEnd = 281911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004932 RID: 18738
			// (get) Token: 0x0600F11B RID: 61723 RVA: 0x003A2DE4 File Offset: 0x003A0FE4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F11C RID: 61724 RVA: 0x003A2E24 File Offset: 0x003A1024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281911, XrefRangeEnd = 281916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004933 RID: 18739
			// (get) Token: 0x0600F11D RID: 61725 RVA: 0x003A2E58 File Offset: 0x003A1058
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F11E RID: 61726 RVA: 0x00071CA8 File Offset: 0x0006FEA8
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700492D RID: 18733
			// (get) Token: 0x0600F11F RID: 61727 RVA: 0x003A2E98 File Offset: 0x003A1098
			// (set) Token: 0x0600F120 RID: 61728 RVA: 0x00071CB1 File Offset: 0x0006FEB1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700492E RID: 18734
			// (get) Token: 0x0600F121 RID: 61729 RVA: 0x003A2EC0 File Offset: 0x003A10C0
			// (set) Token: 0x0600F122 RID: 61730 RVA: 0x00071CCC File Offset: 0x0006FECC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700492F RID: 18735
			// (get) Token: 0x0600F123 RID: 61731 RVA: 0x003A2EF0 File Offset: 0x003A10F0
			// (set) Token: 0x0600F124 RID: 61732 RVA: 0x00071CEB File Offset: 0x0006FEEB
			public unsafe UseSpawnStationBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UseSpawnStationBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004930 RID: 18736
			// (get) Token: 0x0600F125 RID: 61733 RVA: 0x003A2F20 File Offset: 0x003A1120
			// (set) Token: 0x0600F126 RID: 61734 RVA: 0x00071D0A File Offset: 0x0006FF0A
			public unsafe float _scaledTaskDuration_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr__scaledTaskDuration_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr__scaledTaskDuration_5__2)) = value;
				}
			}

			// Token: 0x17004931 RID: 18737
			// (get) Token: 0x0600F127 RID: 61735 RVA: 0x003A2F48 File Offset: 0x003A1148
			// (set) Token: 0x0600F128 RID: 61736 RVA: 0x00071D25 File Offset: 0x0006FF25
			public unsafe float _progress_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr__progress_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseSpawnStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsSiSiObObUnique.NativeFieldInfoPtr__progress_5__3)) = value;
				}
			}

			// Token: 0x0400A330 RID: 41776
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A331 RID: 41777
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A332 RID: 41778
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A333 RID: 41779
			private static readonly IntPtr NativeFieldInfoPtr__scaledTaskDuration_5__2;

			// Token: 0x0400A334 RID: 41780
			private static readonly IntPtr NativeFieldInfoPtr__progress_5__3;

			// Token: 0x0400A335 RID: 41781
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A336 RID: 41782
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A337 RID: 41783
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A338 RID: 41784
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A339 RID: 41785
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A33A RID: 41786
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

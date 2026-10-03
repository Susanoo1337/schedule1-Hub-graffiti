using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.Other;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000687 RID: 1671
	public class SmokeBreakBehaviour : Behaviour
	{
		// Token: 0x0600A248 RID: 41544 RVA: 0x002B32A0 File Offset: 0x002B14A0
		// Note: this type is marked as 'beforefieldinit'.
		static SmokeBreakBehaviour()
		{
			Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "SmokeBreakBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr);
			SmokeBreakBehaviour.NativeFieldInfoPtr_SmokeCigarette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "SmokeCigarette");
			SmokeBreakBehaviour.NativeFieldInfoPtr_MinMaxSmokeBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "MinMaxSmokeBreak");
			SmokeBreakBehaviour.NativeFieldInfoPtr_maxDistanceToSmokeLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "maxDistanceToSmokeLocation");
			SmokeBreakBehaviour.NativeFieldInfoPtr_SmokeBreakLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "SmokeBreakLocations");
			SmokeBreakBehaviour.NativeFieldInfoPtr__debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "_debugMode");
			SmokeBreakBehaviour.NativeFieldInfoPtr__ocationOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "_ocationOverride");
			SmokeBreakBehaviour.NativeFieldInfoPtr__showMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "_showMaxDistance");
			SmokeBreakBehaviour.NativeFieldInfoPtr__showLocationGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "_showLocationGizmos");
			SmokeBreakBehaviour.NativeFieldInfoPtr__showLookAtGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "_showLookAtGizmos");
			SmokeBreakBehaviour.NativeFieldInfoPtr__smokeBreakDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "_smokeBreakDuration");
			SmokeBreakBehaviour.NativeFieldInfoPtr__currentSmokeLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "_currentSmokeLocation");
			SmokeBreakBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SmokeBreakBehaviourAssembly-CSharp.dll_Excuted");
			SmokeBreakBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SmokeBreakBehaviourAssembly-CSharp.dll_Excuted");
			SmokeBreakBehaviour.NativeMethodInfoPtr_SetupEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684770);
			SmokeBreakBehaviour.NativeMethodInfoPtr_CleanUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684771);
			SmokeBreakBehaviour.NativeMethodInfoPtr_Enable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684772);
			SmokeBreakBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684773);
			SmokeBreakBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684774);
			SmokeBreakBehaviour.NativeMethodInfoPtr_BeginSmokeBreak_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684775);
			SmokeBreakBehaviour.NativeMethodInfoPtr_EndSmokeBreak_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684776);
			SmokeBreakBehaviour.NativeMethodInfoPtr_CheckSmokeBreakEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684777);
			SmokeBreakBehaviour.NativeMethodInfoPtr_UpdateSmokeBreakDuration_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684778);
			SmokeBreakBehaviour.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684779);
			SmokeBreakBehaviour.NativeMethodInfoPtr_OnTimeSkipped_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684780);
			SmokeBreakBehaviour.NativeMethodInfoPtr_OnHourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684781);
			SmokeBreakBehaviour.NativeMethodInfoPtr_ChangeLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684782);
			SmokeBreakBehaviour.NativeMethodInfoPtr_ActivateSmokeBreak_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684783);
			SmokeBreakBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684784);
			SmokeBreakBehaviour.NativeMethodInfoPtr__Activate_b__14_0_Private_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684785);
			SmokeBreakBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684786);
			SmokeBreakBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684787);
			SmokeBreakBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684788);
			SmokeBreakBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr, 100684789);
		}

		// Token: 0x0600A249 RID: 41545 RVA: 0x002B3564 File Offset: 0x002B1764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286188, RefRangeEnd = 286189, XrefRangeStart = 286152, XrefRangeEnd = 286188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr_SetupEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24A RID: 41546 RVA: 0x002B3598 File Offset: 0x002B1798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286225, RefRangeEnd = 286226, XrefRangeStart = 286189, XrefRangeEnd = 286225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr_CleanUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x002B35CC File Offset: 0x002B17CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286226, XrefRangeEnd = 286239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmokeBreakBehaviour.NativeMethodInfoPtr_Enable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x002B3608 File Offset: 0x002B1808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286239, XrefRangeEnd = 286314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmokeBreakBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24D RID: 41549 RVA: 0x002B3644 File Offset: 0x002B1844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286314, XrefRangeEnd = 286329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmokeBreakBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24E RID: 41550 RVA: 0x002B3680 File Offset: 0x002B1880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286349, RefRangeEnd = 286350, XrefRangeStart = 286329, XrefRangeEnd = 286349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginSmokeBreak()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr_BeginSmokeBreak_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24F RID: 41551 RVA: 0x002B36B4 File Offset: 0x002B18B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286350, XrefRangeEnd = 286362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSmokeBreak()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr_EndSmokeBreak_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A250 RID: 41552 RVA: 0x002B36E8 File Offset: 0x002B18E8
		[CallerCount(0)]
		public unsafe void CheckSmokeBreakEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr_CheckSmokeBreakEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A251 RID: 41553 RVA: 0x002B371C File Offset: 0x002B191C
		[CallerCount(0)]
		public unsafe void UpdateSmokeBreakDuration(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr_UpdateSmokeBreakDuration_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A252 RID: 41554 RVA: 0x002B375C File Offset: 0x002B195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286362, XrefRangeEnd = 286364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmokeBreakBehaviour.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x002B37A8 File Offset: 0x002B19A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286364, XrefRangeEnd = 286368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimeSkipped(int skippedTimeInMintues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref skippedTimeInMintues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr_OnTimeSkipped_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x002B37E8 File Offset: 0x002B19E8
		[CallerCount(0)]
		public unsafe void OnHourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr_OnHourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x002B381C File Offset: 0x002B1A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286368, XrefRangeEnd = 286376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr_ChangeLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A256 RID: 41558 RVA: 0x002B3850 File Offset: 0x002B1A50
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 286376, RefRangeEnd = 286422, XrefRangeStart = 286376, XrefRangeEnd = 286376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateSmokeBreak()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr_ActivateSmokeBreak_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A257 RID: 41559 RVA: 0x002B3884 File Offset: 0x002B1A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286422, XrefRangeEnd = 286423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmokeBreakBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmokeBreakBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A258 RID: 41560 RVA: 0x002B38C0 File Offset: 0x002B1AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286423, XrefRangeEnd = 286431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Activate_b__14_0(Transform loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeBreakBehaviour.NativeMethodInfoPtr__Activate_b__14_0_Private_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A259 RID: 41561 RVA: 0x002B3910 File Offset: 0x002B1B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286431, XrefRangeEnd = 286432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmokeBreakBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x002B394C File Offset: 0x002B1B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286432, XrefRangeEnd = 286433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmokeBreakBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x002B3988 File Offset: 0x002B1B88
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmokeBreakBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x002B39C4 File Offset: 0x002B1BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmokeBreakBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x0004A6CB File Offset: 0x000488CB
		public SmokeBreakBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x0600A25E RID: 41566 RVA: 0x002B3A00 File Offset: 0x002B1C00
		// (set) Token: 0x0600A25F RID: 41567 RVA: 0x0004A6D4 File Offset: 0x000488D4
		public unsafe SmokeCigarette SmokeCigarette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_SmokeCigarette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmokeCigarette>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_SmokeCigarette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x0600A260 RID: 41568 RVA: 0x002B3A30 File Offset: 0x002B1C30
		// (set) Token: 0x0600A261 RID: 41569 RVA: 0x0004A6F3 File Offset: 0x000488F3
		public unsafe Vector2Int MinMaxSmokeBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_MinMaxSmokeBreak);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_MinMaxSmokeBreak)) = value;
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x0600A262 RID: 41570 RVA: 0x002B3A58 File Offset: 0x002B1C58
		// (set) Token: 0x0600A263 RID: 41571 RVA: 0x0004A70E File Offset: 0x0004890E
		public unsafe float maxDistanceToSmokeLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_maxDistanceToSmokeLocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_maxDistanceToSmokeLocation)) = value;
			}
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x0600A264 RID: 41572 RVA: 0x002B3A80 File Offset: 0x002B1C80
		// (set) Token: 0x0600A265 RID: 41573 RVA: 0x0004A729 File Offset: 0x00048929
		public unsafe List<Transform> SmokeBreakLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_SmokeBreakLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_SmokeBreakLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x0600A266 RID: 41574 RVA: 0x002B3AB0 File Offset: 0x002B1CB0
		// (set) Token: 0x0600A267 RID: 41575 RVA: 0x0004A748 File Offset: 0x00048948
		public unsafe bool _debugMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__debugMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__debugMode)) = value;
			}
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x0600A268 RID: 41576 RVA: 0x002B3AD8 File Offset: 0x002B1CD8
		// (set) Token: 0x0600A269 RID: 41577 RVA: 0x0004A763 File Offset: 0x00048963
		public unsafe int _ocationOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__ocationOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__ocationOverride)) = value;
			}
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x0600A26A RID: 41578 RVA: 0x002B3B00 File Offset: 0x002B1D00
		// (set) Token: 0x0600A26B RID: 41579 RVA: 0x0004A77E File Offset: 0x0004897E
		public unsafe bool _showMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__showMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__showMaxDistance)) = value;
			}
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x0600A26C RID: 41580 RVA: 0x002B3B28 File Offset: 0x002B1D28
		// (set) Token: 0x0600A26D RID: 41581 RVA: 0x0004A799 File Offset: 0x00048999
		public unsafe bool _showLocationGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__showLocationGizmos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__showLocationGizmos)) = value;
			}
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x0600A26E RID: 41582 RVA: 0x002B3B50 File Offset: 0x002B1D50
		// (set) Token: 0x0600A26F RID: 41583 RVA: 0x0004A7B4 File Offset: 0x000489B4
		public unsafe bool _showLookAtGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__showLookAtGizmos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__showLookAtGizmos)) = value;
			}
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x0600A270 RID: 41584 RVA: 0x002B3B78 File Offset: 0x002B1D78
		// (set) Token: 0x0600A271 RID: 41585 RVA: 0x0004A7CF File Offset: 0x000489CF
		public unsafe int _smokeBreakDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__smokeBreakDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__smokeBreakDuration)) = value;
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x0600A272 RID: 41586 RVA: 0x002B3BA0 File Offset: 0x002B1DA0
		// (set) Token: 0x0600A273 RID: 41587 RVA: 0x0004A7EA File Offset: 0x000489EA
		public unsafe Transform _currentSmokeLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__currentSmokeLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr__currentSmokeLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x0600A274 RID: 41588 RVA: 0x002B3BD0 File Offset: 0x002B1DD0
		// (set) Token: 0x0600A275 RID: 41589 RVA: 0x0004A809 File Offset: 0x00048A09
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x0600A276 RID: 41590 RVA: 0x002B3BF8 File Offset: 0x002B1DF8
		// (set) Token: 0x0600A277 RID: 41591 RVA: 0x0004A824 File Offset: 0x00048A24
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeBreakBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400701B RID: 28699
		private static readonly IntPtr NativeFieldInfoPtr_SmokeCigarette;

		// Token: 0x0400701C RID: 28700
		private static readonly IntPtr NativeFieldInfoPtr_MinMaxSmokeBreak;

		// Token: 0x0400701D RID: 28701
		private static readonly IntPtr NativeFieldInfoPtr_maxDistanceToSmokeLocation;

		// Token: 0x0400701E RID: 28702
		private static readonly IntPtr NativeFieldInfoPtr_SmokeBreakLocations;

		// Token: 0x0400701F RID: 28703
		private static readonly IntPtr NativeFieldInfoPtr__debugMode;

		// Token: 0x04007020 RID: 28704
		private static readonly IntPtr NativeFieldInfoPtr__ocationOverride;

		// Token: 0x04007021 RID: 28705
		private static readonly IntPtr NativeFieldInfoPtr__showMaxDistance;

		// Token: 0x04007022 RID: 28706
		private static readonly IntPtr NativeFieldInfoPtr__showLocationGizmos;

		// Token: 0x04007023 RID: 28707
		private static readonly IntPtr NativeFieldInfoPtr__showLookAtGizmos;

		// Token: 0x04007024 RID: 28708
		private static readonly IntPtr NativeFieldInfoPtr__smokeBreakDuration;

		// Token: 0x04007025 RID: 28709
		private static readonly IntPtr NativeFieldInfoPtr__currentSmokeLocation;

		// Token: 0x04007026 RID: 28710
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007027 RID: 28711
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007028 RID: 28712
		private static readonly IntPtr NativeMethodInfoPtr_SetupEvents_Private_Void_0;

		// Token: 0x04007029 RID: 28713
		private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Private_Void_0;

		// Token: 0x0400702A RID: 28714
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_Void_0;

		// Token: 0x0400702B RID: 28715
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x0400702C RID: 28716
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x0400702D RID: 28717
		private static readonly IntPtr NativeMethodInfoPtr_BeginSmokeBreak_Private_Void_0;

		// Token: 0x0400702E RID: 28718
		private static readonly IntPtr NativeMethodInfoPtr_EndSmokeBreak_Private_Void_0;

		// Token: 0x0400702F RID: 28719
		private static readonly IntPtr NativeMethodInfoPtr_CheckSmokeBreakEnd_Private_Void_0;

		// Token: 0x04007030 RID: 28720
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSmokeBreakDuration_Private_Void_Int32_0;

		// Token: 0x04007031 RID: 28721
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x04007032 RID: 28722
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSkipped_Private_Void_Int32_0;

		// Token: 0x04007033 RID: 28723
		private static readonly IntPtr NativeMethodInfoPtr_OnHourPass_Private_Void_0;

		// Token: 0x04007034 RID: 28724
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLocation_Public_Void_0;

		// Token: 0x04007035 RID: 28725
		private static readonly IntPtr NativeMethodInfoPtr_ActivateSmokeBreak_Public_Void_0;

		// Token: 0x04007036 RID: 28726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007037 RID: 28727
		private static readonly IntPtr NativeMethodInfoPtr__Activate_b__14_0_Private_Boolean_Transform_0;

		// Token: 0x04007038 RID: 28728
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007039 RID: 28729
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400703A RID: 28730
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400703B RID: 28731
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

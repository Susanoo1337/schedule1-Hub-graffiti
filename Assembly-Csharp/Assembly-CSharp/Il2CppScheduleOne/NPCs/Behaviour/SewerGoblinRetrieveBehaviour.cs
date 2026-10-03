using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000686 RID: 1670
	public class SewerGoblinRetrieveBehaviour : Behaviour
	{
		// Token: 0x0600A220 RID: 41504 RVA: 0x002B2A1C File Offset: 0x002B0C1C
		// Note: this type is marked as 'beforefieldinit'.
		static SewerGoblinRetrieveBehaviour()
		{
			Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "SewerGoblinRetrieveBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr);
			SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_PROXIMITY_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, "PROXIMITY_THRESHOLD");
			SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, "TIMEOUT");
			SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_sewerGoblin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, "sewerGoblin");
			SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_onRetrieveComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, "onRetrieveComplete");
			SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_onRetrieveCancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, "onRetrieveCancelled");
			SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_timeSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, "timeSinceStart");
			SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_grabbing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, "grabbing");
			SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SewerGoblinRetrieveBehaviourAssembly-CSharp.dll_Excuted");
			SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SewerGoblinRetrieveBehaviourAssembly-CSharp.dll_Excuted");
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_get_Target_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684744);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684745);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684746);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684747);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684748);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684749);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_StartBehaviour_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684750);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_StopBehaviour_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684751);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_CancelRetrieve_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684752);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_CompleteRetrieve_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684753);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684754);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684755);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684756);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_WithinRangeOfTarget_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684757);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684758);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684759);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684760);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684761);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684762);
			SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, 100684763);
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x0600A221 RID: 41505 RVA: 0x002B2C90 File Offset: 0x002B0E90
		public unsafe Player Target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_get_Target_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x0600A222 RID: 41506 RVA: 0x002B2CD0 File Offset: 0x002B0ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286015, XrefRangeEnd = 286022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A223 RID: 41507 RVA: 0x002B2D0C File Offset: 0x002B0F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286022, XrefRangeEnd = 286024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A224 RID: 41508 RVA: 0x002B2D48 File Offset: 0x002B0F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286024, XrefRangeEnd = 286026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x002B2D84 File Offset: 0x002B0F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286026, XrefRangeEnd = 286028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x002B2DC0 File Offset: 0x002B0FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286028, XrefRangeEnd = 286030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x002B2DFC File Offset: 0x002B0FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286040, RefRangeEnd = 286042, XrefRangeStart = 286030, XrefRangeEnd = 286040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_StartBehaviour_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x002B2E30 File Offset: 0x002B1030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286053, RefRangeEnd = 286055, XrefRangeStart = 286042, XrefRangeEnd = 286053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_StopBehaviour_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x002B2E64 File Offset: 0x002B1064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286062, RefRangeEnd = 286063, XrefRangeStart = 286055, XrefRangeEnd = 286062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelRetrieve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_CancelRetrieve_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A22A RID: 41514 RVA: 0x002B2E98 File Offset: 0x002B1098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286063, XrefRangeEnd = 286075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteRetrieve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_CompleteRetrieve_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A22B RID: 41515 RVA: 0x002B2ECC File Offset: 0x002B10CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286075, XrefRangeEnd = 286102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A22C RID: 41516 RVA: 0x002B2F08 File Offset: 0x002B1108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286102, XrefRangeEnd = 286114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetDestinationValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A22D RID: 41517 RVA: 0x002B2F44 File Offset: 0x002B1144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286114, XrefRangeEnd = 286128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNewDestination(out Vector3 dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &dest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x002B2F90 File Offset: 0x002B1190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286128, XrefRangeEnd = 286138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WithinRangeOfTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_WithinRangeOfTarget_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A22F RID: 41519 RVA: 0x002B2FCC File Offset: 0x002B11CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276250, XrefRangeEnd = 276252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerGoblinRetrieveBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x002B3008 File Offset: 0x002B1208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286138, XrefRangeEnd = 286143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x002B3048 File Offset: 0x002B1248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286143, XrefRangeEnd = 286144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x002B3084 File Offset: 0x002B1284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286144, XrefRangeEnd = 286145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x002B30C0 File Offset: 0x002B12C0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A234 RID: 41524 RVA: 0x002B30FC File Offset: 0x002B12FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286145, XrefRangeEnd = 286152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblinRetrieveBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A235 RID: 41525 RVA: 0x0004A5DD File Offset: 0x000487DD
		public SewerGoblinRetrieveBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x0600A236 RID: 41526 RVA: 0x002B3138 File Offset: 0x002B1338
		// (set) Token: 0x0600A237 RID: 41527 RVA: 0x0004A5E6 File Offset: 0x000487E6
		public unsafe static float PROXIMITY_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_PROXIMITY_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_PROXIMITY_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x0600A238 RID: 41528 RVA: 0x002B3154 File Offset: 0x002B1354
		// (set) Token: 0x0600A239 RID: 41529 RVA: 0x0004A5F4 File Offset: 0x000487F4
		public unsafe static float TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x0600A23A RID: 41530 RVA: 0x002B3170 File Offset: 0x002B1370
		// (set) Token: 0x0600A23B RID: 41531 RVA: 0x0004A602 File Offset: 0x00048802
		public unsafe SewerGoblin sewerGoblin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_sewerGoblin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerGoblin>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_sewerGoblin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x0600A23C RID: 41532 RVA: 0x002B31A0 File Offset: 0x002B13A0
		// (set) Token: 0x0600A23D RID: 41533 RVA: 0x0004A621 File Offset: 0x00048821
		public unsafe Action onRetrieveComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_onRetrieveComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_onRetrieveComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x0600A23E RID: 41534 RVA: 0x002B31D0 File Offset: 0x002B13D0
		// (set) Token: 0x0600A23F RID: 41535 RVA: 0x0004A640 File Offset: 0x00048840
		public unsafe Action onRetrieveCancelled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_onRetrieveCancelled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_onRetrieveCancelled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x0600A240 RID: 41536 RVA: 0x002B3200 File Offset: 0x002B1400
		// (set) Token: 0x0600A241 RID: 41537 RVA: 0x0004A65F File Offset: 0x0004885F
		public unsafe float timeSinceStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_timeSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_timeSinceStart)) = value;
			}
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x0600A242 RID: 41538 RVA: 0x002B3228 File Offset: 0x002B1428
		// (set) Token: 0x0600A243 RID: 41539 RVA: 0x0004A67A File Offset: 0x0004887A
		public unsafe bool grabbing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_grabbing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_grabbing)) = value;
			}
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x0600A244 RID: 41540 RVA: 0x002B3250 File Offset: 0x002B1450
		// (set) Token: 0x0600A245 RID: 41541 RVA: 0x0004A695 File Offset: 0x00048895
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x0600A246 RID: 41542 RVA: 0x002B3278 File Offset: 0x002B1478
		// (set) Token: 0x0600A247 RID: 41543 RVA: 0x0004A6B0 File Offset: 0x000488B0
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006FFE RID: 28670
		private static readonly IntPtr NativeFieldInfoPtr_PROXIMITY_THRESHOLD;

		// Token: 0x04006FFF RID: 28671
		private static readonly IntPtr NativeFieldInfoPtr_TIMEOUT;

		// Token: 0x04007000 RID: 28672
		private static readonly IntPtr NativeFieldInfoPtr_sewerGoblin;

		// Token: 0x04007001 RID: 28673
		private static readonly IntPtr NativeFieldInfoPtr_onRetrieveComplete;

		// Token: 0x04007002 RID: 28674
		private static readonly IntPtr NativeFieldInfoPtr_onRetrieveCancelled;

		// Token: 0x04007003 RID: 28675
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStart;

		// Token: 0x04007004 RID: 28676
		private static readonly IntPtr NativeFieldInfoPtr_grabbing;

		// Token: 0x04007005 RID: 28677
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007006 RID: 28678
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007007 RID: 28679
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Player_0;

		// Token: 0x04007008 RID: 28680
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04007009 RID: 28681
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x0400700A RID: 28682
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x0400700B RID: 28683
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x0400700C RID: 28684
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x0400700D RID: 28685
		private static readonly IntPtr NativeMethodInfoPtr_StartBehaviour_Private_Void_0;

		// Token: 0x0400700E RID: 28686
		private static readonly IntPtr NativeMethodInfoPtr_StopBehaviour_Private_Void_0;

		// Token: 0x0400700F RID: 28687
		private static readonly IntPtr NativeMethodInfoPtr_CancelRetrieve_Public_Void_0;

		// Token: 0x04007010 RID: 28688
		private static readonly IntPtr NativeMethodInfoPtr_CompleteRetrieve_Private_Void_0;

		// Token: 0x04007011 RID: 28689
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04007012 RID: 28690
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0;

		// Token: 0x04007013 RID: 28691
		private static readonly IntPtr NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0;

		// Token: 0x04007014 RID: 28692
		private static readonly IntPtr NativeMethodInfoPtr_WithinRangeOfTarget_Private_Boolean_0;

		// Token: 0x04007015 RID: 28693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007016 RID: 28694
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04007017 RID: 28695
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007018 RID: 28696
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007019 RID: 28697
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400701A RID: 28698
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C6D RID: 3181
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.SewerGoblinRetrieveBehaviour+<<CompleteRetrieve>g__Routine|17_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F178 RID: 61816 RVA: 0x003A3E6C File Offset: 0x003A206C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique()
			{
				Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour>.NativeClassPtr, "<<CompleteRetrieve>g__Routine|17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr);
				SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr, "<>1__state");
				SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr, "<>2__current");
				SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr, "<>4__this");
				SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr, 100684764);
				SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr, 100684765);
				SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr, 100684766);
				SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr, 100684767);
				SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr, 100684768);
				SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr, 100684769);
			}

			// Token: 0x0600F179 RID: 61817 RVA: 0x003A3F4C File Offset: 0x003A214C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F17A RID: 61818 RVA: 0x003A3F94 File Offset: 0x003A2194
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F17B RID: 61819 RVA: 0x003A3FC8 File Offset: 0x003A21C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285997, XrefRangeEnd = 286010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700494E RID: 18766
			// (get) Token: 0x0600F17C RID: 61820 RVA: 0x003A4004 File Offset: 0x003A2204
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F17D RID: 61821 RVA: 0x003A4044 File Offset: 0x003A2244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286010, XrefRangeEnd = 286015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700494F RID: 18767
			// (get) Token: 0x0600F17E RID: 61822 RVA: 0x003A4078 File Offset: 0x003A2278
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F17F RID: 61823 RVA: 0x00071F61 File Offset: 0x00070161
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700494B RID: 18763
			// (get) Token: 0x0600F180 RID: 61824 RVA: 0x003A40B8 File Offset: 0x003A22B8
			// (set) Token: 0x0600F181 RID: 61825 RVA: 0x00071F6A File Offset: 0x0007016A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700494C RID: 18764
			// (get) Token: 0x0600F182 RID: 61826 RVA: 0x003A40E0 File Offset: 0x003A22E0
			// (set) Token: 0x0600F183 RID: 61827 RVA: 0x00071F85 File Offset: 0x00070185
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700494D RID: 18765
			// (get) Token: 0x0600F184 RID: 61828 RVA: 0x003A4110 File Offset: 0x003A2310
			// (set) Token: 0x0600F185 RID: 61829 RVA: 0x00071FA4 File Offset: 0x000701A4
			public unsafe SewerGoblinRetrieveBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerGoblinRetrieveBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblinRetrieveBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A377 RID: 41847
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A378 RID: 41848
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A379 RID: 41849
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A37A RID: 41850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A37B RID: 41851
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A37C RID: 41852
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A37D RID: 41853
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A37E RID: 41854
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A37F RID: 41855
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000195 RID: 405
	public class EntityVisibility : NetworkBehaviour
	{
		// Token: 0x060028FE RID: 10494 RVA: 0x001027FC File Offset: 0x001009FC
		// Note: this type is marked as 'beforefieldinit'.
		static EntityVisibility()
		{
			Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "EntityVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr);
			EntityVisibility.NativeFieldInfoPtr_MAX_VISIBLITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "MAX_VISIBLITY");
			EntityVisibility.NativeFieldInfoPtr_ActiveAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "ActiveAttributes");
			EntityVisibility.NativeFieldInfoPtr__VisualStates_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "<VisualStates>k__BackingField");
			EntityVisibility.NativeFieldInfoPtr_VisibilityCheckMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "VisibilityCheckMask");
			EntityVisibility.NativeFieldInfoPtr_CentralVisibilityPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "CentralVisibilityPoint");
			EntityVisibility.NativeFieldInfoPtr_VisibilityPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "VisibilityPoints");
			EntityVisibility.NativeFieldInfoPtr_environmentalVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "environmentalVisibility");
			EntityVisibility.NativeFieldInfoPtr_removalRoutinesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "removalRoutinesDict");
			EntityVisibility.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "maxPointsChangesByUniquenessCode");
			EntityVisibility.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "hits");
			EntityVisibility.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vision.EntityVisibilityAssembly-CSharp.dll_Excuted");
			EntityVisibility.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vision.EntityVisibilityAssembly-CSharp.dll_Excuted");
			EntityVisibility.NativeMethodInfoPtr_get_CurrentVisibility_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668538);
			EntityVisibility.NativeMethodInfoPtr_get_Suspiciousness_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668539);
			EntityVisibility.NativeMethodInfoPtr_get_VisualStates_Public_get_List_1_EntityVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668540);
			EntityVisibility.NativeMethodInfoPtr_set_VisualStates_Protected_set_Void_List_1_EntityVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668541);
			EntityVisibility.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668542);
			EntityVisibility.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668543);
			EntityVisibility.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668544);
			EntityVisibility.NativeMethodInfoPtr_CalculateVisibility_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668545);
			EntityVisibility.NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668546);
			EntityVisibility.NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668547);
			EntityVisibility.NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668548);
			EntityVisibility.NativeMethodInfoPtr_GetVisibilityPoints_Protected_Virtual_New_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668549);
			EntityVisibility.NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668550);
			EntityVisibility.NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668551);
			EntityVisibility.NativeMethodInfoPtr_GetState_Public_EntityVisualState_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668552);
			EntityVisibility.NativeMethodInfoPtr_ClearStates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668553);
			EntityVisibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668554);
			EntityVisibility.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668555);
			EntityVisibility.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668556);
			EntityVisibility.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668557);
			EntityVisibility.NativeMethodInfoPtr_RpcWriter___Server_ApplyState_2910447583_Private_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668558);
			EntityVisibility.NativeMethodInfoPtr_RpcLogic___ApplyState_2910447583_Public_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668559);
			EntityVisibility.NativeMethodInfoPtr_RpcReader___Server_ApplyState_2910447583_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668560);
			EntityVisibility.NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668561);
			EntityVisibility.NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668562);
			EntityVisibility.NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668563);
			EntityVisibility.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, 100668564);
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x00102B38 File Offset: 0x00100D38
		public unsafe virtual float CurrentVisibility
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122180, XrefRangeEnd = 122181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVisibility.NativeMethodInfoPtr_get_CurrentVisibility_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x00102B80 File Offset: 0x00100D80
		public unsafe virtual float Suspiciousness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVisibility.NativeMethodInfoPtr_get_Suspiciousness_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x00102BC8 File Offset: 0x00100DC8
		// (set) Token: 0x06002902 RID: 10498 RVA: 0x00102C08 File Offset: 0x00100E08
		public unsafe List<EntityVisualState> VisualStates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_get_VisualStates_Public_get_List_1_EntityVisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityVisualState>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_set_VisualStates_Protected_set_Void_List_1_EntityVisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x00102C4C File Offset: 0x00100E4C
		public unsafe Vector3 CenterPoint
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 122195, RefRangeEnd = 122197, XrefRangeStart = 122181, XrefRangeEnd = 122195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x00102C88 File Offset: 0x00100E88
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVisibility.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00102CC4 File Offset: 0x00100EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122197, XrefRangeEnd = 122206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVisibility.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00102D00 File Offset: 0x00100F00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122250, RefRangeEnd = 122251, XrefRangeStart = 122206, XrefRangeEnd = 122250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_CalculateVisibility_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00102D3C File Offset: 0x00100F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122266, RefRangeEnd = 122267, XrefRangeStart = 122251, XrefRangeEnd = 122266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityAttribute GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr3) : null;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x00102D8C File Offset: 0x00100F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122267, XrefRangeEnd = 122272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEnvironmentalVisibilityAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x00102DC0 File Offset: 0x00100FC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122407, RefRangeEnd = 122409, XrefRangeStart = 122272, XrefRangeEnd = 122407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateExposureToPoint(Vector3 point, float checkRange = 50f, NPC checkingNPC = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checkingNPC);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00102E2C File Offset: 0x0010102C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122409, XrefRangeEnd = 122430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<Vector3> GetVisibilityPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVisibility.NativeMethodInfoPtr_GetVisibilityPoints_Protected_Virtual_New_List_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00102E78 File Offset: 0x00101078
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 122432, RefRangeEnd = 122440, XrefRangeStart = 122430, XrefRangeEnd = 122432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyState(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRemoveAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00102ED8 File Offset: 0x001010D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 122442, RefRangeEnd = 122447, XrefRangeStart = 122440, XrefRangeEnd = 122442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveState(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x00102F28 File Offset: 0x00101128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122462, RefRangeEnd = 122464, XrefRangeStart = 122447, XrefRangeEnd = 122462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityVisualState GetState(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_GetState_Public_EntityVisualState_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityVisualState>(intPtr3) : null;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00102F78 File Offset: 0x00101178
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 122126, RefRangeEnd = 122129, XrefRangeStart = 122126, XrefRangeEnd = 122129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_ClearStates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00102FAC File Offset: 0x001011AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122464, XrefRangeEnd = 122500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityVisibility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00102FE8 File Offset: 0x001011E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122500, XrefRangeEnd = 122513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVisibility.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x00103024 File Offset: 0x00101224
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVisibility.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00103060 File Offset: 0x00101260
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVisibility.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x0010309C File Offset: 0x0010129C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 122527, RefRangeEnd = 122532, XrefRangeStart = 122513, XrefRangeEnd = 122527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ApplyState_2910447583(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRemoveAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_RpcWriter___Server_ApplyState_2910447583_Private_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x001030FC File Offset: 0x001012FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 122559, RefRangeEnd = 122565, XrefRangeStart = 122532, XrefRangeEnd = 122559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyState_2910447583(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRemoveAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_RpcLogic___ApplyState_2910447583_Public_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x0010315C File Offset: 0x0010135C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122565, XrefRangeEnd = 122572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ApplyState_2910447583(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_RpcReader___Server_ApplyState_2910447583_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x001031C0 File Offset: 0x001013C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 122585, RefRangeEnd = 122590, XrefRangeStart = 122572, XrefRangeEnd = 122585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RemoveState_606697822(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00103210 File Offset: 0x00101410
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 122604, RefRangeEnd = 122610, XrefRangeStart = 122590, XrefRangeEnd = 122604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveState_606697822(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00103260 File Offset: 0x00101460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122610, XrefRangeEnd = 122616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RemoveState_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x001032C4 File Offset: 0x001014C4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVisibility.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000157F8 File Offset: 0x000139F8
		public EntityVisibility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x00103300 File Offset: 0x00101500
		// (set) Token: 0x0600291C RID: 10524 RVA: 0x00015801 File Offset: 0x00013A01
		public unsafe static float MAX_VISIBLITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EntityVisibility.NativeFieldInfoPtr_MAX_VISIBLITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityVisibility.NativeFieldInfoPtr_MAX_VISIBLITY, (void*)(&value));
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x0600291D RID: 10525 RVA: 0x0010331C File Offset: 0x0010151C
		// (set) Token: 0x0600291E RID: 10526 RVA: 0x0001580F File Offset: 0x00013A0F
		public unsafe List<VisibilityAttribute> ActiveAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_ActiveAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisibilityAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_ActiveAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x0010334C File Offset: 0x0010154C
		// (set) Token: 0x06002920 RID: 10528 RVA: 0x0001582E File Offset: 0x00013A2E
		public unsafe List<EntityVisualState> _VisualStates_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr__VisualStates_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityVisualState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr__VisualStates_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x0010337C File Offset: 0x0010157C
		// (set) Token: 0x06002922 RID: 10530 RVA: 0x0001584D File Offset: 0x00013A4D
		public unsafe LayerMask VisibilityCheckMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_VisibilityCheckMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_VisibilityCheckMask)) = value;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x001033A4 File Offset: 0x001015A4
		// (set) Token: 0x06002924 RID: 10532 RVA: 0x00015868 File Offset: 0x00013A68
		public unsafe Transform CentralVisibilityPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_CentralVisibilityPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_CentralVisibilityPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x001033D4 File Offset: 0x001015D4
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x00015887 File Offset: 0x00013A87
		public unsafe List<Transform> VisibilityPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_VisibilityPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_VisibilityPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x00103404 File Offset: 0x00101604
		// (set) Token: 0x06002928 RID: 10536 RVA: 0x000158A6 File Offset: 0x00013AA6
		public unsafe VisibilityAttribute environmentalVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_environmentalVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_environmentalVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x00103434 File Offset: 0x00101634
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x000158C5 File Offset: 0x00013AC5
		public unsafe Dictionary<string, Coroutine> removalRoutinesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_removalRoutinesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_removalRoutinesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x00103464 File Offset: 0x00101664
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x000158E4 File Offset: 0x00013AE4
		public unsafe Dictionary<string, float> maxPointsChangesByUniquenessCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x00103494 File Offset: 0x00101694
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x00015903 File Offset: 0x00013B03
		public unsafe List<RaycastHit> hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x0600292F RID: 10543 RVA: 0x001034C4 File Offset: 0x001016C4
		// (set) Token: 0x06002930 RID: 10544 RVA: 0x00015922 File Offset: 0x00013B22
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002931 RID: 10545 RVA: 0x001034EC File Offset: 0x001016EC
		// (set) Token: 0x06002932 RID: 10546 RVA: 0x0001593D File Offset: 0x00013B3D
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeFieldInfoPtr_MAX_VISIBLITY;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAttributes;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeFieldInfoPtr__VisualStates_k__BackingField;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeFieldInfoPtr_VisibilityCheckMask;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeFieldInfoPtr_CentralVisibilityPoint;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeFieldInfoPtr_VisibilityPoints;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeFieldInfoPtr_environmentalVisibility;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeFieldInfoPtr_removalRoutinesDict;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeFieldInfoPtr_maxPointsChangesByUniquenessCode;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeFieldInfoPtr_hits;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVisibility_Public_Virtual_New_get_Single_0;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeMethodInfoPtr_get_Suspiciousness_Public_Virtual_New_get_Single_0;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeMethodInfoPtr_get_VisualStates_Public_get_List_1_EntityVisualState_0;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeMethodInfoPtr_set_VisualStates_Protected_set_Void_List_1_EntityVisualState_0;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeMethodInfoPtr_CalculateVisibility_Private_Single_0;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeMethodInfoPtr_GetVisibilityPoints_Protected_Virtual_New_List_1_Vector3_0;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_EntityVisualState_String_0;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr_ClearStates_Public_Void_0;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ApplyState_2910447583_Private_Void_String_EVisualState_Single_0;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyState_2910447583_Public_Void_String_EVisualState_Single_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ApplyState_2910447583_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000996 RID: 2454
		[ObfuscatedName("ScheduleOne.Vision.EntityVisibility+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA86 RID: 55942 RVA: 0x00362AC0 File Offset: 0x00360CC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EntityVisibility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityVisibility.__c>.NativeClassPtr);
				EntityVisibility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c>.NativeClassPtr, "<>9");
				EntityVisibility.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c>.NativeClassPtr, "<>9__25_0");
				EntityVisibility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c>.NativeClassPtr, 100668566);
				EntityVisibility.__c.NativeMethodInfoPtr__GetVisibilityPoints_b__25_0_Internal_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c>.NativeClassPtr, 100668567);
			}

			// Token: 0x0600DA87 RID: 55943 RVA: 0x00362B3C File Offset: 0x00360D3C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityVisibility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA88 RID: 55944 RVA: 0x00362B78 File Offset: 0x00360D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _GetVisibilityPoints_b__25_0(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c.NativeMethodInfoPtr__GetVisibilityPoints_b__25_0_Internal_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA89 RID: 55945 RVA: 0x00066BCD File Offset: 0x00064DCD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042B9 RID: 17081
			// (get) Token: 0x0600DA8A RID: 55946 RVA: 0x00362BC8 File Offset: 0x00360DC8
			// (set) Token: 0x0600DA8B RID: 55947 RVA: 0x00066BD6 File Offset: 0x00064DD6
			public unsafe static EntityVisibility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityVisibility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityVisibility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityVisibility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BA RID: 17082
			// (get) Token: 0x0600DA8C RID: 55948 RVA: 0x00362BF0 File Offset: 0x00360DF0
			// (set) Token: 0x0600DA8D RID: 55949 RVA: 0x00066BE8 File Offset: 0x00064DE8
			public unsafe static Func<Transform, Vector3> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityVisibility.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityVisibility.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009542 RID: 38210
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009543 RID: 38211
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x04009544 RID: 38212
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009545 RID: 38213
			private static readonly IntPtr NativeMethodInfoPtr__GetVisibilityPoints_b__25_0_Internal_Vector3_Transform_0;
		}

		// Token: 0x02000997 RID: 2455
		[ObfuscatedName("ScheduleOne.Vision.EntityVisibility+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA8E RID: 55950 RVA: 0x00362C18 File Offset: 0x00360E18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass21_0>.NativeClassPtr);
				EntityVisibility.__c__DisplayClass21_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass21_0>.NativeClassPtr, "name");
				EntityVisibility.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass21_0>.NativeClassPtr, 100668568);
				EntityVisibility.__c__DisplayClass21_0.NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass21_0>.NativeClassPtr, 100668569);
			}

			// Token: 0x0600DA8F RID: 55951 RVA: 0x00362C80 File Offset: 0x00360E80
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA90 RID: 55952 RVA: 0x00362CBC File Offset: 0x00360EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAttribute_b__0(VisibilityAttribute x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass21_0.NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA91 RID: 55953 RVA: 0x00066BFA File Offset: 0x00064DFA
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042BB RID: 17083
			// (get) Token: 0x0600DA92 RID: 55954 RVA: 0x00362D0C File Offset: 0x00360F0C
			// (set) Token: 0x0600DA93 RID: 55955 RVA: 0x00066C03 File Offset: 0x00064E03
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass21_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass21_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009546 RID: 38214
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04009547 RID: 38215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009548 RID: 38216
			private static readonly IntPtr NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0;
		}

		// Token: 0x02000998 RID: 2456
		[ObfuscatedName("ScheduleOne.Vision.EntityVisibility+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA94 RID: 55956 RVA: 0x00362D34 File Offset: 0x00360F34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr);
				EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr, "delay");
				EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr, "label");
				EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr_newState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr, "newState");
				EntityVisibility.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr, 100668570);
				EntityVisibility.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr, 100668571);
				EntityVisibility.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr, 100668572);
			}

			// Token: 0x0600DA95 RID: 55957 RVA: 0x00362DEC File Offset: 0x00360FEC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA96 RID: 55958 RVA: 0x00362E28 File Offset: 0x00361028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122168, XrefRangeEnd = 122173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DA97 RID: 55959 RVA: 0x00362E68 File Offset: 0x00361068
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122177, RefRangeEnd = 122178, XrefRangeStart = 122173, XrefRangeEnd = 122177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA98 RID: 55960 RVA: 0x00066C22 File Offset: 0x00064E22
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042BC RID: 17084
			// (get) Token: 0x0600DA99 RID: 55961 RVA: 0x00362E9C File Offset: 0x0036109C
			// (set) Token: 0x0600DA9A RID: 55962 RVA: 0x00066C2B File Offset: 0x00064E2B
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x170042BD RID: 17085
			// (get) Token: 0x0600DA9B RID: 55963 RVA: 0x00362EC4 File Offset: 0x003610C4
			// (set) Token: 0x0600DA9C RID: 55964 RVA: 0x00066C46 File Offset: 0x00064E46
			public unsafe EntityVisibility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityVisibility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BE RID: 17086
			// (get) Token: 0x0600DA9D RID: 55965 RVA: 0x00362EF4 File Offset: 0x003610F4
			// (set) Token: 0x0600DA9E RID: 55966 RVA: 0x00066C65 File Offset: 0x00064E65
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170042BF RID: 17087
			// (get) Token: 0x0600DA9F RID: 55967 RVA: 0x00362F1C File Offset: 0x0036111C
			// (set) Token: 0x0600DAA0 RID: 55968 RVA: 0x00066C84 File Offset: 0x00064E84
			public unsafe EntityVisualState newState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr_newState);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityVisualState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.NativeFieldInfoPtr_newState), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009549 RID: 38217
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x0400954A RID: 38218
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400954B RID: 38219
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x0400954C RID: 38220
			private static readonly IntPtr NativeFieldInfoPtr_newState;

			// Token: 0x0400954D RID: 38221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400954E RID: 38222
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400954F RID: 38223
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x02000DB6 RID: 3510
			[ObfuscatedName("ScheduleOne.Vision.EntityVisibility+<>c__DisplayClass27_0+<<RemoveState>g__DelayedRemove|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FDB3 RID: 64947 RVA: 0x003C6690 File Offset: 0x003C4890
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0>.NativeClassPtr, "<<RemoveState>g__DelayedRemove|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668573);
					EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668574);
					EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668575);
					EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668576);
					EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668577);
					EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668578);
				}

				// Token: 0x0600FDB4 RID: 64948 RVA: 0x003C6770 File Offset: 0x003C4970
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FDB5 RID: 64949 RVA: 0x003C67B8 File Offset: 0x003C49B8
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FDB6 RID: 64950 RVA: 0x003C67EC File Offset: 0x003C49EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122157, XrefRangeEnd = 122163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D23 RID: 19747
				// (get) Token: 0x0600FDB7 RID: 64951 RVA: 0x003C6828 File Offset: 0x003C4A28
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FDB8 RID: 64952 RVA: 0x003C6868 File Offset: 0x003C4A68
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122163, XrefRangeEnd = 122168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D24 RID: 19748
				// (get) Token: 0x0600FDB9 RID: 64953 RVA: 0x003C689C File Offset: 0x003C4A9C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FDBA RID: 64954 RVA: 0x0007830F File Offset: 0x0007650F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D20 RID: 19744
				// (get) Token: 0x0600FDBB RID: 64955 RVA: 0x003C68DC File Offset: 0x003C4ADC
				// (set) Token: 0x0600FDBC RID: 64956 RVA: 0x00078318 File Offset: 0x00076518
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D21 RID: 19745
				// (get) Token: 0x0600FDBD RID: 64957 RVA: 0x003C6904 File Offset: 0x003C4B04
				// (set) Token: 0x0600FDBE RID: 64958 RVA: 0x00078333 File Offset: 0x00076533
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D22 RID: 19746
				// (get) Token: 0x0600FDBF RID: 64959 RVA: 0x003C6934 File Offset: 0x003C4B34
				// (set) Token: 0x0600FDC0 RID: 64960 RVA: 0x00078352 File Offset: 0x00076552
				public unsafe EntityVisibility.__c__DisplayClass27_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityVisibility.__c__DisplayClass27_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AB06 RID: 43782
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB07 RID: 43783
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB08 RID: 43784
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB09 RID: 43785
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB0A RID: 43786
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB0B RID: 43787
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB0C RID: 43788
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB0D RID: 43789
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB0E RID: 43790
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000999 RID: 2457
		[ObfuscatedName("ScheduleOne.Vision.EntityVisibility+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DAA1 RID: 55969 RVA: 0x00362F4C File Offset: 0x0036114C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityVisibility>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass28_0>.NativeClassPtr);
				EntityVisibility.__c__DisplayClass28_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass28_0>.NativeClassPtr, "label");
				EntityVisibility.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass28_0>.NativeClassPtr, 100668579);
				EntityVisibility.__c__DisplayClass28_0.NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_EntityVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass28_0>.NativeClassPtr, 100668580);
			}

			// Token: 0x0600DAA2 RID: 55970 RVA: 0x00362FB4 File Offset: 0x003611B4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityVisibility.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAA3 RID: 55971 RVA: 0x00362FF0 File Offset: 0x003611F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122178, XrefRangeEnd = 122180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetState_b__0(EntityVisualState x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisibility.__c__DisplayClass28_0.NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_EntityVisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DAA4 RID: 55972 RVA: 0x00066CA3 File Offset: 0x00064EA3
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C0 RID: 17088
			// (get) Token: 0x0600DAA5 RID: 55973 RVA: 0x00363040 File Offset: 0x00361240
			// (set) Token: 0x0600DAA6 RID: 55974 RVA: 0x00066CAC File Offset: 0x00064EAC
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass28_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisibility.__c__DisplayClass28_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009550 RID: 38224
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009551 RID: 38225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009552 RID: 38226
			private static readonly IntPtr NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_EntityVisualState_0;
		}
	}
}

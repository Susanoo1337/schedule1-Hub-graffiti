using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x02000372 RID: 882
	public class WorldSpraySurface : SpraySurface
	{
		// Token: 0x06004B1C RID: 19228 RVA: 0x0017B204 File Offset: 0x00179404
		// Note: this type is marked as 'beforefieldinit'.
		static WorldSpraySurface()
		{
			Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "WorldSpraySurface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr);
			WorldSpraySurface.NativeFieldInfoPtr_RemoveCartelGraffitiXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "RemoveCartelGraffitiXP");
			WorldSpraySurface.NativeFieldInfoPtr_RemoveCartelGraffitiInfluenceChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "RemoveCartelGraffitiInfluenceChange");
			WorldSpraySurface.NativeFieldInfoPtr_CartelInfluenceChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "CartelInfluenceChange");
			WorldSpraySurface.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "<GUID>k__BackingField");
			WorldSpraySurface.NativeFieldInfoPtr__Region_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "<Region>k__BackingField");
			WorldSpraySurface.NativeFieldInfoPtr__HasEverBeenMarkedByPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "<HasEverBeenMarkedByPlayer>k__BackingField");
			WorldSpraySurface.NativeFieldInfoPtr__NPCStandPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "<NPCStandPoint>k__BackingField");
			WorldSpraySurface.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "BakedGUID");
			WorldSpraySurface.NativeFieldInfoPtr__CanBeSprayedByNPCs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "<CanBeSprayedByNPCs>k__BackingField");
			WorldSpraySurface.NativeFieldInfoPtr_StandPointWallOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "StandPointWallOffset");
			WorldSpraySurface.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Graffiti.WorldSpraySurfaceAssembly-CSharp.dll_Excuted");
			WorldSpraySurface.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Graffiti.WorldSpraySurfaceAssembly-CSharp.dll_Excuted");
			WorldSpraySurface.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672930);
			WorldSpraySurface.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672931);
			WorldSpraySurface.NativeMethodInfoPtr_get_Region_Public_get_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672932);
			WorldSpraySurface.NativeMethodInfoPtr_set_Region_Private_set_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672933);
			WorldSpraySurface.NativeMethodInfoPtr_get_HasEverBeenMarkedByPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672934);
			WorldSpraySurface.NativeMethodInfoPtr_set_HasEverBeenMarkedByPlayer_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672935);
			WorldSpraySurface.NativeMethodInfoPtr_get_NPCStandPoint_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672936);
			WorldSpraySurface.NativeMethodInfoPtr_set_NPCStandPoint_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672937);
			WorldSpraySurface.NativeMethodInfoPtr_get_CanBeSprayedByNPCs_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672938);
			WorldSpraySurface.NativeMethodInfoPtr_set_CanBeSprayedByNPCs_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672939);
			WorldSpraySurface.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672940);
			WorldSpraySurface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672941);
			WorldSpraySurface.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672942);
			WorldSpraySurface.NativeMethodInfoPtr_OnEditingFinished_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672943);
			WorldSpraySurface.NativeMethodInfoPtr_CleanGraffiti_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672944);
			WorldSpraySurface.NativeMethodInfoPtr_Reward_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672945);
			WorldSpraySurface.NativeMethodInfoPtr_ReplicateTo_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672946);
			WorldSpraySurface.NativeMethodInfoPtr_Set_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672947);
			WorldSpraySurface.NativeMethodInfoPtr_MarkDrawingFinalized_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672948);
			WorldSpraySurface.NativeMethodInfoPtr_SetFinalized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672949);
			WorldSpraySurface.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672950);
			WorldSpraySurface.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672951);
			WorldSpraySurface.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672952);
			WorldSpraySurface.NativeMethodInfoPtr_GroundNPCStandPoint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672953);
			WorldSpraySurface.NativeMethodInfoPtr_GetSaveData_Public_WorldSpraySurfaceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672954);
			WorldSpraySurface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672955);
			WorldSpraySurface.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672956);
			WorldSpraySurface.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672957);
			WorldSpraySurface.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672958);
			WorldSpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_Set_3759704962_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672959);
			WorldSpraySurface.NativeMethodInfoPtr_RpcLogic___Set_3759704962_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672960);
			WorldSpraySurface.NativeMethodInfoPtr_RpcReader___Observers_Set_3759704962_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672961);
			WorldSpraySurface.NativeMethodInfoPtr_RpcWriter___Target_Set_3759704962_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672962);
			WorldSpraySurface.NativeMethodInfoPtr_RpcReader___Target_Set_3759704962_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672963);
			WorldSpraySurface.NativeMethodInfoPtr_RpcWriter___Server_MarkDrawingFinalized_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672964);
			WorldSpraySurface.NativeMethodInfoPtr_RpcLogic___MarkDrawingFinalized_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672965);
			WorldSpraySurface.NativeMethodInfoPtr_RpcReader___Server_MarkDrawingFinalized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672966);
			WorldSpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_SetFinalized_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672967);
			WorldSpraySurface.NativeMethodInfoPtr_RpcLogic___SetFinalized_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672968);
			WorldSpraySurface.NativeMethodInfoPtr_RpcReader___Observers_SetFinalized_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672969);
			WorldSpraySurface.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, 100672970);
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06004B1D RID: 19229 RVA: 0x0017B658 File Offset: 0x00179858
		// (set) Token: 0x06004B1E RID: 19230 RVA: 0x0017B694 File Offset: 0x00179894
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06004B1F RID: 19231 RVA: 0x0017B6D4 File Offset: 0x001798D4
		// (set) Token: 0x06004B20 RID: 19232 RVA: 0x0017B710 File Offset: 0x00179910
		public unsafe EMapRegion Region
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_get_Region_Public_get_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_set_Region_Private_set_Void_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06004B21 RID: 19233 RVA: 0x0017B750 File Offset: 0x00179950
		// (set) Token: 0x06004B22 RID: 19234 RVA: 0x0017B78C File Offset: 0x0017998C
		public unsafe bool HasEverBeenMarkedByPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_get_HasEverBeenMarkedByPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_set_HasEverBeenMarkedByPlayer_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06004B23 RID: 19235 RVA: 0x0017B7CC File Offset: 0x001799CC
		// (set) Token: 0x06004B24 RID: 19236 RVA: 0x0017B80C File Offset: 0x00179A0C
		public unsafe Transform NPCStandPoint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 171392, RefRangeEnd = 171393, XrefRangeStart = 171392, XrefRangeEnd = 171392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_get_NPCStandPoint_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171393, XrefRangeEnd = 171394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_set_NPCStandPoint_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06004B25 RID: 19237 RVA: 0x0017B850 File Offset: 0x00179A50
		// (set) Token: 0x06004B26 RID: 19238 RVA: 0x0017B88C File Offset: 0x00179A8C
		public unsafe bool CanBeSprayedByNPCs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_get_CanBeSprayedByNPCs_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_set_CanBeSprayedByNPCs_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x0017B8CC File Offset: 0x00179ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171394, XrefRangeEnd = 171416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldSpraySurface.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x0017B908 File Offset: 0x00179B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171416, XrefRangeEnd = 171438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x0017B93C File Offset: 0x00179B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171438, XrefRangeEnd = 171450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x0017B970 File Offset: 0x00179B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171450, XrefRangeEnd = 171516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEditingFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldSpraySurface.NativeMethodInfoPtr_OnEditingFinished_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x0017B9AC File Offset: 0x00179BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171516, XrefRangeEnd = 171537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CleanGraffiti()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldSpraySurface.NativeMethodInfoPtr_CleanGraffiti_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x0017B9E8 File Offset: 0x00179BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171537, XrefRangeEnd = 171552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_Reward_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x0017BA1C File Offset: 0x00179C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171552, XrefRangeEnd = 171556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReplicateTo(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldSpraySurface.NativeMethodInfoPtr_ReplicateTo_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x0017BA6C File Offset: 0x00179C6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171599, RefRangeEnd = 171601, XrefRangeStart = 171556, XrefRangeEnd = 171599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(NetworkConnection conn, Il2CppReferenceArray<SprayStroke> strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenFinalized;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCartelGraffiti;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_Set_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x0017BADC File Offset: 0x00179CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171601, XrefRangeEnd = 171622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDrawingFinalized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_MarkDrawingFinalized_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x0017BB10 File Offset: 0x00179D10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 171631, RefRangeEnd = 171634, XrefRangeStart = 171622, XrefRangeEnd = 171631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFinalized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_SetFinalized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x0017BB44 File Offset: 0x00179D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171634, XrefRangeEnd = 171635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldSpraySurface.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x0017BB8C File Offset: 0x00179D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171635, XrefRangeEnd = 171639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x0017BBCC File Offset: 0x00179DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171639, XrefRangeEnd = 171642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x0017BC00 File Offset: 0x00179E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171642, XrefRangeEnd = 171665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GroundNPCStandPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_GroundNPCStandPoint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x0017BC34 File Offset: 0x00179E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171677, RefRangeEnd = 171678, XrefRangeStart = 171665, XrefRangeEnd = 171677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe WorldSpraySurfaceData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_GetSaveData_Public_WorldSpraySurfaceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldSpraySurfaceData>(intPtr3) : null;
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x0017BC74 File Offset: 0x00179E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171678, XrefRangeEnd = 171689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldSpraySurface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x0017BCB0 File Offset: 0x00179EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171689, XrefRangeEnd = 171716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldSpraySurface.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x0017BCEC File Offset: 0x00179EEC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldSpraySurface.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x0017BD28 File Offset: 0x00179F28
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldSpraySurface.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x0017BD64 File Offset: 0x00179F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171716, XrefRangeEnd = 171728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Set_3759704962(NetworkConnection conn, Il2CppReferenceArray<SprayStroke> strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenFinalized;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCartelGraffiti;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_Set_3759704962_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x0017BDD4 File Offset: 0x00179FD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 171733, RefRangeEnd = 171736, XrefRangeStart = 171728, XrefRangeEnd = 171733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Set_3759704962(NetworkConnection conn, Il2CppReferenceArray<SprayStroke> strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenFinalized;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCartelGraffiti;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcLogic___Set_3759704962_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x0017BE44 File Offset: 0x0017A044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171736, XrefRangeEnd = 171740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Set_3759704962(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcReader___Observers_Set_3759704962_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x0017BE94 File Offset: 0x0017A094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171740, XrefRangeEnd = 171752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Set_3759704962(NetworkConnection conn, Il2CppReferenceArray<SprayStroke> strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenFinalized;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCartelGraffiti;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcWriter___Target_Set_3759704962_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x0017BF04 File Offset: 0x0017A104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171752, XrefRangeEnd = 171756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Set_3759704962(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcReader___Target_Set_3759704962_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x0017BF54 File Offset: 0x0017A154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171756, XrefRangeEnd = 171765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkDrawingFinalized_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcWriter___Server_MarkDrawingFinalized_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x0017BF88 File Offset: 0x0017A188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 171631, RefRangeEnd = 171634, XrefRangeStart = 171631, XrefRangeEnd = 171634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkDrawingFinalized_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcLogic___MarkDrawingFinalized_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x0017BFBC File Offset: 0x0017A1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171765, XrefRangeEnd = 171768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkDrawingFinalized_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcReader___Server_MarkDrawingFinalized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x0017C020 File Offset: 0x0017A220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171768, XrefRangeEnd = 171777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetFinalized_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_SetFinalized_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x0017C054 File Offset: 0x0017A254
		[CallerCount(0)]
		public unsafe void RpcLogic___SetFinalized_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcLogic___SetFinalized_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x0017C088 File Offset: 0x0017A288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171777, XrefRangeEnd = 171779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetFinalized_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.NativeMethodInfoPtr_RpcReader___Observers_SetFinalized_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x0017C0D8 File Offset: 0x0017A2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171779, XrefRangeEnd = 171800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldSpraySurface.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x00024477 File Offset: 0x00022677
		public WorldSpraySurface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06004B47 RID: 19271 RVA: 0x0017C114 File Offset: 0x0017A314
		// (set) Token: 0x06004B48 RID: 19272 RVA: 0x00024480 File Offset: 0x00022680
		public unsafe static int RemoveCartelGraffitiXP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(WorldSpraySurface.NativeFieldInfoPtr_RemoveCartelGraffitiXP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldSpraySurface.NativeFieldInfoPtr_RemoveCartelGraffitiXP, (void*)(&value));
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06004B49 RID: 19273 RVA: 0x0017C130 File Offset: 0x0017A330
		// (set) Token: 0x06004B4A RID: 19274 RVA: 0x0002448E File Offset: 0x0002268E
		public unsafe static float RemoveCartelGraffitiInfluenceChange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldSpraySurface.NativeFieldInfoPtr_RemoveCartelGraffitiInfluenceChange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldSpraySurface.NativeFieldInfoPtr_RemoveCartelGraffitiInfluenceChange, (void*)(&value));
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06004B4B RID: 19275 RVA: 0x0017C14C File Offset: 0x0017A34C
		// (set) Token: 0x06004B4C RID: 19276 RVA: 0x0002449C File Offset: 0x0002269C
		public unsafe static float CartelInfluenceChange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldSpraySurface.NativeFieldInfoPtr_CartelInfluenceChange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldSpraySurface.NativeFieldInfoPtr_CartelInfluenceChange, (void*)(&value));
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06004B4D RID: 19277 RVA: 0x0017C168 File Offset: 0x0017A368
		// (set) Token: 0x06004B4E RID: 19278 RVA: 0x000244AA File Offset: 0x000226AA
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06004B4F RID: 19279 RVA: 0x0017C190 File Offset: 0x0017A390
		// (set) Token: 0x06004B50 RID: 19280 RVA: 0x000244C5 File Offset: 0x000226C5
		public unsafe EMapRegion _Region_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr__Region_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr__Region_k__BackingField)) = value;
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06004B51 RID: 19281 RVA: 0x0017C1B8 File Offset: 0x0017A3B8
		// (set) Token: 0x06004B52 RID: 19282 RVA: 0x000244E0 File Offset: 0x000226E0
		public unsafe bool _HasEverBeenMarkedByPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr__HasEverBeenMarkedByPlayer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr__HasEverBeenMarkedByPlayer_k__BackingField)) = value;
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06004B53 RID: 19283 RVA: 0x0017C1E0 File Offset: 0x0017A3E0
		// (set) Token: 0x06004B54 RID: 19284 RVA: 0x000244FB File Offset: 0x000226FB
		public unsafe Transform _NPCStandPoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr__NPCStandPoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr__NPCStandPoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06004B55 RID: 19285 RVA: 0x0017C210 File Offset: 0x0017A410
		// (set) Token: 0x06004B56 RID: 19286 RVA: 0x0002451A File Offset: 0x0002271A
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06004B57 RID: 19287 RVA: 0x0017C238 File Offset: 0x0017A438
		// (set) Token: 0x06004B58 RID: 19288 RVA: 0x00024539 File Offset: 0x00022739
		public unsafe bool _CanBeSprayedByNPCs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr__CanBeSprayedByNPCs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr__CanBeSprayedByNPCs_k__BackingField)) = value;
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06004B59 RID: 19289 RVA: 0x0017C260 File Offset: 0x0017A460
		// (set) Token: 0x06004B5A RID: 19290 RVA: 0x00024554 File Offset: 0x00022754
		public unsafe float StandPointWallOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr_StandPointWallOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr_StandPointWallOffset)) = value;
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06004B5B RID: 19291 RVA: 0x0017C288 File Offset: 0x0017A488
		// (set) Token: 0x06004B5C RID: 19292 RVA: 0x0002456F File Offset: 0x0002276F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06004B5D RID: 19293 RVA: 0x0017C2B0 File Offset: 0x0017A4B0
		// (set) Token: 0x06004B5E RID: 19294 RVA: 0x0002458A File Offset: 0x0002278A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurface.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400332D RID: 13101
		private static readonly IntPtr NativeFieldInfoPtr_RemoveCartelGraffitiXP;

		// Token: 0x0400332E RID: 13102
		private static readonly IntPtr NativeFieldInfoPtr_RemoveCartelGraffitiInfluenceChange;

		// Token: 0x0400332F RID: 13103
		private static readonly IntPtr NativeFieldInfoPtr_CartelInfluenceChange;

		// Token: 0x04003330 RID: 13104
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003331 RID: 13105
		private static readonly IntPtr NativeFieldInfoPtr__Region_k__BackingField;

		// Token: 0x04003332 RID: 13106
		private static readonly IntPtr NativeFieldInfoPtr__HasEverBeenMarkedByPlayer_k__BackingField;

		// Token: 0x04003333 RID: 13107
		private static readonly IntPtr NativeFieldInfoPtr__NPCStandPoint_k__BackingField;

		// Token: 0x04003334 RID: 13108
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04003335 RID: 13109
		private static readonly IntPtr NativeFieldInfoPtr__CanBeSprayedByNPCs_k__BackingField;

		// Token: 0x04003336 RID: 13110
		private static readonly IntPtr NativeFieldInfoPtr_StandPointWallOffset;

		// Token: 0x04003337 RID: 13111
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003338 RID: 13112
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003339 RID: 13113
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400333A RID: 13114
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400333B RID: 13115
		private static readonly IntPtr NativeMethodInfoPtr_get_Region_Public_get_EMapRegion_0;

		// Token: 0x0400333C RID: 13116
		private static readonly IntPtr NativeMethodInfoPtr_set_Region_Private_set_Void_EMapRegion_0;

		// Token: 0x0400333D RID: 13117
		private static readonly IntPtr NativeMethodInfoPtr_get_HasEverBeenMarkedByPlayer_Public_get_Boolean_0;

		// Token: 0x0400333E RID: 13118
		private static readonly IntPtr NativeMethodInfoPtr_set_HasEverBeenMarkedByPlayer_Private_set_Void_Boolean_0;

		// Token: 0x0400333F RID: 13119
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCStandPoint_Public_get_Transform_0;

		// Token: 0x04003340 RID: 13120
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCStandPoint_Private_set_Void_Transform_0;

		// Token: 0x04003341 RID: 13121
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSprayedByNPCs_Public_get_Boolean_0;

		// Token: 0x04003342 RID: 13122
		private static readonly IntPtr NativeMethodInfoPtr_set_CanBeSprayedByNPCs_Private_set_Void_Boolean_0;

		// Token: 0x04003343 RID: 13123
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003344 RID: 13124
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003345 RID: 13125
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04003346 RID: 13126
		private static readonly IntPtr NativeMethodInfoPtr_OnEditingFinished_Public_Virtual_Void_0;

		// Token: 0x04003347 RID: 13127
		private static readonly IntPtr NativeMethodInfoPtr_CleanGraffiti_Public_Virtual_Void_0;

		// Token: 0x04003348 RID: 13128
		private static readonly IntPtr NativeMethodInfoPtr_Reward_Private_Void_0;

		// Token: 0x04003349 RID: 13129
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateTo_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400334A RID: 13130
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0;

		// Token: 0x0400334B RID: 13131
		private static readonly IntPtr NativeMethodInfoPtr_MarkDrawingFinalized_Public_Void_0;

		// Token: 0x0400334C RID: 13132
		private static readonly IntPtr NativeMethodInfoPtr_SetFinalized_Private_Void_0;

		// Token: 0x0400334D RID: 13133
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x0400334E RID: 13134
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x0400334F RID: 13135
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04003350 RID: 13136
		private static readonly IntPtr NativeMethodInfoPtr_GroundNPCStandPoint_Private_Void_0;

		// Token: 0x04003351 RID: 13137
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_WorldSpraySurfaceData_0;

		// Token: 0x04003352 RID: 13138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003353 RID: 13139
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003354 RID: 13140
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003355 RID: 13141
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003356 RID: 13142
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Set_3759704962_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0;

		// Token: 0x04003357 RID: 13143
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Set_3759704962_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0;

		// Token: 0x04003358 RID: 13144
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Set_3759704962_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003359 RID: 13145
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Set_3759704962_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_Boolean_0;

		// Token: 0x0400335A RID: 13146
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Set_3759704962_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400335B RID: 13147
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkDrawingFinalized_2166136261_Private_Void_0;

		// Token: 0x0400335C RID: 13148
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MarkDrawingFinalized_2166136261_Public_Void_0;

		// Token: 0x0400335D RID: 13149
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkDrawingFinalized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400335E RID: 13150
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetFinalized_2166136261_Private_Void_0;

		// Token: 0x0400335F RID: 13151
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetFinalized_2166136261_Private_Void_0;

		// Token: 0x04003360 RID: 13152
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetFinalized_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003361 RID: 13153
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A76 RID: 2678
		[ObfuscatedName("ScheduleOne.Graffiti.WorldSpraySurface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E136 RID: 57654 RVA: 0x003750DC File Offset: 0x003732DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WorldSpraySurface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldSpraySurface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpraySurface.__c>.NativeClassPtr);
				WorldSpraySurface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface.__c>.NativeClassPtr, "<>9");
				WorldSpraySurface.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurface.__c>.NativeClassPtr, "<>9__28_0");
				WorldSpraySurface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface.__c>.NativeClassPtr, 100672972);
				WorldSpraySurface.__c.NativeMethodInfoPtr__OnEditingFinished_b__28_0_Internal_Boolean_WorldSpraySurface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurface.__c>.NativeClassPtr, 100672973);
			}

			// Token: 0x0600E137 RID: 57655 RVA: 0x00375158 File Offset: 0x00373358
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpraySurface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E138 RID: 57656 RVA: 0x00375194 File Offset: 0x00373394
			[CallerCount(0)]
			public unsafe bool _OnEditingFinished_b__28_0(WorldSpraySurface s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurface.__c.NativeMethodInfoPtr__OnEditingFinished_b__28_0_Internal_Boolean_WorldSpraySurface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E139 RID: 57657 RVA: 0x0006A277 File Offset: 0x00068477
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700448D RID: 17549
			// (get) Token: 0x0600E13A RID: 57658 RVA: 0x003751E4 File Offset: 0x003733E4
			// (set) Token: 0x0600E13B RID: 57659 RVA: 0x0006A280 File Offset: 0x00068480
			public unsafe static WorldSpraySurface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorldSpraySurface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldSpraySurface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorldSpraySurface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700448E RID: 17550
			// (get) Token: 0x0600E13C RID: 57660 RVA: 0x0037520C File Offset: 0x0037340C
			// (set) Token: 0x0600E13D RID: 57661 RVA: 0x0006A292 File Offset: 0x00068492
			public unsafe static Predicate<WorldSpraySurface> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorldSpraySurface.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<WorldSpraySurface>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorldSpraySurface.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400994E RID: 39246
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400994F RID: 39247
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x04009950 RID: 39248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009951 RID: 39249
			private static readonly IntPtr NativeMethodInfoPtr__OnEditingFinished_b__28_0_Internal_Boolean_WorldSpraySurface_0;
		}
	}
}

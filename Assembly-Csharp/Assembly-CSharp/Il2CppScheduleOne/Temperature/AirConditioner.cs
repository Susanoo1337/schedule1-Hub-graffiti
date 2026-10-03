using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI;
using UnityEngine;

namespace Il2CppScheduleOne.Temperature
{
	// Token: 0x0200011E RID: 286
	public class AirConditioner : GridItem
	{
		// Token: 0x06001B84 RID: 7044 RVA: 0x000D5D40 File Offset: 0x000D3F40
		// Note: this type is marked as 'beforefieldinit'.
		static AirConditioner()
		{
			Il2CppClassPointerStore<AirConditioner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Temperature", "AirConditioner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr);
			AirConditioner.NativeFieldInfoPtr_CoolingTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "CoolingTemperature");
			AirConditioner.NativeFieldInfoPtr_HeatingTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "HeatingTemperature");
			AirConditioner.NativeFieldInfoPtr__TemperatureEmitter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "<TemperatureEmitter>k__BackingField");
			AirConditioner.NativeFieldInfoPtr__TemperatureDisplay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "<TemperatureDisplay>k__BackingField");
			AirConditioner.NativeFieldInfoPtr__coolingLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "_coolingLight");
			AirConditioner.NativeFieldInfoPtr__heatingLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "_heatingLight");
			AirConditioner.NativeFieldInfoPtr__beepSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "_beepSound");
			AirConditioner.NativeFieldInfoPtr__loopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "_loopSound");
			AirConditioner.NativeFieldInfoPtr__heatParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "_heatParticles");
			AirConditioner.NativeFieldInfoPtr__coolParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "_coolParticles");
			AirConditioner.NativeFieldInfoPtr__CurrentMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "<CurrentMode>k__BackingField");
			AirConditioner.NativeFieldInfoPtr_syncVar____CurrentMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "syncVar___<CurrentMode>k__BackingField");
			AirConditioner.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Temperature.AirConditionerAssembly-CSharp.dll_Excuted");
			AirConditioner.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Temperature.AirConditionerAssembly-CSharp.dll_Excuted");
			AirConditioner.NativeMethodInfoPtr_get_TemperatureEmitter_Public_get_TemperatureEmitter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666941);
			AirConditioner.NativeMethodInfoPtr_set_TemperatureEmitter_Private_set_Void_TemperatureEmitter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666942);
			AirConditioner.NativeMethodInfoPtr_get_TemperatureDisplay_Public_get_TemperatureDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666943);
			AirConditioner.NativeMethodInfoPtr_set_TemperatureDisplay_Private_set_Void_TemperatureDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666944);
			AirConditioner.NativeMethodInfoPtr_get_CurrentMode_Public_get_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666945);
			AirConditioner.NativeMethodInfoPtr_set_CurrentMode_Private_set_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666946);
			AirConditioner.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666947);
			AirConditioner.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666948);
			AirConditioner.NativeMethodInfoPtr_HeatmapVisibilityChanged_Private_Void_Property_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666949);
			AirConditioner.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666950);
			AirConditioner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666951);
			AirConditioner.NativeMethodInfoPtr_UpdateLoopSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666952);
			AirConditioner.NativeMethodInfoPtr_SetMode_Server_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666953);
			AirConditioner.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666954);
			AirConditioner.NativeMethodInfoPtr_ApplyMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666955);
			AirConditioner.NativeMethodInfoPtr_OnModeChanged_Private_Void_EMode_EMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666956);
			AirConditioner.NativeMethodInfoPtr_SetOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666957);
			AirConditioner.NativeMethodInfoPtr_SetCooling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666958);
			AirConditioner.NativeMethodInfoPtr_SetHeating_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666959);
			AirConditioner.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666960);
			AirConditioner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666961);
			AirConditioner.NativeMethodInfoPtr__InitializeGridItem_b__22_0_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666962);
			AirConditioner.NativeMethodInfoPtr__InitializeGridItem_b__22_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666963);
			AirConditioner.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666964);
			AirConditioner.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666965);
			AirConditioner.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666966);
			AirConditioner.NativeMethodInfoPtr_RpcWriter___Server_SetMode_Server_3835190203_Private_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666967);
			AirConditioner.NativeMethodInfoPtr_RpcLogic___SetMode_Server_3835190203_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666968);
			AirConditioner.NativeMethodInfoPtr_RpcReader___Server_SetMode_Server_3835190203_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666969);
			AirConditioner.NativeMethodInfoPtr_sync___get_value__CurrentMode_k__BackingField_Public_get_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666970);
			AirConditioner.NativeMethodInfoPtr_sync___set_value__CurrentMode_k__BackingField_Public_set_Void_EMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666971);
			AirConditioner.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Temperature_AirConditioner_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666972);
			AirConditioner.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr, 100666973);
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x000D611C File Offset: 0x000D431C
		// (set) Token: 0x06001B86 RID: 7046 RVA: 0x000D615C File Offset: 0x000D435C
		public unsafe TemperatureEmitter TemperatureEmitter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_get_TemperatureEmitter_Public_get_TemperatureEmitter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TemperatureEmitter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102128, XrefRangeEnd = 102129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_set_TemperatureEmitter_Private_set_Void_TemperatureEmitter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x000D61A0 File Offset: 0x000D43A0
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x000D61E0 File Offset: 0x000D43E0
		public unsafe TemperatureDisplay TemperatureDisplay
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 102129, RefRangeEnd = 102131, XrefRangeStart = 102129, XrefRangeEnd = 102129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_get_TemperatureDisplay_Public_get_TemperatureDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TemperatureDisplay>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102131, XrefRangeEnd = 102132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_set_TemperatureDisplay_Private_set_Void_TemperatureDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x000D6224 File Offset: 0x000D4424
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x000D6260 File Offset: 0x000D4460
		public unsafe AirConditioner.EMode CurrentMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 102132, RefRangeEnd = 102134, XrefRangeStart = 102132, XrefRangeEnd = 102132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_get_CurrentMode_Public_get_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 102141, RefRangeEnd = 102145, XrefRangeStart = 102134, XrefRangeEnd = 102141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_set_CurrentMode_Private_set_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000D62A0 File Offset: 0x000D44A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102145, XrefRangeEnd = 102148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirConditioner.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000D62DC File Offset: 0x000D44DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102148, XrefRangeEnd = 102189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirConditioner.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000D636C File Offset: 0x000D456C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102189, XrefRangeEnd = 102194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HeatmapVisibilityChanged(Property property, bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_HeatmapVisibilityChanged_Private_Void_Property_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x000D63BC File Offset: 0x000D45BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102194, XrefRangeEnd = 102227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirConditioner.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000D63F8 File Offset: 0x000D45F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102227, XrefRangeEnd = 102228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000D642C File Offset: 0x000D462C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102240, RefRangeEnd = 102241, XrefRangeStart = 102228, XrefRangeEnd = 102240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLoopSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_UpdateLoopSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x000D6460 File Offset: 0x000D4660
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 102264, RefRangeEnd = 102267, XrefRangeStart = 102241, XrefRangeEnd = 102264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMode_Server(AirConditioner.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_SetMode_Server_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000D64A0 File Offset: 0x000D46A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 102269, RefRangeEnd = 102276, XrefRangeStart = 102267, XrefRangeEnd = 102269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMode(AirConditioner.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000D64E0 File Offset: 0x000D46E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 102325, RefRangeEnd = 102331, XrefRangeStart = 102276, XrefRangeEnd = 102325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_ApplyMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000D6514 File Offset: 0x000D4714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102331, XrefRangeEnd = 102334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnModeChanged(AirConditioner.EMode previous, AirConditioner.EMode current, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previous;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_OnModeChanged_Private_Void_EMode_EMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x000D6570 File Offset: 0x000D4770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102334, XrefRangeEnd = 102335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_SetOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x000D65A4 File Offset: 0x000D47A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102335, XrefRangeEnd = 102336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCooling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_SetCooling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x000D65D8 File Offset: 0x000D47D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102336, XrefRangeEnd = 102337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeating()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_SetHeating_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000D660C File Offset: 0x000D480C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102337, XrefRangeEnd = 102341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirConditioner.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr3) : null;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000D6658 File Offset: 0x000D4858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102341, XrefRangeEnd = 102342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AirConditioner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AirConditioner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x000D6694 File Offset: 0x000D4894
		[CallerCount(0)]
		public unsafe float _InitializeGridItem_b__22_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr__InitializeGridItem_b__22_0_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x000D66D0 File Offset: 0x000D48D0
		[CallerCount(0)]
		public unsafe bool _InitializeGridItem_b__22_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr__InitializeGridItem_b__22_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x000D670C File Offset: 0x000D490C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102342, XrefRangeEnd = 102375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirConditioner.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x000D6748 File Offset: 0x000D4948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102375, XrefRangeEnd = 102376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirConditioner.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000D6784 File Offset: 0x000D4984
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirConditioner.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x000D67C0 File Offset: 0x000D49C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102376, XrefRangeEnd = 102386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetMode_Server_3835190203(AirConditioner.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_RpcWriter___Server_SetMode_Server_3835190203_Private_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x000D6800 File Offset: 0x000D4A00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 102269, RefRangeEnd = 102276, XrefRangeStart = 102269, XrefRangeEnd = 102276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetMode_Server_3835190203(AirConditioner.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_RpcLogic___SetMode_Server_3835190203_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x000D6840 File Offset: 0x000D4A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102386, XrefRangeEnd = 102391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetMode_Server_3835190203(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_RpcReader___Server_SetMode_Server_3835190203_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x000D68A4 File Offset: 0x000D4AA4
		// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x000D68E0 File Offset: 0x000D4AE0
		public unsafe AirConditioner.EMode SyncAccessor_<CurrentMode>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 102132, RefRangeEnd = 102134, XrefRangeStart = 102132, XrefRangeEnd = 102134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_sync___get_value__CurrentMode_k__BackingField_Public_get_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102391, XrefRangeEnd = 102399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditioner.NativeMethodInfoPtr_sync___set_value__CurrentMode_k__BackingField_Public_set_Void_EMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000D692C File Offset: 0x000D4B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102399, XrefRangeEnd = 102400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Temperature_AirConditioner(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirConditioner.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Temperature_AirConditioner_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x000D69A0 File Offset: 0x000D4BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102400, XrefRangeEnd = 102403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirConditioner.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0000EFD7 File Offset: 0x0000D1D7
		public AirConditioner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x000D69DC File Offset: 0x000D4BDC
		// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x0000EFE0 File Offset: 0x0000D1E0
		public unsafe static float CoolingTemperature
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AirConditioner.NativeFieldInfoPtr_CoolingTemperature, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AirConditioner.NativeFieldInfoPtr_CoolingTemperature, (void*)(&value));
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x000D69F8 File Offset: 0x000D4BF8
		// (set) Token: 0x06001BAA RID: 7082 RVA: 0x0000EFEE File Offset: 0x0000D1EE
		public unsafe static float HeatingTemperature
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AirConditioner.NativeFieldInfoPtr_HeatingTemperature, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AirConditioner.NativeFieldInfoPtr_HeatingTemperature, (void*)(&value));
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x000D6A14 File Offset: 0x000D4C14
		// (set) Token: 0x06001BAC RID: 7084 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		public unsafe TemperatureEmitter _TemperatureEmitter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__TemperatureEmitter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TemperatureEmitter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__TemperatureEmitter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x000D6A44 File Offset: 0x000D4C44
		// (set) Token: 0x06001BAE RID: 7086 RVA: 0x0000F01B File Offset: 0x0000D21B
		public unsafe TemperatureDisplay _TemperatureDisplay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__TemperatureDisplay_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TemperatureDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__TemperatureDisplay_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x000D6A74 File Offset: 0x000D4C74
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x0000F03A File Offset: 0x0000D23A
		public unsafe Light _coolingLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__coolingLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__coolingLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x000D6AA4 File Offset: 0x000D4CA4
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0000F059 File Offset: 0x0000D259
		public unsafe Light _heatingLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__heatingLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__heatingLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x000D6AD4 File Offset: 0x000D4CD4
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x0000F078 File Offset: 0x0000D278
		public unsafe AudioSourceController _beepSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__beepSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__beepSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x000D6B04 File Offset: 0x000D4D04
		// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x0000F097 File Offset: 0x0000D297
		public unsafe AudioSourceController _loopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__loopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__loopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x000D6B34 File Offset: 0x000D4D34
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x0000F0B6 File Offset: 0x0000D2B6
		public unsafe ParticleSystem _heatParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__heatParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__heatParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x000D6B64 File Offset: 0x000D4D64
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0000F0D5 File Offset: 0x0000D2D5
		public unsafe ParticleSystem _coolParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__coolParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__coolParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x000D6B94 File Offset: 0x000D4D94
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x0000F0F4 File Offset: 0x0000D2F4
		public unsafe AirConditioner.EMode _CurrentMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__CurrentMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr__CurrentMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x000D6BBC File Offset: 0x000D4DBC
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x0000F10F File Offset: 0x0000D30F
		public unsafe SyncVar<AirConditioner.EMode> syncVar____CurrentMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr_syncVar____CurrentMode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<AirConditioner.EMode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr_syncVar____CurrentMode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x000D6BEC File Offset: 0x000D4DEC
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x0000F12E File Offset: 0x0000D32E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x000D6C14 File Offset: 0x000D4E14
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x0000F149 File Offset: 0x0000D349
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditioner.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_CoolingTemperature;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_HeatingTemperature;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr__TemperatureEmitter_k__BackingField;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr__TemperatureDisplay_k__BackingField;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr__coolingLight;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr__heatingLight;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr__beepSound;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeFieldInfoPtr__loopSound;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeFieldInfoPtr__heatParticles;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeFieldInfoPtr__coolParticles;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeFieldInfoPtr__CurrentMode_k__BackingField;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentMode_k__BackingField;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_get_TemperatureEmitter_Public_get_TemperatureEmitter_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_set_TemperatureEmitter_Private_set_Void_TemperatureEmitter_0;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr_get_TemperatureDisplay_Public_get_TemperatureDisplay_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_set_TemperatureDisplay_Private_set_Void_TemperatureDisplay_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMode_Public_get_EMode_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentMode_Private_set_Void_EMode_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_HeatmapVisibilityChanged_Private_Void_Property_Boolean_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLoopSound_Private_Void_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_SetMode_Server_Public_Void_EMode_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_SetMode_Public_Void_EMode_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMode_Private_Void_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_OnModeChanged_Private_Void_EMode_EMode_Boolean_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_SetOff_Public_Void_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_SetCooling_Public_Void_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_SetHeating_Public_Void_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr__InitializeGridItem_b__22_0_Private_Single_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr__InitializeGridItem_b__22_1_Private_Boolean_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetMode_Server_3835190203_Private_Void_EMode_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetMode_Server_3835190203_Public_Void_EMode_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetMode_Server_3835190203_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentMode_k__BackingField_Public_get_EMode_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentMode_k__BackingField_Public_set_Void_EMode_Boolean_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Temperature_AirConditioner_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x0200094A RID: 2378
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x040093AF RID: 37807
			Off,
			// Token: 0x040093B0 RID: 37808
			Cooling,
			// Token: 0x040093B1 RID: 37809
			Heating
		}
	}
}

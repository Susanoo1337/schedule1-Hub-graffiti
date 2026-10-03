using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002D1 RID: 721
	public class ConfigurationReplicator : NetworkBehaviour
	{
		// Token: 0x06003883 RID: 14467 RVA: 0x00137390 File Offset: 0x00135590
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationReplicator()
		{
			Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigurationReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr);
			ConfigurationReplicator.NativeFieldInfoPtr_Configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "Configuration");
			ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted");
			ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted");
			ConfigurationReplicator.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670450);
			ConfigurationReplicator.NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670451);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670452);
			ConfigurationReplicator.NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670453);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670454);
			ConfigurationReplicator.NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670455);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670456);
			ConfigurationReplicator.NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670457);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670458);
			ConfigurationReplicator.NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670459);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670460);
			ConfigurationReplicator.NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670461);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670462);
			ConfigurationReplicator.NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670463);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670464);
			ConfigurationReplicator.NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670465);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670466);
			ConfigurationReplicator.NativeMethodInfoPtr_SendStringField_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670467);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveStringField_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670468);
			ConfigurationReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670469);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670470);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670471);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670472);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670473);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670474);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670475);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670476);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670477);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670478);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670479);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670480);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670481);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670482);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670483);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670484);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670485);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670486);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670487);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670488);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670489);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670490);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670491);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670492);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670493);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670494);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670495);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670496);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670497);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670498);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670499);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670500);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670501);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670502);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670503);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670504);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670505);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670506);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670507);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670508);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670509);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670510);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670511);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670512);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670513);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670514);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670515);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670516);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670517);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670518);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670519);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670520);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendStringField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670521);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendStringField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670522);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendStringField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670523);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveStringField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670524);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveStringField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670525);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveStringField_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670526);
			ConfigurationReplicator.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100670527);
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00137A14 File Offset: 0x00135C14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 145593, RefRangeEnd = 145595, XrefRangeStart = 145279, XrefRangeEnd = 145593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00137A68 File Offset: 0x00135C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145595, XrefRangeEnd = 145607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendItemField(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x00137AB8 File Offset: 0x00135CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145607, XrefRangeEnd = 145619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveItemField(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x00137B08 File Offset: 0x00135D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145619, XrefRangeEnd = 145631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNPCField(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x00137B58 File Offset: 0x00135D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145631, XrefRangeEnd = 145643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveNPCField(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x00137BA8 File Offset: 0x00135DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145643, XrefRangeEnd = 145655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendObjectField(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x00137BF8 File Offset: 0x00135DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145655, XrefRangeEnd = 145667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveObjectField(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x00137C48 File Offset: 0x00135E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145667, XrefRangeEnd = 145679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x00137C98 File Offset: 0x00135E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145679, XrefRangeEnd = 145691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x00137CE8 File Offset: 0x00135EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145691, XrefRangeEnd = 145704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRecipeField(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x00137D34 File Offset: 0x00135F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145704, XrefRangeEnd = 145717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveRecipeField(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x00137D80 File Offset: 0x00135F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145717, XrefRangeEnd = 145729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNumberField(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x00137DCC File Offset: 0x00135FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145729, XrefRangeEnd = 145741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveNumberField(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x00137E18 File Offset: 0x00136018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145741, XrefRangeEnd = 145753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRouteListField(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x00137E68 File Offset: 0x00136068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145753, XrefRangeEnd = 145765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveRouteListField(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x00137EB8 File Offset: 0x001360B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145765, XrefRangeEnd = 145777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendQualityField(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00137F04 File Offset: 0x00136104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145777, XrefRangeEnd = 145789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveQualityField(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x00137F50 File Offset: 0x00136150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145789, XrefRangeEnd = 145801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStringField(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendStringField_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x00137FA0 File Offset: 0x001361A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145801, XrefRangeEnd = 145813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveStringField(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveStringField_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x00137FF0 File Offset: 0x001361F0
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 65655, RefRangeEnd = 65684, XrefRangeStart = 65655, XrefRangeEnd = 65684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x0013802C File Offset: 0x0013622C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145813, XrefRangeEnd = 145923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x00138068 File Offset: 0x00136268
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x001380A4 File Offset: 0x001362A4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x001380E0 File Offset: 0x001362E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x00138130 File Offset: 0x00136330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x00138180 File Offset: 0x00136380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145923, XrefRangeEnd = 145939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendItemField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x001381E4 File Offset: 0x001363E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x00138234 File Offset: 0x00136434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145961, RefRangeEnd = 145962, XrefRangeStart = 145939, XrefRangeEnd = 145961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00138284 File Offset: 0x00136484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145962, XrefRangeEnd = 145967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveItemField_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x001382D4 File Offset: 0x001364D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x00138324 File Offset: 0x00136524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x00138374 File Offset: 0x00136574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145967, XrefRangeEnd = 145983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendNPCField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x001383D8 File Offset: 0x001365D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x00138428 File Offset: 0x00136628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146005, RefRangeEnd = 146006, XrefRangeStart = 145983, XrefRangeEnd = 146005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x00138478 File Offset: 0x00136678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146006, XrefRangeEnd = 146011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveNPCField_1687693739(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x001384C8 File Offset: 0x001366C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x00138518 File Offset: 0x00136718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x00138568 File Offset: 0x00136768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146011, XrefRangeEnd = 146027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendObjectField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x001385CC File Offset: 0x001367CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x0013861C File Offset: 0x0013681C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146049, RefRangeEnd = 146050, XrefRangeStart = 146027, XrefRangeEnd = 146049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x0013866C File Offset: 0x0013686C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146050, XrefRangeEnd = 146055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveObjectField_1687693739(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x001386BC File Offset: 0x001368BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x0013870C File Offset: 0x0013690C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x0013875C File Offset: 0x0013695C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146055, XrefRangeEnd = 146071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendObjectListField_690244341(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x001387C0 File Offset: 0x001369C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x00138810 File Offset: 0x00136A10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146093, RefRangeEnd = 146094, XrefRangeStart = 146071, XrefRangeEnd = 146093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00138860 File Offset: 0x00136A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146094, XrefRangeEnd = 146099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveObjectListField_690244341(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x001388B0 File Offset: 0x00136AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x001388FC File Offset: 0x00136AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00138948 File Offset: 0x00136B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146099, XrefRangeEnd = 146117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRecipeField_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x001389AC File Offset: 0x00136BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x001389F8 File Offset: 0x00136BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146117, XrefRangeEnd = 146138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00138A44 File Offset: 0x00136C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146138, XrefRangeEnd = 146155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveRecipeField_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x00138A94 File Offset: 0x00136C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x00138AE0 File Offset: 0x00136CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00138B2C File Offset: 0x00136D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146155, XrefRangeEnd = 146171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendNumberField_1293284375(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x00138B90 File Offset: 0x00136D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x00138BDC File Offset: 0x00136DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146200, RefRangeEnd = 146201, XrefRangeStart = 146171, XrefRangeEnd = 146200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x00138C28 File Offset: 0x00136E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146201, XrefRangeEnd = 146206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveNumberField_1293284375(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x00138C78 File Offset: 0x00136E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x00138CC8 File Offset: 0x00136EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x00138D18 File Offset: 0x00136F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146206, XrefRangeEnd = 146222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRouteListField_3226448297(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x00138D7C File Offset: 0x00136F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x00138DCC File Offset: 0x00136FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146244, RefRangeEnd = 146245, XrefRangeStart = 146222, XrefRangeEnd = 146244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x00138E1C File Offset: 0x0013701C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146245, XrefRangeEnd = 146250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveRouteListField_3226448297(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x00138E6C File Offset: 0x0013706C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x00138EB8 File Offset: 0x001370B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x00138F04 File Offset: 0x00137104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146250, XrefRangeEnd = 146266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendQualityField_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x00138F68 File Offset: 0x00137168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x00138FB4 File Offset: 0x001371B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146304, RefRangeEnd = 146305, XrefRangeStart = 146266, XrefRangeEnd = 146304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x00139000 File Offset: 0x00137200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146305, XrefRangeEnd = 146310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveQualityField_3536682170(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x00139050 File Offset: 0x00137250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStringField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendStringField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x001390A0 File Offset: 0x001372A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStringField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendStringField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x001390F0 File Offset: 0x001372F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146310, XrefRangeEnd = 146326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStringField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendStringField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x00139154 File Offset: 0x00137354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveStringField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveStringField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x001391A4 File Offset: 0x001373A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146365, RefRangeEnd = 146366, XrefRangeStart = 146326, XrefRangeEnd = 146365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveStringField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveStringField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x001391F4 File Offset: 0x001373F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146366, XrefRangeEnd = 146371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveStringField_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveStringField_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00139244 File Offset: 0x00137444
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x0001CA51 File Offset: 0x0001AC51
		public ConfigurationReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x060038D3 RID: 14547 RVA: 0x00139280 File Offset: 0x00137480
		// (set) Token: 0x060038D4 RID: 14548 RVA: 0x0001CA5A File Offset: 0x0001AC5A
		public unsafe EntityConfiguration Configuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_Configuration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_Configuration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x001392B0 File Offset: 0x001374B0
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x0001CA79 File Offset: 0x0001AC79
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x001392D8 File Offset: 0x001374D8
		// (set) Token: 0x060038D8 RID: 14552 RVA: 0x0001CA94 File Offset: 0x0001AC94
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040025D9 RID: 9689
		private static readonly IntPtr NativeFieldInfoPtr_Configuration;

		// Token: 0x040025DA RID: 9690
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040025DB RID: 9691
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040025DC RID: 9692
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0;

		// Token: 0x040025DD RID: 9693
		private static readonly IntPtr NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0;

		// Token: 0x040025DE RID: 9694
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0;

		// Token: 0x040025DF RID: 9695
		private static readonly IntPtr NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x040025E0 RID: 9696
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x040025E1 RID: 9697
		private static readonly IntPtr NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x040025E2 RID: 9698
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x040025E3 RID: 9699
		private static readonly IntPtr NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x040025E4 RID: 9700
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x040025E5 RID: 9701
		private static readonly IntPtr NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0;

		// Token: 0x040025E6 RID: 9702
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0;

		// Token: 0x040025E7 RID: 9703
		private static readonly IntPtr NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0;

		// Token: 0x040025E8 RID: 9704
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0;

		// Token: 0x040025E9 RID: 9705
		private static readonly IntPtr NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x040025EA RID: 9706
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x040025EB RID: 9707
		private static readonly IntPtr NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0;

		// Token: 0x040025EC RID: 9708
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0;

		// Token: 0x040025ED RID: 9709
		private static readonly IntPtr NativeMethodInfoPtr_SendStringField_Private_Void_Int32_String_0;

		// Token: 0x040025EE RID: 9710
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveStringField_Private_Void_Int32_String_0;

		// Token: 0x040025EF RID: 9711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025F0 RID: 9712
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040025F1 RID: 9713
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040025F2 RID: 9714
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040025F3 RID: 9715
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x040025F4 RID: 9716
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x040025F5 RID: 9717
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040025F6 RID: 9718
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x040025F7 RID: 9719
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x040025F8 RID: 9720
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x040025F9 RID: 9721
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x040025FA RID: 9722
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x040025FB RID: 9723
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040025FC RID: 9724
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x040025FD RID: 9725
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x040025FE RID: 9726
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0;

		// Token: 0x040025FF RID: 9727
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002600 RID: 9728
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002601 RID: 9729
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002602 RID: 9730
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002603 RID: 9731
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002604 RID: 9732
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002605 RID: 9733
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002606 RID: 9734
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002607 RID: 9735
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002608 RID: 9736
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002609 RID: 9737
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x0400260A RID: 9738
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400260B RID: 9739
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x0400260C RID: 9740
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x0400260D RID: 9741
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400260E RID: 9742
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x0400260F RID: 9743
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002610 RID: 9744
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002611 RID: 9745
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002612 RID: 9746
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002613 RID: 9747
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002614 RID: 9748
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002615 RID: 9749
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002616 RID: 9750
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002617 RID: 9751
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002618 RID: 9752
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002619 RID: 9753
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400261D RID: 9757
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x0400261E RID: 9758
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x0400261F RID: 9759
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002620 RID: 9760
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04002621 RID: 9761
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04002622 RID: 9762
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002623 RID: 9763
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStringField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002624 RID: 9764
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendStringField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002625 RID: 9765
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStringField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002626 RID: 9766
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveStringField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002627 RID: 9767
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveStringField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002628 RID: 9768
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveStringField_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002629 RID: 9769
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A26 RID: 2598
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600DEB4 RID: 57012 RVA: 0x0036E4FC File Offset: 0x0036C6FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr);
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9");
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9__1_0");
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9__15_1");
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100670529);
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100670530);
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ReceiveRouteListField_b__15_1_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100670531);
			}

			// Token: 0x0600DEB5 RID: 57013 RVA: 0x0036E5A0 File Offset: 0x0036C7A0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEB6 RID: 57014 RVA: 0x0036E5DC File Offset: 0x0036C7DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144970, XrefRangeEnd = 144972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdvancedTransitRouteData _ReplicateField_b__1_0(AdvancedTransitRoute x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRouteData>(intPtr3) : null;
			}

			// Token: 0x0600DEB7 RID: 57015 RVA: 0x0036E62C File Offset: 0x0036C82C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144972, XrefRangeEnd = 144976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdvancedTransitRoute _ReceiveRouteListField_b__15_1(AdvancedTransitRouteData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ReceiveRouteListField_b__15_1_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr3) : null;
			}

			// Token: 0x0600DEB8 RID: 57016 RVA: 0x00068D7E File Offset: 0x00066F7E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043CF RID: 17359
			// (get) Token: 0x0600DEB9 RID: 57017 RVA: 0x0036E67C File Offset: 0x0036C87C
			// (set) Token: 0x0600DEBA RID: 57018 RVA: 0x00068D87 File Offset: 0x00066F87
			public unsafe static ConfigurationReplicator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D0 RID: 17360
			// (get) Token: 0x0600DEBB RID: 57019 RVA: 0x0036E6A4 File Offset: 0x0036C8A4
			// (set) Token: 0x0600DEBC RID: 57020 RVA: 0x00068D99 File Offset: 0x00066F99
			public unsafe static Func<AdvancedTransitRoute, AdvancedTransitRouteData> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTransitRoute, AdvancedTransitRouteData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D1 RID: 17361
			// (get) Token: 0x0600DEBD RID: 57021 RVA: 0x0036E6CC File Offset: 0x0036C8CC
			// (set) Token: 0x0600DEBE RID: 57022 RVA: 0x00068DAB File Offset: 0x00066FAB
			public unsafe static Func<AdvancedTransitRouteData, AdvancedTransitRoute> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTransitRouteData, AdvancedTransitRoute>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097C0 RID: 38848
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040097C1 RID: 38849
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040097C2 RID: 38850
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x040097C3 RID: 38851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097C4 RID: 38852
			private static readonly IntPtr NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0;

			// Token: 0x040097C5 RID: 38853
			private static readonly IntPtr NativeMethodInfoPtr__ReceiveRouteListField_b__15_1_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0;
		}

		// Token: 0x02000A27 RID: 2599
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600DEBF RID: 57023 RVA: 0x0036E6F4 File Offset: 0x0036C8F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass11_0>.NativeClassPtr);
				ConfigurationReplicator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				ConfigurationReplicator.__c__DisplayClass11_0.NativeFieldInfoPtr_fieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass11_0>.NativeClassPtr, "fieldIndex");
				ConfigurationReplicator.__c__DisplayClass11_0.NativeFieldInfoPtr_recipeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass11_0>.NativeClassPtr, "recipeIndex");
				ConfigurationReplicator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass11_0>.NativeClassPtr, 100670532);
				ConfigurationReplicator.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass11_0>.NativeClassPtr, 100670533);
			}

			// Token: 0x0600DEC0 RID: 57024 RVA: 0x0036E784 File Offset: 0x0036C984
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEC1 RID: 57025 RVA: 0x0036E7C0 File Offset: 0x0036C9C0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 144999, RefRangeEnd = 145001, XrefRangeStart = 144976, XrefRangeEnd = 144999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEC2 RID: 57026 RVA: 0x00068DBD File Offset: 0x00066FBD
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D2 RID: 17362
			// (get) Token: 0x0600DEC3 RID: 57027 RVA: 0x0036E7F4 File Offset: 0x0036C9F4
			// (set) Token: 0x0600DEC4 RID: 57028 RVA: 0x00068DC6 File Offset: 0x00066FC6
			public unsafe ConfigurationReplicator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D3 RID: 17363
			// (get) Token: 0x0600DEC5 RID: 57029 RVA: 0x0036E824 File Offset: 0x0036CA24
			// (set) Token: 0x0600DEC6 RID: 57030 RVA: 0x00068DE5 File Offset: 0x00066FE5
			public unsafe int fieldIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass11_0.NativeFieldInfoPtr_fieldIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass11_0.NativeFieldInfoPtr_fieldIndex)) = value;
				}
			}

			// Token: 0x170043D4 RID: 17364
			// (get) Token: 0x0600DEC7 RID: 57031 RVA: 0x0036E84C File Offset: 0x0036CA4C
			// (set) Token: 0x0600DEC8 RID: 57032 RVA: 0x00068E00 File Offset: 0x00067000
			public unsafe int recipeIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass11_0.NativeFieldInfoPtr_recipeIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass11_0.NativeFieldInfoPtr_recipeIndex)) = value;
				}
			}

			// Token: 0x040097C6 RID: 38854
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097C7 RID: 38855
			private static readonly IntPtr NativeFieldInfoPtr_fieldIndex;

			// Token: 0x040097C8 RID: 38856
			private static readonly IntPtr NativeFieldInfoPtr_recipeIndex;

			// Token: 0x040097C9 RID: 38857
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097CA RID: 38858
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000A28 RID: 2600
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600DEC9 RID: 57033 RVA: 0x0036E874 File Offset: 0x0036CA74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass13_0>.NativeClassPtr);
				ConfigurationReplicator.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				ConfigurationReplicator.__c__DisplayClass13_0.NativeFieldInfoPtr_fieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass13_0>.NativeClassPtr, "fieldIndex");
				ConfigurationReplicator.__c__DisplayClass13_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass13_0>.NativeClassPtr, "value");
				ConfigurationReplicator.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass13_0>.NativeClassPtr, 100670534);
				ConfigurationReplicator.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass13_0>.NativeClassPtr, 100670535);
			}

			// Token: 0x0600DECA RID: 57034 RVA: 0x0036E904 File Offset: 0x0036CB04
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DECB RID: 57035 RVA: 0x0036E940 File Offset: 0x0036CB40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145001, XrefRangeEnd = 145020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DECC RID: 57036 RVA: 0x00068E1B File Offset: 0x0006701B
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D5 RID: 17365
			// (get) Token: 0x0600DECD RID: 57037 RVA: 0x0036E974 File Offset: 0x0036CB74
			// (set) Token: 0x0600DECE RID: 57038 RVA: 0x00068E24 File Offset: 0x00067024
			public unsafe ConfigurationReplicator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D6 RID: 17366
			// (get) Token: 0x0600DECF RID: 57039 RVA: 0x0036E9A4 File Offset: 0x0036CBA4
			// (set) Token: 0x0600DED0 RID: 57040 RVA: 0x00068E43 File Offset: 0x00067043
			public unsafe int fieldIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass13_0.NativeFieldInfoPtr_fieldIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass13_0.NativeFieldInfoPtr_fieldIndex)) = value;
				}
			}

			// Token: 0x170043D7 RID: 17367
			// (get) Token: 0x0600DED1 RID: 57041 RVA: 0x0036E9CC File Offset: 0x0036CBCC
			// (set) Token: 0x0600DED2 RID: 57042 RVA: 0x00068E5E File Offset: 0x0006705E
			public unsafe float value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass13_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass13_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x040097CB RID: 38859
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097CC RID: 38860
			private static readonly IntPtr NativeFieldInfoPtr_fieldIndex;

			// Token: 0x040097CD RID: 38861
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040097CE RID: 38862
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097CF RID: 38863
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000A29 RID: 2601
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x0600DED3 RID: 57043 RVA: 0x0036E9F4 File Offset: 0x0036CBF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass15_0>.NativeClassPtr);
				ConfigurationReplicator.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				ConfigurationReplicator.__c__DisplayClass15_0.NativeFieldInfoPtr_fieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass15_0>.NativeClassPtr, "fieldIndex");
				ConfigurationReplicator.__c__DisplayClass15_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass15_0>.NativeClassPtr, "value");
				ConfigurationReplicator.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass15_0>.NativeClassPtr, 100670536);
				ConfigurationReplicator.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass15_0>.NativeClassPtr, 100670537);
			}

			// Token: 0x0600DED4 RID: 57044 RVA: 0x0036EA84 File Offset: 0x0036CC84
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DED5 RID: 57045 RVA: 0x0036EAC0 File Offset: 0x0036CCC0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 145064, RefRangeEnd = 145065, XrefRangeStart = 145020, XrefRangeEnd = 145064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DED6 RID: 57046 RVA: 0x00068E79 File Offset: 0x00067079
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D8 RID: 17368
			// (get) Token: 0x0600DED7 RID: 57047 RVA: 0x0036EAF4 File Offset: 0x0036CCF4
			// (set) Token: 0x0600DED8 RID: 57048 RVA: 0x00068E82 File Offset: 0x00067082
			public unsafe ConfigurationReplicator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D9 RID: 17369
			// (get) Token: 0x0600DED9 RID: 57049 RVA: 0x0036EB24 File Offset: 0x0036CD24
			// (set) Token: 0x0600DEDA RID: 57050 RVA: 0x00068EA1 File Offset: 0x000670A1
			public unsafe int fieldIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass15_0.NativeFieldInfoPtr_fieldIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass15_0.NativeFieldInfoPtr_fieldIndex)) = value;
				}
			}

			// Token: 0x170043DA RID: 17370
			// (get) Token: 0x0600DEDB RID: 57051 RVA: 0x0036EB4C File Offset: 0x0036CD4C
			// (set) Token: 0x0600DEDC RID: 57052 RVA: 0x00068EBC File Offset: 0x000670BC
			public unsafe Il2CppReferenceArray<AdvancedTransitRouteData> value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass15_0.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AdvancedTransitRouteData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass15_0.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097D0 RID: 38864
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097D1 RID: 38865
			private static readonly IntPtr NativeFieldInfoPtr_fieldIndex;

			// Token: 0x040097D2 RID: 38866
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040097D3 RID: 38867
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097D4 RID: 38868
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000A2A RID: 2602
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600DEDD RID: 57053 RVA: 0x0036EB7C File Offset: 0x0036CD7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass17_0>.NativeClassPtr);
				ConfigurationReplicator.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				ConfigurationReplicator.__c__DisplayClass17_0.NativeFieldInfoPtr_fieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass17_0>.NativeClassPtr, "fieldIndex");
				ConfigurationReplicator.__c__DisplayClass17_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass17_0>.NativeClassPtr, "value");
				ConfigurationReplicator.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass17_0>.NativeClassPtr, 100670538);
				ConfigurationReplicator.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass17_0>.NativeClassPtr, 100670539);
			}

			// Token: 0x0600DEDE RID: 57054 RVA: 0x0036EC0C File Offset: 0x0036CE0C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEDF RID: 57055 RVA: 0x0036EC48 File Offset: 0x0036CE48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145065, XrefRangeEnd = 145084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEE0 RID: 57056 RVA: 0x00068EDB File Offset: 0x000670DB
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043DB RID: 17371
			// (get) Token: 0x0600DEE1 RID: 57057 RVA: 0x0036EC7C File Offset: 0x0036CE7C
			// (set) Token: 0x0600DEE2 RID: 57058 RVA: 0x00068EE4 File Offset: 0x000670E4
			public unsafe ConfigurationReplicator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043DC RID: 17372
			// (get) Token: 0x0600DEE3 RID: 57059 RVA: 0x0036ECAC File Offset: 0x0036CEAC
			// (set) Token: 0x0600DEE4 RID: 57060 RVA: 0x00068F03 File Offset: 0x00067103
			public unsafe int fieldIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass17_0.NativeFieldInfoPtr_fieldIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass17_0.NativeFieldInfoPtr_fieldIndex)) = value;
				}
			}

			// Token: 0x170043DD RID: 17373
			// (get) Token: 0x0600DEE5 RID: 57061 RVA: 0x0036ECD4 File Offset: 0x0036CED4
			// (set) Token: 0x0600DEE6 RID: 57062 RVA: 0x00068F1E File Offset: 0x0006711E
			public unsafe EQuality value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass17_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass17_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x040097D5 RID: 38869
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097D6 RID: 38870
			private static readonly IntPtr NativeFieldInfoPtr_fieldIndex;

			// Token: 0x040097D7 RID: 38871
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040097D8 RID: 38872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097D9 RID: 38873
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000A2B RID: 2603
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x0600DEE7 RID: 57063 RVA: 0x0036ECFC File Offset: 0x0036CEFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass19_0>.NativeClassPtr);
				ConfigurationReplicator.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				ConfigurationReplicator.__c__DisplayClass19_0.NativeFieldInfoPtr_fieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass19_0>.NativeClassPtr, "fieldIndex");
				ConfigurationReplicator.__c__DisplayClass19_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass19_0>.NativeClassPtr, "value");
				ConfigurationReplicator.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass19_0>.NativeClassPtr, 100670540);
				ConfigurationReplicator.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass19_0>.NativeClassPtr, 100670541);
			}

			// Token: 0x0600DEE8 RID: 57064 RVA: 0x0036ED8C File Offset: 0x0036CF8C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEE9 RID: 57065 RVA: 0x0036EDC8 File Offset: 0x0036CFC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145084, XrefRangeEnd = 145103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEEA RID: 57066 RVA: 0x00068F39 File Offset: 0x00067139
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043DE RID: 17374
			// (get) Token: 0x0600DEEB RID: 57067 RVA: 0x0036EDFC File Offset: 0x0036CFFC
			// (set) Token: 0x0600DEEC RID: 57068 RVA: 0x00068F42 File Offset: 0x00067142
			public unsafe ConfigurationReplicator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043DF RID: 17375
			// (get) Token: 0x0600DEED RID: 57069 RVA: 0x0036EE2C File Offset: 0x0036D02C
			// (set) Token: 0x0600DEEE RID: 57070 RVA: 0x00068F61 File Offset: 0x00067161
			public unsafe int fieldIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass19_0.NativeFieldInfoPtr_fieldIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass19_0.NativeFieldInfoPtr_fieldIndex)) = value;
				}
			}

			// Token: 0x170043E0 RID: 17376
			// (get) Token: 0x0600DEEF RID: 57071 RVA: 0x0036EE54 File Offset: 0x0036D054
			// (set) Token: 0x0600DEF0 RID: 57072 RVA: 0x00068F7C File Offset: 0x0006717C
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass19_0.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass19_0.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040097DA RID: 38874
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097DB RID: 38875
			private static readonly IntPtr NativeFieldInfoPtr_fieldIndex;

			// Token: 0x040097DC RID: 38876
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040097DD RID: 38877
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097DE RID: 38878
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000A2C RID: 2604
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600DEF1 RID: 57073 RVA: 0x0036EE7C File Offset: 0x0036D07C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass3_0>.NativeClassPtr);
				ConfigurationReplicator.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				ConfigurationReplicator.__c__DisplayClass3_0.NativeFieldInfoPtr_fieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass3_0>.NativeClassPtr, "fieldIndex");
				ConfigurationReplicator.__c__DisplayClass3_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass3_0>.NativeClassPtr, "value");
				ConfigurationReplicator.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass3_0>.NativeClassPtr, 100670542);
				ConfigurationReplicator.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass3_0>.NativeClassPtr, 100670543);
			}

			// Token: 0x0600DEF2 RID: 57074 RVA: 0x0036EF0C File Offset: 0x0036D10C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEF3 RID: 57075 RVA: 0x0036EF48 File Offset: 0x0036D148
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 145129, RefRangeEnd = 145130, XrefRangeStart = 145103, XrefRangeEnd = 145129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEF4 RID: 57076 RVA: 0x00068F9B File Offset: 0x0006719B
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043E1 RID: 17377
			// (get) Token: 0x0600DEF5 RID: 57077 RVA: 0x0036EF7C File Offset: 0x0036D17C
			// (set) Token: 0x0600DEF6 RID: 57078 RVA: 0x00068FA4 File Offset: 0x000671A4
			public unsafe ConfigurationReplicator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E2 RID: 17378
			// (get) Token: 0x0600DEF7 RID: 57079 RVA: 0x0036EFAC File Offset: 0x0036D1AC
			// (set) Token: 0x0600DEF8 RID: 57080 RVA: 0x00068FC3 File Offset: 0x000671C3
			public unsafe int fieldIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass3_0.NativeFieldInfoPtr_fieldIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass3_0.NativeFieldInfoPtr_fieldIndex)) = value;
				}
			}

			// Token: 0x170043E3 RID: 17379
			// (get) Token: 0x0600DEF9 RID: 57081 RVA: 0x0036EFD4 File Offset: 0x0036D1D4
			// (set) Token: 0x0600DEFA RID: 57082 RVA: 0x00068FDE File Offset: 0x000671DE
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass3_0.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass3_0.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040097DF RID: 38879
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097E0 RID: 38880
			private static readonly IntPtr NativeFieldInfoPtr_fieldIndex;

			// Token: 0x040097E1 RID: 38881
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040097E2 RID: 38882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097E3 RID: 38883
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000A2D RID: 2605
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600DEFB RID: 57083 RVA: 0x0036EFFC File Offset: 0x0036D1FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass5_0>.NativeClassPtr);
				ConfigurationReplicator.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				ConfigurationReplicator.__c__DisplayClass5_0.NativeFieldInfoPtr_fieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass5_0>.NativeClassPtr, "fieldIndex");
				ConfigurationReplicator.__c__DisplayClass5_0.NativeFieldInfoPtr_npcObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass5_0>.NativeClassPtr, "npcObject");
				ConfigurationReplicator.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass5_0>.NativeClassPtr, 100670544);
				ConfigurationReplicator.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass5_0>.NativeClassPtr, 100670545);
			}

			// Token: 0x0600DEFC RID: 57084 RVA: 0x0036F08C File Offset: 0x0036D28C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEFD RID: 57085 RVA: 0x0036F0C8 File Offset: 0x0036D2C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 145159, RefRangeEnd = 145160, XrefRangeStart = 145130, XrefRangeEnd = 145159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEFE RID: 57086 RVA: 0x00068FFD File Offset: 0x000671FD
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043E4 RID: 17380
			// (get) Token: 0x0600DEFF RID: 57087 RVA: 0x0036F0FC File Offset: 0x0036D2FC
			// (set) Token: 0x0600DF00 RID: 57088 RVA: 0x00069006 File Offset: 0x00067206
			public unsafe ConfigurationReplicator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E5 RID: 17381
			// (get) Token: 0x0600DF01 RID: 57089 RVA: 0x0036F12C File Offset: 0x0036D32C
			// (set) Token: 0x0600DF02 RID: 57090 RVA: 0x00069025 File Offset: 0x00067225
			public unsafe int fieldIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass5_0.NativeFieldInfoPtr_fieldIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass5_0.NativeFieldInfoPtr_fieldIndex)) = value;
				}
			}

			// Token: 0x170043E6 RID: 17382
			// (get) Token: 0x0600DF03 RID: 57091 RVA: 0x0036F154 File Offset: 0x0036D354
			// (set) Token: 0x0600DF04 RID: 57092 RVA: 0x00069040 File Offset: 0x00067240
			public unsafe NetworkObject npcObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass5_0.NativeFieldInfoPtr_npcObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass5_0.NativeFieldInfoPtr_npcObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097E4 RID: 38884
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097E5 RID: 38885
			private static readonly IntPtr NativeFieldInfoPtr_fieldIndex;

			// Token: 0x040097E6 RID: 38886
			private static readonly IntPtr NativeFieldInfoPtr_npcObject;

			// Token: 0x040097E7 RID: 38887
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097E8 RID: 38888
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000A2E RID: 2606
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600DF05 RID: 57093 RVA: 0x0036F184 File Offset: 0x0036D384
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass7_0>.NativeClassPtr);
				ConfigurationReplicator.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				ConfigurationReplicator.__c__DisplayClass7_0.NativeFieldInfoPtr_fieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass7_0>.NativeClassPtr, "fieldIndex");
				ConfigurationReplicator.__c__DisplayClass7_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass7_0>.NativeClassPtr, "obj");
				ConfigurationReplicator.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass7_0>.NativeClassPtr, 100670546);
				ConfigurationReplicator.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass7_0>.NativeClassPtr, 100670547);
			}

			// Token: 0x0600DF06 RID: 57094 RVA: 0x0036F214 File Offset: 0x0036D414
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF07 RID: 57095 RVA: 0x0036F250 File Offset: 0x0036D450
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 145214, RefRangeEnd = 145215, XrefRangeStart = 145160, XrefRangeEnd = 145214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF08 RID: 57096 RVA: 0x0006905F File Offset: 0x0006725F
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043E7 RID: 17383
			// (get) Token: 0x0600DF09 RID: 57097 RVA: 0x0036F284 File Offset: 0x0036D484
			// (set) Token: 0x0600DF0A RID: 57098 RVA: 0x00069068 File Offset: 0x00067268
			public unsafe ConfigurationReplicator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E8 RID: 17384
			// (get) Token: 0x0600DF0B RID: 57099 RVA: 0x0036F2B4 File Offset: 0x0036D4B4
			// (set) Token: 0x0600DF0C RID: 57100 RVA: 0x00069087 File Offset: 0x00067287
			public unsafe int fieldIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass7_0.NativeFieldInfoPtr_fieldIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass7_0.NativeFieldInfoPtr_fieldIndex)) = value;
				}
			}

			// Token: 0x170043E9 RID: 17385
			// (get) Token: 0x0600DF0D RID: 57101 RVA: 0x0036F2DC File Offset: 0x0036D4DC
			// (set) Token: 0x0600DF0E RID: 57102 RVA: 0x000690A2 File Offset: 0x000672A2
			public unsafe NetworkObject obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass7_0.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass7_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097E9 RID: 38889
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097EA RID: 38890
			private static readonly IntPtr NativeFieldInfoPtr_fieldIndex;

			// Token: 0x040097EB RID: 38891
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x040097EC RID: 38892
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097ED RID: 38893
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000A2F RID: 2607
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x0600DF0F RID: 57103 RVA: 0x0036F30C File Offset: 0x0036D50C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass9_0>.NativeClassPtr);
				ConfigurationReplicator.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				ConfigurationReplicator.__c__DisplayClass9_0.NativeFieldInfoPtr_fieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass9_0>.NativeClassPtr, "fieldIndex");
				ConfigurationReplicator.__c__DisplayClass9_0.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass9_0>.NativeClassPtr, "objects");
				ConfigurationReplicator.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass9_0>.NativeClassPtr, 100670548);
				ConfigurationReplicator.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass9_0>.NativeClassPtr, 100670549);
			}

			// Token: 0x0600DF10 RID: 57104 RVA: 0x0036F39C File Offset: 0x0036D59C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF11 RID: 57105 RVA: 0x0036F3D8 File Offset: 0x0036D5D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 145278, RefRangeEnd = 145279, XrefRangeStart = 145215, XrefRangeEnd = 145278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF12 RID: 57106 RVA: 0x000690C1 File Offset: 0x000672C1
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043EA RID: 17386
			// (get) Token: 0x0600DF13 RID: 57107 RVA: 0x0036F40C File Offset: 0x0036D60C
			// (set) Token: 0x0600DF14 RID: 57108 RVA: 0x000690CA File Offset: 0x000672CA
			public unsafe ConfigurationReplicator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043EB RID: 17387
			// (get) Token: 0x0600DF15 RID: 57109 RVA: 0x0036F43C File Offset: 0x0036D63C
			// (set) Token: 0x0600DF16 RID: 57110 RVA: 0x000690E9 File Offset: 0x000672E9
			public unsafe int fieldIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass9_0.NativeFieldInfoPtr_fieldIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass9_0.NativeFieldInfoPtr_fieldIndex)) = value;
				}
			}

			// Token: 0x170043EC RID: 17388
			// (get) Token: 0x0600DF17 RID: 57111 RVA: 0x0036F464 File Offset: 0x0036D664
			// (set) Token: 0x0600DF18 RID: 57112 RVA: 0x00069104 File Offset: 0x00067304
			public unsafe List<NetworkObject> objects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass9_0.NativeFieldInfoPtr_objects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NetworkObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.__c__DisplayClass9_0.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097EE RID: 38894
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097EF RID: 38895
			private static readonly IntPtr NativeFieldInfoPtr_fieldIndex;

			// Token: 0x040097F0 RID: 38896
			private static readonly IntPtr NativeFieldInfoPtr_objects;

			// Token: 0x040097F1 RID: 38897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097F2 RID: 38898
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}
	}
}

using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x0200037A RID: 890
	public class ToggleableSurfaceItem : SurfaceItem
	{
		// Token: 0x06004CC5 RID: 19653 RVA: 0x001825A0 File Offset: 0x001807A0
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableSurfaceItem()
		{
			Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "ToggleableSurfaceItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr);
			ToggleableSurfaceItem.NativeFieldInfoPtr__IsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "<IsOn>k__BackingField");
			ToggleableSurfaceItem.NativeFieldInfoPtr_StartupAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "StartupAction");
			ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "onTurnedOn");
			ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "onTurnedOff");
			ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnOnOrOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "onTurnOnOrOff");
			ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted");
			ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted");
			ToggleableSurfaceItem.NativeMethodInfoPtr_get_IsOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673230);
			ToggleableSurfaceItem.NativeMethodInfoPtr_set_IsOn_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673231);
			ToggleableSurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673232);
			ToggleableSurfaceItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673233);
			ToggleableSurfaceItem.NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673234);
			ToggleableSurfaceItem.NativeMethodInfoPtr_TurnOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673235);
			ToggleableSurfaceItem.NativeMethodInfoPtr_TurnOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673236);
			ToggleableSurfaceItem.NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673237);
			ToggleableSurfaceItem.NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673238);
			ToggleableSurfaceItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673239);
			ToggleableSurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673240);
			ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673241);
			ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673242);
			ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673243);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673244);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673245);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673246);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673247);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673248);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673249);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673250);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673251);
			ToggleableSurfaceItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100673252);
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x00182828 File Offset: 0x00180A28
		// (set) Token: 0x06004CC7 RID: 19655 RVA: 0x00182864 File Offset: 0x00180A64
		public unsafe bool IsOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_get_IsOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_set_IsOn_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x001828A4 File Offset: 0x00180AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174258, XrefRangeEnd = 174262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x001828E0 File Offset: 0x00180AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174262, XrefRangeEnd = 174264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x00182930 File Offset: 0x00180B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174264, XrefRangeEnd = 174267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Toggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x00182964 File Offset: 0x00180B64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 174270, RefRangeEnd = 174274, XrefRangeStart = 174267, XrefRangeEnd = 174270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOn(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_TurnOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x001829A4 File Offset: 0x00180BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174274, XrefRangeEnd = 174278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOff(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_TurnOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x001829E4 File Offset: 0x00180BE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 174300, RefRangeEnd = 174306, XrefRangeStart = 174278, XrefRangeEnd = 174300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendIsOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x00182A24 File Offset: 0x00180C24
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 174347, RefRangeEnd = 174353, XrefRangeStart = 174306, XrefRangeEnd = 174347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x00182A74 File Offset: 0x00180C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174353, XrefRangeEnd = 174358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr3) : null;
		}

		// Token: 0x06004CD0 RID: 19664 RVA: 0x00182AC0 File Offset: 0x00180CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174358, XrefRangeEnd = 174359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableSurfaceItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x00182AFC File Offset: 0x00180CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174359, XrefRangeEnd = 174380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x00182B38 File Offset: 0x00180D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174380, XrefRangeEnd = 174381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD3 RID: 19667 RVA: 0x00182B74 File Offset: 0x00180D74
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD4 RID: 19668 RVA: 0x00182BB0 File Offset: 0x00180DB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174391, RefRangeEnd = 174393, XrefRangeStart = 174381, XrefRangeEnd = 174391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendIsOn_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x00182BF0 File Offset: 0x00180DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174393, XrefRangeEnd = 174394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendIsOn_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x00182C30 File Offset: 0x00180E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174394, XrefRangeEnd = 174397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD7 RID: 19671 RVA: 0x00182C94 File Offset: 0x00180E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174397, XrefRangeEnd = 174407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD8 RID: 19672 RVA: 0x00182CE4 File Offset: 0x00180EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174407, XrefRangeEnd = 174410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x00182D34 File Offset: 0x00180F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174410, XrefRangeEnd = 174414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x00182D84 File Offset: 0x00180F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174414, XrefRangeEnd = 174424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CDB RID: 19675 RVA: 0x00182DD4 File Offset: 0x00180FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174424, XrefRangeEnd = 174428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x00182E24 File Offset: 0x00181024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174428, XrefRangeEnd = 174432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x00024D30 File Offset: 0x00022F30
		public ToggleableSurfaceItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06004CDE RID: 19678 RVA: 0x00182E60 File Offset: 0x00181060
		// (set) Token: 0x06004CDF RID: 19679 RVA: 0x00024D39 File Offset: 0x00022F39
		public unsafe bool _IsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr__IsOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr__IsOn_k__BackingField)) = value;
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x00182E88 File Offset: 0x00181088
		// (set) Token: 0x06004CE1 RID: 19681 RVA: 0x00024D54 File Offset: 0x00022F54
		public unsafe ToggleableSurfaceItem.EStartupAction StartupAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_StartupAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_StartupAction)) = value;
			}
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x00182EB0 File Offset: 0x001810B0
		// (set) Token: 0x06004CE3 RID: 19683 RVA: 0x00024D6F File Offset: 0x00022F6F
		public unsafe UnityEvent onTurnedOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06004CE4 RID: 19684 RVA: 0x00182EE0 File Offset: 0x001810E0
		// (set) Token: 0x06004CE5 RID: 19685 RVA: 0x00024D8E File Offset: 0x00022F8E
		public unsafe UnityEvent onTurnedOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06004CE6 RID: 19686 RVA: 0x00182F10 File Offset: 0x00181110
		// (set) Token: 0x06004CE7 RID: 19687 RVA: 0x00024DAD File Offset: 0x00022FAD
		public unsafe UnityEvent onTurnOnOrOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnOnOrOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnOnOrOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06004CE8 RID: 19688 RVA: 0x00182F40 File Offset: 0x00181140
		// (set) Token: 0x06004CE9 RID: 19689 RVA: 0x00024DCC File Offset: 0x00022FCC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06004CEA RID: 19690 RVA: 0x00182F68 File Offset: 0x00181168
		// (set) Token: 0x06004CEB RID: 19691 RVA: 0x00024DE7 File Offset: 0x00022FE7
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400347B RID: 13435
		private static readonly IntPtr NativeFieldInfoPtr__IsOn_k__BackingField;

		// Token: 0x0400347C RID: 13436
		private static readonly IntPtr NativeFieldInfoPtr_StartupAction;

		// Token: 0x0400347D RID: 13437
		private static readonly IntPtr NativeFieldInfoPtr_onTurnedOn;

		// Token: 0x0400347E RID: 13438
		private static readonly IntPtr NativeFieldInfoPtr_onTurnedOff;

		// Token: 0x0400347F RID: 13439
		private static readonly IntPtr NativeFieldInfoPtr_onTurnOnOrOff;

		// Token: 0x04003480 RID: 13440
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003481 RID: 13441
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003482 RID: 13442
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOn_Public_get_Boolean_0;

		// Token: 0x04003483 RID: 13443
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOn_Private_set_Void_Boolean_0;

		// Token: 0x04003484 RID: 13444
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003485 RID: 13445
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003486 RID: 13446
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;

		// Token: 0x04003487 RID: 13447
		private static readonly IntPtr NativeMethodInfoPtr_TurnOn_Public_Void_Boolean_0;

		// Token: 0x04003488 RID: 13448
		private static readonly IntPtr NativeMethodInfoPtr_TurnOff_Public_Void_Boolean_0;

		// Token: 0x04003489 RID: 13449
		private static readonly IntPtr NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0;

		// Token: 0x0400348A RID: 13450
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x0400348B RID: 13451
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x0400348C RID: 13452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400348D RID: 13453
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400348E RID: 13454
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400348F RID: 13455
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003490 RID: 13456
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003491 RID: 13457
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003492 RID: 13458
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003493 RID: 13459
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003494 RID: 13460
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003495 RID: 13461
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003496 RID: 13462
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003497 RID: 13463
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003498 RID: 13464
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A82 RID: 2690
		[OriginalName("Assembly-CSharp.dll", "", "EStartupAction")]
		public enum EStartupAction
		{
			// Token: 0x04009996 RID: 39318
			None,
			// Token: 0x04009997 RID: 39319
			TurnOn,
			// Token: 0x04009998 RID: 39320
			TurnOff,
			// Token: 0x04009999 RID: 39321
			Toggle
		}
	}
}

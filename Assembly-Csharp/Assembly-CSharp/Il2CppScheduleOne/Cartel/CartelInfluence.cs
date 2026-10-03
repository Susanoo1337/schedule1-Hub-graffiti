using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x0200044F RID: 1103
	public class CartelInfluence : NetworkBehaviour
	{
		// Token: 0x06006414 RID: 25620 RVA: 0x001D62E8 File Offset: 0x001D44E8
		// Note: this type is marked as 'beforefieldinit'.
		static CartelInfluence()
		{
			Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelInfluence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr);
			CartelInfluence.NativeFieldInfoPtr_INFLUENCE_TO_UNLOCK_NEXT_REGION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, "INFLUENCE_TO_UNLOCK_NEXT_REGION");
			CartelInfluence.NativeFieldInfoPtr_WESTVILLE_MAX_INFLUENCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, "WESTVILLE_MAX_INFLUENCE");
			CartelInfluence.NativeFieldInfoPtr_DefaultRegionInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, "DefaultRegionInfluence");
			CartelInfluence.NativeFieldInfoPtr_regionInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, "regionInfluence");
			CartelInfluence.NativeFieldInfoPtr_OnInfluenceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, "OnInfluenceChanged");
			CartelInfluence.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Cartel.CartelInfluenceAssembly-CSharp.dll_Excuted");
			CartelInfluence.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Cartel.CartelInfluenceAssembly-CSharp.dll_Excuted");
			CartelInfluence.NativeMethodInfoPtr_GetAllRegionInfluence_Public_Il2CppReferenceArray_1_RegionInfluenceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676450);
			CartelInfluence.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676451);
			CartelInfluence.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676452);
			CartelInfluence.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676453);
			CartelInfluence.NativeMethodInfoPtr_ChangeInfluence_Public_Void_EMapRegion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676454);
			CartelInfluence.NativeMethodInfoPtr_SetInfluence_Public_Void_NetworkConnection_EMapRegion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676455);
			CartelInfluence.NativeMethodInfoPtr_GetInfluence_Public_Single_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676456);
			CartelInfluence.NativeMethodInfoPtr_ChangeInfluence_Private_Void_EMapRegion_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676457);
			CartelInfluence.NativeMethodInfoPtr_GetRegionData_Private_RegionInfluenceData_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676458);
			CartelInfluence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676459);
			CartelInfluence.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676460);
			CartelInfluence.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676461);
			CartelInfluence.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676462);
			CartelInfluence.NativeMethodInfoPtr_RpcWriter___Server_ChangeInfluence_2792544924_Private_Void_EMapRegion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676463);
			CartelInfluence.NativeMethodInfoPtr_RpcLogic___ChangeInfluence_2792544924_Public_Void_EMapRegion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676464);
			CartelInfluence.NativeMethodInfoPtr_RpcReader___Server_ChangeInfluence_2792544924_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676465);
			CartelInfluence.NativeMethodInfoPtr_RpcWriter___Observers_SetInfluence_2071772313_Private_Void_NetworkConnection_EMapRegion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676466);
			CartelInfluence.NativeMethodInfoPtr_RpcLogic___SetInfluence_2071772313_Public_Void_NetworkConnection_EMapRegion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676467);
			CartelInfluence.NativeMethodInfoPtr_RpcReader___Observers_SetInfluence_2071772313_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676468);
			CartelInfluence.NativeMethodInfoPtr_RpcWriter___Target_SetInfluence_2071772313_Private_Void_NetworkConnection_EMapRegion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676469);
			CartelInfluence.NativeMethodInfoPtr_RpcReader___Target_SetInfluence_2071772313_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676470);
			CartelInfluence.NativeMethodInfoPtr_RpcWriter___Observers_ChangeInfluence_1267088319_Private_Void_EMapRegion_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676471);
			CartelInfluence.NativeMethodInfoPtr_RpcLogic___ChangeInfluence_1267088319_Private_Void_EMapRegion_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676472);
			CartelInfluence.NativeMethodInfoPtr_RpcReader___Observers_ChangeInfluence_1267088319_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676473);
			CartelInfluence.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, 100676474);
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x001D6598 File Offset: 0x001D4798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210330, XrefRangeEnd = 210334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<CartelInfluence.RegionInfluenceData> GetAllRegionInfluence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_GetAllRegionInfluence_Public_Il2CppReferenceArray_1_RegionInfluenceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CartelInfluence.RegionInfluenceData>>(intPtr3) : null;
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x001D65D8 File Offset: 0x001D47D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210334, XrefRangeEnd = 210347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelInfluence.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x001D6614 File Offset: 0x001D4814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210347, XrefRangeEnd = 210364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelInfluence.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x001D6664 File Offset: 0x001D4864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210364, XrefRangeEnd = 210406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelInfluence.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x001D66A0 File Offset: 0x001D48A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210417, RefRangeEnd = 210424, XrefRangeStart = 210406, XrefRangeEnd = 210417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeInfluence(EMapRegion region, float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_ChangeInfluence_Public_Void_EMapRegion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x001D66EC File Offset: 0x001D48EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210465, RefRangeEnd = 210467, XrefRangeStart = 210424, XrefRangeEnd = 210465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInfluence(NetworkConnection conn, EMapRegion region, float influence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref region;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref influence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_SetInfluence_Public_Void_NetworkConnection_EMapRegion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x001D674C File Offset: 0x001D494C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210468, RefRangeEnd = 210470, XrefRangeStart = 210467, XrefRangeEnd = 210468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInfluence(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_GetInfluence_Public_Single_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x001D6798 File Offset: 0x001D4998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210470, XrefRangeEnd = 210494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeInfluence(EMapRegion region, float oldInfluence, float newInfluence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldInfluence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newInfluence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_ChangeInfluence_Private_Void_EMapRegion_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x001D67F4 File Offset: 0x001D49F4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 210508, RefRangeEnd = 210520, XrefRangeStart = 210494, XrefRangeEnd = 210508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelInfluence.RegionInfluenceData GetRegionData(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_GetRegionData_Private_RegionInfluenceData_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CartelInfluence.RegionInfluenceData>(intPtr3) : null;
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x001D6840 File Offset: 0x001D4A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210520, XrefRangeEnd = 210528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelInfluence() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x001D687C File Offset: 0x001D4A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210528, XrefRangeEnd = 210554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelInfluence.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x001D68B8 File Offset: 0x001D4AB8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelInfluence.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006421 RID: 25633 RVA: 0x001D68F4 File Offset: 0x001D4AF4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelInfluence.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x001D6930 File Offset: 0x001D4B30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210417, RefRangeEnd = 210424, XrefRangeStart = 210417, XrefRangeEnd = 210424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeInfluence_2792544924(EMapRegion region, float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcWriter___Server_ChangeInfluence_2792544924_Private_Void_EMapRegion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x001D697C File Offset: 0x001D4B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210579, RefRangeEnd = 210580, XrefRangeStart = 210554, XrefRangeEnd = 210579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeInfluence_2792544924(EMapRegion region, float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcLogic___ChangeInfluence_2792544924_Public_Void_EMapRegion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x001D69C8 File Offset: 0x001D4BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210580, XrefRangeEnd = 210584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeInfluence_2792544924(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcReader___Server_ChangeInfluence_2792544924_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x001D6A2C File Offset: 0x001D4C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210584, XrefRangeEnd = 210595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref region;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref influence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcWriter___Observers_SetInfluence_2071772313_Private_Void_NetworkConnection_EMapRegion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x001D6A8C File Offset: 0x001D4C8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210606, RefRangeEnd = 210609, XrefRangeStart = 210595, XrefRangeEnd = 210606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref region;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref influence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcLogic___SetInfluence_2071772313_Public_Void_NetworkConnection_EMapRegion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x001D6AEC File Offset: 0x001D4CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210609, XrefRangeEnd = 210614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetInfluence_2071772313(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcReader___Observers_SetInfluence_2071772313_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x001D6B3C File Offset: 0x001D4D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210614, XrefRangeEnd = 210625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref region;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref influence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcWriter___Target_SetInfluence_2071772313_Private_Void_NetworkConnection_EMapRegion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006429 RID: 25641 RVA: 0x001D6B9C File Offset: 0x001D4D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210625, XrefRangeEnd = 210630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetInfluence_2071772313(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcReader___Target_SetInfluence_2071772313_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600642A RID: 25642 RVA: 0x001D6BEC File Offset: 0x001D4DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210630, XrefRangeEnd = 210642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ChangeInfluence_1267088319(EMapRegion region, float oldInfluence, float newInfluence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldInfluence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newInfluence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcWriter___Observers_ChangeInfluence_1267088319_Private_Void_EMapRegion_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600642B RID: 25643 RVA: 0x001D6C48 File Offset: 0x001D4E48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210664, RefRangeEnd = 210667, XrefRangeStart = 210642, XrefRangeEnd = 210664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeInfluence_1267088319(EMapRegion region, float oldInfluence, float newInfluence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldInfluence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newInfluence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcLogic___ChangeInfluence_1267088319_Private_Void_EMapRegion_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600642C RID: 25644 RVA: 0x001D6CA4 File Offset: 0x001D4EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210667, XrefRangeEnd = 210673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ChangeInfluence_1267088319(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_RpcReader___Observers_ChangeInfluence_1267088319_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600642D RID: 25645 RVA: 0x001D6CF4 File Offset: 0x001D4EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210673, XrefRangeEnd = 210684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600642E RID: 25646 RVA: 0x0002F274 File Offset: 0x0002D474
		public CartelInfluence(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x001D6D28 File Offset: 0x001D4F28
		// (set) Token: 0x06006430 RID: 25648 RVA: 0x0002F27D File Offset: 0x0002D47D
		public unsafe static float INFLUENCE_TO_UNLOCK_NEXT_REGION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CartelInfluence.NativeFieldInfoPtr_INFLUENCE_TO_UNLOCK_NEXT_REGION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelInfluence.NativeFieldInfoPtr_INFLUENCE_TO_UNLOCK_NEXT_REGION, (void*)(&value));
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06006431 RID: 25649 RVA: 0x001D6D44 File Offset: 0x001D4F44
		// (set) Token: 0x06006432 RID: 25650 RVA: 0x0002F28B File Offset: 0x0002D48B
		public unsafe static float WESTVILLE_MAX_INFLUENCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CartelInfluence.NativeFieldInfoPtr_WESTVILLE_MAX_INFLUENCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelInfluence.NativeFieldInfoPtr_WESTVILLE_MAX_INFLUENCE, (void*)(&value));
			}
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x06006433 RID: 25651 RVA: 0x001D6D60 File Offset: 0x001D4F60
		// (set) Token: 0x06006434 RID: 25652 RVA: 0x0002F299 File Offset: 0x0002D499
		public unsafe Il2CppReferenceArray<CartelInfluence.RegionInfluenceData> DefaultRegionInfluence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.NativeFieldInfoPtr_DefaultRegionInfluence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CartelInfluence.RegionInfluenceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.NativeFieldInfoPtr_DefaultRegionInfluence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x06006435 RID: 25653 RVA: 0x001D6D90 File Offset: 0x001D4F90
		// (set) Token: 0x06006436 RID: 25654 RVA: 0x0002F2B8 File Offset: 0x0002D4B8
		public unsafe List<CartelInfluence.RegionInfluenceData> regionInfluence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.NativeFieldInfoPtr_regionInfluence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartelInfluence.RegionInfluenceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.NativeFieldInfoPtr_regionInfluence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06006437 RID: 25655 RVA: 0x001D6DC0 File Offset: 0x001D4FC0
		// (set) Token: 0x06006438 RID: 25656 RVA: 0x0002F2D7 File Offset: 0x0002D4D7
		public unsafe Action<EMapRegion, float, float> OnInfluenceChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.NativeFieldInfoPtr_OnInfluenceChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<EMapRegion, float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.NativeFieldInfoPtr_OnInfluenceChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06006439 RID: 25657 RVA: 0x001D6DF0 File Offset: 0x001D4FF0
		// (set) Token: 0x0600643A RID: 25658 RVA: 0x0002F2F6 File Offset: 0x0002D4F6
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x0600643B RID: 25659 RVA: 0x001D6E18 File Offset: 0x001D5018
		// (set) Token: 0x0600643C RID: 25660 RVA: 0x0002F311 File Offset: 0x0002D511
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004501 RID: 17665
		private static readonly IntPtr NativeFieldInfoPtr_INFLUENCE_TO_UNLOCK_NEXT_REGION;

		// Token: 0x04004502 RID: 17666
		private static readonly IntPtr NativeFieldInfoPtr_WESTVILLE_MAX_INFLUENCE;

		// Token: 0x04004503 RID: 17667
		private static readonly IntPtr NativeFieldInfoPtr_DefaultRegionInfluence;

		// Token: 0x04004504 RID: 17668
		private static readonly IntPtr NativeFieldInfoPtr_regionInfluence;

		// Token: 0x04004505 RID: 17669
		private static readonly IntPtr NativeFieldInfoPtr_OnInfluenceChanged;

		// Token: 0x04004506 RID: 17670
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004507 RID: 17671
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004508 RID: 17672
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRegionInfluence_Public_Il2CppReferenceArray_1_RegionInfluenceData_0;

		// Token: 0x04004509 RID: 17673
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400450A RID: 17674
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400450B RID: 17675
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x0400450C RID: 17676
		private static readonly IntPtr NativeMethodInfoPtr_ChangeInfluence_Public_Void_EMapRegion_Single_0;

		// Token: 0x0400450D RID: 17677
		private static readonly IntPtr NativeMethodInfoPtr_SetInfluence_Public_Void_NetworkConnection_EMapRegion_Single_0;

		// Token: 0x0400450E RID: 17678
		private static readonly IntPtr NativeMethodInfoPtr_GetInfluence_Public_Single_EMapRegion_0;

		// Token: 0x0400450F RID: 17679
		private static readonly IntPtr NativeMethodInfoPtr_ChangeInfluence_Private_Void_EMapRegion_Single_Single_0;

		// Token: 0x04004510 RID: 17680
		private static readonly IntPtr NativeMethodInfoPtr_GetRegionData_Private_RegionInfluenceData_EMapRegion_0;

		// Token: 0x04004511 RID: 17681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004512 RID: 17682
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004513 RID: 17683
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004514 RID: 17684
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004515 RID: 17685
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeInfluence_2792544924_Private_Void_EMapRegion_Single_0;

		// Token: 0x04004516 RID: 17686
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeInfluence_2792544924_Public_Void_EMapRegion_Single_0;

		// Token: 0x04004517 RID: 17687
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeInfluence_2792544924_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004518 RID: 17688
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetInfluence_2071772313_Private_Void_NetworkConnection_EMapRegion_Single_0;

		// Token: 0x04004519 RID: 17689
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetInfluence_2071772313_Public_Void_NetworkConnection_EMapRegion_Single_0;

		// Token: 0x0400451A RID: 17690
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetInfluence_2071772313_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400451B RID: 17691
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetInfluence_2071772313_Private_Void_NetworkConnection_EMapRegion_Single_0;

		// Token: 0x0400451C RID: 17692
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetInfluence_2071772313_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400451D RID: 17693
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ChangeInfluence_1267088319_Private_Void_EMapRegion_Single_Single_0;

		// Token: 0x0400451E RID: 17694
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeInfluence_1267088319_Private_Void_EMapRegion_Single_Single_0;

		// Token: 0x0400451F RID: 17695
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ChangeInfluence_1267088319_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004520 RID: 17696
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000B3D RID: 2877
		[Serializable]
		public class RegionInfluenceData : Object
		{
			// Token: 0x0600E6E2 RID: 59106 RVA: 0x00385088 File Offset: 0x00383288
			// Note: this type is marked as 'beforefieldinit'.
			static RegionInfluenceData()
			{
				Il2CppClassPointerStore<CartelInfluence.RegionInfluenceData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, "RegionInfluenceData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelInfluence.RegionInfluenceData>.NativeClassPtr);
				CartelInfluence.RegionInfluenceData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence.RegionInfluenceData>.NativeClassPtr, "name");
				CartelInfluence.RegionInfluenceData.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence.RegionInfluenceData>.NativeClassPtr, "Region");
				CartelInfluence.RegionInfluenceData.NativeFieldInfoPtr_Influence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence.RegionInfluenceData>.NativeClassPtr, "Influence");
				CartelInfluence.RegionInfluenceData.NativeMethodInfoPtr__ctor_Public_Void_EMapRegion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence.RegionInfluenceData>.NativeClassPtr, 100676475);
			}

			// Token: 0x0600E6E3 RID: 59107 RVA: 0x00385104 File Offset: 0x00383304
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 210328, RefRangeEnd = 210330, XrefRangeStart = 210323, XrefRangeEnd = 210328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RegionInfluenceData(EMapRegion region, float influence = 0f) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelInfluence.RegionInfluenceData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref region;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref influence;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.RegionInfluenceData.NativeMethodInfoPtr__ctor_Public_Void_EMapRegion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6E4 RID: 59108 RVA: 0x0006CE50 File Offset: 0x0006B050
			public RegionInfluenceData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004612 RID: 17938
			// (get) Token: 0x0600E6E5 RID: 59109 RVA: 0x0038515C File Offset: 0x0038335C
			// (set) Token: 0x0600E6E6 RID: 59110 RVA: 0x0006CE59 File Offset: 0x0006B059
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.RegionInfluenceData.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.RegionInfluenceData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004613 RID: 17939
			// (get) Token: 0x0600E6E7 RID: 59111 RVA: 0x00385184 File Offset: 0x00383384
			// (set) Token: 0x0600E6E8 RID: 59112 RVA: 0x0006CE78 File Offset: 0x0006B078
			public unsafe EMapRegion Region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.RegionInfluenceData.NativeFieldInfoPtr_Region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.RegionInfluenceData.NativeFieldInfoPtr_Region)) = value;
				}
			}

			// Token: 0x17004614 RID: 17940
			// (get) Token: 0x0600E6E9 RID: 59113 RVA: 0x003851AC File Offset: 0x003833AC
			// (set) Token: 0x0600E6EA RID: 59114 RVA: 0x0006CE93 File Offset: 0x0006B093
			public unsafe float Influence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.RegionInfluenceData.NativeFieldInfoPtr_Influence);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.RegionInfluenceData.NativeFieldInfoPtr_Influence)) = value;
				}
			}

			// Token: 0x04009CBB RID: 40123
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04009CBC RID: 40124
			private static readonly IntPtr NativeFieldInfoPtr_Region;

			// Token: 0x04009CBD RID: 40125
			private static readonly IntPtr NativeFieldInfoPtr_Influence;

			// Token: 0x04009CBE RID: 40126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EMapRegion_Single_0;
		}

		// Token: 0x02000B3E RID: 2878
		[ObfuscatedName("ScheduleOne.Cartel.CartelInfluence+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600E6EB RID: 59115 RVA: 0x003851D4 File Offset: 0x003833D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<CartelInfluence.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelInfluence>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelInfluence.__c__DisplayClass14_0>.NativeClassPtr);
				CartelInfluence.__c__DisplayClass14_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluence.__c__DisplayClass14_0>.NativeClassPtr, "region");
				CartelInfluence.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence.__c__DisplayClass14_0>.NativeClassPtr, 100676476);
				CartelInfluence.__c__DisplayClass14_0.NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_RegionInfluenceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluence.__c__DisplayClass14_0>.NativeClassPtr, 100676477);
			}

			// Token: 0x0600E6EC RID: 59116 RVA: 0x0038523C File Offset: 0x0038343C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelInfluence.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6ED RID: 59117 RVA: 0x00385278 File Offset: 0x00383478
			[CallerCount(0)]
			public unsafe bool _GetRegionData_b__0(CartelInfluence.RegionInfluenceData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluence.__c__DisplayClass14_0.NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_RegionInfluenceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6EE RID: 59118 RVA: 0x0006CEAE File Offset: 0x0006B0AE
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004615 RID: 17941
			// (get) Token: 0x0600E6EF RID: 59119 RVA: 0x003852C8 File Offset: 0x003834C8
			// (set) Token: 0x0600E6F0 RID: 59120 RVA: 0x0006CEB7 File Offset: 0x0006B0B7
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.__c__DisplayClass14_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluence.__c__DisplayClass14_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x04009CBF RID: 40127
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x04009CC0 RID: 40128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CC1 RID: 40129
			private static readonly IntPtr NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_RegionInfluenceData_0;
		}
	}
}

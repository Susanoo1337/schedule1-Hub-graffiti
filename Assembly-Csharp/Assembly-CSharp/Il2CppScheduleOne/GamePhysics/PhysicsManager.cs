using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.GamePhysics
{
	// Token: 0x020001A9 RID: 425
	public class PhysicsManager : NetworkSingleton<PhysicsManager>
	{
		// Token: 0x06002A78 RID: 10872 RVA: 0x00107404 File Offset: 0x00105604
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsManager()
		{
			Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GamePhysics", "PhysicsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr);
			PhysicsManager.NativeFieldInfoPtr_AutoSyncTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, "AutoSyncTransforms");
			PhysicsManager.NativeFieldInfoPtr__GravityMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, "<GravityMultiplier>k__BackingField");
			PhysicsManager.NativeFieldInfoPtr__GroundDetectionLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, "<GroundDetectionLayerMask>k__BackingField");
			PhysicsManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.GamePhysics.PhysicsManagerAssembly-CSharp.dll_Excuted");
			PhysicsManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.GamePhysics.PhysicsManagerAssembly-CSharp.dll_Excuted");
			PhysicsManager.NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668717);
			PhysicsManager.NativeMethodInfoPtr_set_GravityMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668718);
			PhysicsManager.NativeMethodInfoPtr_get_GroundDetectionLayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668719);
			PhysicsManager.NativeMethodInfoPtr_set_GroundDetectionLayerMask_Private_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668720);
			PhysicsManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668721);
			PhysicsManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668722);
			PhysicsManager.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668723);
			PhysicsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668724);
			PhysicsManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668725);
			PhysicsManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668726);
			PhysicsManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668727);
			PhysicsManager.NativeMethodInfoPtr_RpcWriter___Observers_SetGravityMultiplier_530160725_Private_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668728);
			PhysicsManager.NativeMethodInfoPtr_RpcLogic___SetGravityMultiplier_530160725_Public_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668729);
			PhysicsManager.NativeMethodInfoPtr_RpcReader___Observers_SetGravityMultiplier_530160725_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668730);
			PhysicsManager.NativeMethodInfoPtr_RpcWriter___Target_SetGravityMultiplier_530160725_Private_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668731);
			PhysicsManager.NativeMethodInfoPtr_RpcReader___Target_SetGravityMultiplier_530160725_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668732);
			PhysicsManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr, 100668733);
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x001075EC File Offset: 0x001057EC
		// (set) Token: 0x06002A7A RID: 10874 RVA: 0x00107628 File Offset: 0x00105828
		public unsafe float GravityMultiplier
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 75486, RefRangeEnd = 75489, XrefRangeStart = 75486, XrefRangeEnd = 75489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr_set_GravityMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x00107668 File Offset: 0x00105868
		// (set) Token: 0x06002A7C RID: 10876 RVA: 0x001076A4 File Offset: 0x001058A4
		public unsafe LayerMask GroundDetectionLayerMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr_get_GroundDetectionLayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr_set_GroundDetectionLayerMask_Private_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x001076E4 File Offset: 0x001058E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124285, XrefRangeEnd = 124303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00107720 File Offset: 0x00105920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124303, XrefRangeEnd = 124306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00107770 File Offset: 0x00105970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124348, RefRangeEnd = 124350, XrefRangeStart = 124306, XrefRangeEnd = 124348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGravityMultiplier(NetworkConnection conn, float gravity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gravity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x001077C0 File Offset: 0x001059C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124350, XrefRangeEnd = 124353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhysicsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x001077FC File Offset: 0x001059FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124353, XrefRangeEnd = 124378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x00107838 File Offset: 0x00105A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124378, XrefRangeEnd = 124381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00107874 File Offset: 0x00105A74
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x001078B0 File Offset: 0x00105AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124381, XrefRangeEnd = 124391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetGravityMultiplier_530160725(NetworkConnection conn, float gravity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gravity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr_RpcWriter___Observers_SetGravityMultiplier_530160725_Private_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x00107900 File Offset: 0x00105B00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124403, RefRangeEnd = 124406, XrefRangeStart = 124391, XrefRangeEnd = 124403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGravityMultiplier_530160725(NetworkConnection conn, float gravity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gravity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr_RpcLogic___SetGravityMultiplier_530160725_Public_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x00107950 File Offset: 0x00105B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124406, XrefRangeEnd = 124410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetGravityMultiplier_530160725(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr_RpcReader___Observers_SetGravityMultiplier_530160725_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x001079A0 File Offset: 0x00105BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124410, XrefRangeEnd = 124420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetGravityMultiplier_530160725(NetworkConnection conn, float gravity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gravity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr_RpcWriter___Target_SetGravityMultiplier_530160725_Private_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x001079F0 File Offset: 0x00105BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124420, XrefRangeEnd = 124424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetGravityMultiplier_530160725(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsManager.NativeMethodInfoPtr_RpcReader___Target_SetGravityMultiplier_530160725_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x00107A40 File Offset: 0x00105C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124424, XrefRangeEnd = 124442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x00016293 File Offset: 0x00014493
		public PhysicsManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x00107A7C File Offset: 0x00105C7C
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x0001629C File Offset: 0x0001449C
		public unsafe static bool AutoSyncTransforms
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(PhysicsManager.NativeFieldInfoPtr_AutoSyncTransforms, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhysicsManager.NativeFieldInfoPtr_AutoSyncTransforms, (void*)(&value));
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x00107A98 File Offset: 0x00105C98
		// (set) Token: 0x06002A8E RID: 10894 RVA: 0x000162AA File Offset: 0x000144AA
		public unsafe float _GravityMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsManager.NativeFieldInfoPtr__GravityMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsManager.NativeFieldInfoPtr__GravityMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x00107AC0 File Offset: 0x00105CC0
		// (set) Token: 0x06002A90 RID: 10896 RVA: 0x000162C5 File Offset: 0x000144C5
		public unsafe LayerMask _GroundDetectionLayerMask_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsManager.NativeFieldInfoPtr__GroundDetectionLayerMask_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsManager.NativeFieldInfoPtr__GroundDetectionLayerMask_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x00107AE8 File Offset: 0x00105CE8
		// (set) Token: 0x06002A92 RID: 10898 RVA: 0x000162E0 File Offset: 0x000144E0
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x00107B10 File Offset: 0x00105D10
		// (set) Token: 0x06002A94 RID: 10900 RVA: 0x000162FB File Offset: 0x000144FB
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeFieldInfoPtr_AutoSyncTransforms;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeFieldInfoPtr__GravityMultiplier_k__BackingField;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeFieldInfoPtr__GroundDetectionLayerMask_k__BackingField;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_set_GravityMultiplier_Private_set_Void_Single_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_get_GroundDetectionLayerMask_Public_get_LayerMask_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_set_GroundDetectionLayerMask_Private_set_Void_LayerMask_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_NetworkConnection_Single_0;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetGravityMultiplier_530160725_Private_Void_NetworkConnection_Single_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetGravityMultiplier_530160725_Public_Void_NetworkConnection_Single_0;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetGravityMultiplier_530160725_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetGravityMultiplier_530160725_Private_Void_NetworkConnection_Single_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetGravityMultiplier_530160725_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}

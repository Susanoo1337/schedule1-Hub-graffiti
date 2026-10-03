using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Variables;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200035A RID: 858
	public class NetworkedItemPickup : NetworkBehaviour
	{
		// Token: 0x060048C2 RID: 18626 RVA: 0x001729A8 File Offset: 0x00170BA8
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkedItemPickup()
		{
			Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "NetworkedItemPickup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr);
			NetworkedItemPickup.NativeFieldInfoPtr_ItemToGive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "ItemToGive");
			NetworkedItemPickup.NativeFieldInfoPtr_DestroyOnPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "DestroyOnPickup");
			NetworkedItemPickup.NativeFieldInfoPtr_ConditionallyActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "ConditionallyActive");
			NetworkedItemPickup.NativeFieldInfoPtr_ActiveCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "ActiveCondition");
			NetworkedItemPickup.NativeFieldInfoPtr_Networked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "Networked");
			NetworkedItemPickup.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "IntObj");
			NetworkedItemPickup.NativeFieldInfoPtr_onPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "onPickup");
			NetworkedItemPickup.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ItemFramework.NetworkedItemPickupAssembly-CSharp.dll_Excuted");
			NetworkedItemPickup.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ItemFramework.NetworkedItemPickupAssembly-CSharp.dll_Excuted");
			NetworkedItemPickup.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672616);
			NetworkedItemPickup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672617);
			NetworkedItemPickup.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672618);
			NetworkedItemPickup.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672619);
			NetworkedItemPickup.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672620);
			NetworkedItemPickup.NativeMethodInfoPtr_CanPickup_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672621);
			NetworkedItemPickup.NativeMethodInfoPtr_Pickup_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672622);
			NetworkedItemPickup.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672623);
			NetworkedItemPickup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672624);
			NetworkedItemPickup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672625);
			NetworkedItemPickup.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672626);
			NetworkedItemPickup.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672627);
			NetworkedItemPickup.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672628);
			NetworkedItemPickup.NativeMethodInfoPtr_RpcWriter___Server_Destroy_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672629);
			NetworkedItemPickup.NativeMethodInfoPtr_RpcLogic___Destroy_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672630);
			NetworkedItemPickup.NativeMethodInfoPtr_RpcReader___Server_Destroy_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672631);
			NetworkedItemPickup.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, 100672632);
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00172BE0 File Offset: 0x00170DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168518, XrefRangeEnd = 168538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedItemPickup.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00172C1C File Offset: 0x00170E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168538, XrefRangeEnd = 168566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00172C50 File Offset: 0x00170E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168597, RefRangeEnd = 168598, XrefRangeStart = 168566, XrefRangeEnd = 168597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00172C84 File Offset: 0x00170E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168598, XrefRangeEnd = 168602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedItemPickup.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00172CC0 File Offset: 0x00170EC0
		[CallerCount(0)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x00172CF4 File Offset: 0x00170EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168602, XrefRangeEnd = 168607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedItemPickup.NativeMethodInfoPtr_CanPickup_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00172D3C File Offset: 0x00170F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168637, RefRangeEnd = 168638, XrefRangeStart = 168607, XrefRangeEnd = 168637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Pickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedItemPickup.NativeMethodInfoPtr_Pickup_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x00172D78 File Offset: 0x00170F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168659, RefRangeEnd = 168660, XrefRangeStart = 168638, XrefRangeEnd = 168659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x00172DAC File Offset: 0x00170FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168660, XrefRangeEnd = 168661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkedItemPickup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x00172DE8 File Offset: 0x00170FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168661, XrefRangeEnd = 168666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x00172E28 File Offset: 0x00171028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168666, XrefRangeEnd = 168673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedItemPickup.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x00172E64 File Offset: 0x00171064
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedItemPickup.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x00172EA0 File Offset: 0x001710A0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedItemPickup.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x00172EDC File Offset: 0x001710DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168673, XrefRangeEnd = 168682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Destroy_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.NativeMethodInfoPtr_RpcWriter___Server_Destroy_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00172F10 File Offset: 0x00171110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168690, RefRangeEnd = 168693, XrefRangeStart = 168682, XrefRangeEnd = 168690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Destroy_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.NativeMethodInfoPtr_RpcLogic___Destroy_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x00172F44 File Offset: 0x00171144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168693, XrefRangeEnd = 168696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Destroy_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.NativeMethodInfoPtr_RpcReader___Server_Destroy_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00172FA8 File Offset: 0x001711A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168696, XrefRangeEnd = 168716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedItemPickup.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x000235F7 File Offset: 0x000217F7
		public NetworkedItemPickup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x00172FE4 File Offset: 0x001711E4
		// (set) Token: 0x060048D6 RID: 18646 RVA: 0x00023600 File Offset: 0x00021800
		public unsafe ItemDefinition ItemToGive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_ItemToGive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_ItemToGive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x00173014 File Offset: 0x00171214
		// (set) Token: 0x060048D8 RID: 18648 RVA: 0x0002361F File Offset: 0x0002181F
		public unsafe bool DestroyOnPickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_DestroyOnPickup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_DestroyOnPickup)) = value;
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x0017303C File Offset: 0x0017123C
		// (set) Token: 0x060048DA RID: 18650 RVA: 0x0002363A File Offset: 0x0002183A
		public unsafe bool ConditionallyActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_ConditionallyActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_ConditionallyActive)) = value;
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x060048DB RID: 18651 RVA: 0x00173064 File Offset: 0x00171264
		// (set) Token: 0x060048DC RID: 18652 RVA: 0x00023655 File Offset: 0x00021855
		public unsafe Condition ActiveCondition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_ActiveCondition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Condition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_ActiveCondition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x060048DD RID: 18653 RVA: 0x00173094 File Offset: 0x00171294
		// (set) Token: 0x060048DE RID: 18654 RVA: 0x00023674 File Offset: 0x00021874
		public unsafe bool Networked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_Networked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_Networked)) = value;
			}
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x001730BC File Offset: 0x001712BC
		// (set) Token: 0x060048E0 RID: 18656 RVA: 0x0002368F File Offset: 0x0002188F
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x060048E1 RID: 18657 RVA: 0x001730EC File Offset: 0x001712EC
		// (set) Token: 0x060048E2 RID: 18658 RVA: 0x000236AE File Offset: 0x000218AE
		public unsafe UnityEvent onPickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_onPickup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_onPickup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x0017311C File Offset: 0x0017131C
		// (set) Token: 0x060048E4 RID: 18660 RVA: 0x000236CD File Offset: 0x000218CD
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x00173144 File Offset: 0x00171344
		// (set) Token: 0x060048E6 RID: 18662 RVA: 0x000236E8 File Offset: 0x000218E8
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003175 RID: 12661
		private static readonly IntPtr NativeFieldInfoPtr_ItemToGive;

		// Token: 0x04003176 RID: 12662
		private static readonly IntPtr NativeFieldInfoPtr_DestroyOnPickup;

		// Token: 0x04003177 RID: 12663
		private static readonly IntPtr NativeFieldInfoPtr_ConditionallyActive;

		// Token: 0x04003178 RID: 12664
		private static readonly IntPtr NativeFieldInfoPtr_ActiveCondition;

		// Token: 0x04003179 RID: 12665
		private static readonly IntPtr NativeFieldInfoPtr_Networked;

		// Token: 0x0400317A RID: 12666
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x0400317B RID: 12667
		private static readonly IntPtr NativeFieldInfoPtr_onPickup;

		// Token: 0x0400317C RID: 12668
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400317D RID: 12669
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400317E RID: 12670
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400317F RID: 12671
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003180 RID: 12672
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04003181 RID: 12673
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1;

		// Token: 0x04003182 RID: 12674
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04003183 RID: 12675
		private static readonly IntPtr NativeMethodInfoPtr_CanPickup_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003184 RID: 12676
		private static readonly IntPtr NativeMethodInfoPtr_Pickup_Protected_Virtual_New_Void_1;

		// Token: 0x04003185 RID: 12677
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04003186 RID: 12678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003187 RID: 12679
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04003188 RID: 12680
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003189 RID: 12681
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400318A RID: 12682
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400318B RID: 12683
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Destroy_2166136261_Private_Void_0;

		// Token: 0x0400318C RID: 12684
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Destroy_2166136261_Public_Void_0;

		// Token: 0x0400318D RID: 12685
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Destroy_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400318E RID: 12686
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000A6F RID: 2671
		[ObfuscatedName("ScheduleOne.ItemFramework.NetworkedItemPickup+<<Init>g__Wait|9_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique : Object
		{
			// Token: 0x0600E104 RID: 57604 RVA: 0x0037478C File Offset: 0x0037298C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique()
			{
				Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "<<Init>g__Wait|9_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr);
				NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, "<>1__state");
				NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, "<>2__current");
				NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, "<>4__this");
				NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100672633);
				NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100672634);
				NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100672635);
				NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100672636);
				NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100672637);
				NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100672638);
			}

			// Token: 0x0600E105 RID: 57605 RVA: 0x0037486C File Offset: 0x00372A6C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E106 RID: 57606 RVA: 0x003748B4 File Offset: 0x00372AB4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E107 RID: 57607 RVA: 0x003748E8 File Offset: 0x00372AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168489, XrefRangeEnd = 168509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004482 RID: 17538
			// (get) Token: 0x0600E108 RID: 57608 RVA: 0x00374924 File Offset: 0x00372B24
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E109 RID: 57609 RVA: 0x00374964 File Offset: 0x00372B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168509, XrefRangeEnd = 168514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004483 RID: 17539
			// (get) Token: 0x0600E10A RID: 57610 RVA: 0x00374998 File Offset: 0x00372B98
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E10B RID: 57611 RVA: 0x0006A10D File Offset: 0x0006830D
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700447F RID: 17535
			// (get) Token: 0x0600E10C RID: 57612 RVA: 0x003749D8 File Offset: 0x00372BD8
			// (set) Token: 0x0600E10D RID: 57613 RVA: 0x0006A116 File Offset: 0x00068316
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004480 RID: 17536
			// (get) Token: 0x0600E10E RID: 57614 RVA: 0x00374A00 File Offset: 0x00372C00
			// (set) Token: 0x0600E10F RID: 57615 RVA: 0x0006A131 File Offset: 0x00068331
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004481 RID: 17537
			// (get) Token: 0x0600E110 RID: 57616 RVA: 0x00374A30 File Offset: 0x00372C30
			// (set) Token: 0x0600E111 RID: 57617 RVA: 0x0006A150 File Offset: 0x00068350
			public unsafe NetworkedItemPickup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkedItemPickup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009927 RID: 39207
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009928 RID: 39208
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009929 RID: 39209
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400992A RID: 39210
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400992B RID: 39211
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400992C RID: 39212
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400992D RID: 39213
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400992E RID: 39214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400992F RID: 39215
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A70 RID: 2672
		[ObfuscatedName("ScheduleOne.ItemFramework.NetworkedItemPickup+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E112 RID: 57618 RVA: 0x00374A60 File Offset: 0x00372C60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NetworkedItemPickup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkedItemPickup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedItemPickup.__c>.NativeClassPtr);
				NetworkedItemPickup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup.__c>.NativeClassPtr, "<>9");
				NetworkedItemPickup.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedItemPickup.__c>.NativeClassPtr, "<>9__9_1");
				NetworkedItemPickup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup.__c>.NativeClassPtr, 100672640);
				NetworkedItemPickup.__c.NativeMethodInfoPtr__Init_b__9_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedItemPickup.__c>.NativeClassPtr, 100672641);
			}

			// Token: 0x0600E113 RID: 57619 RVA: 0x00374ADC File Offset: 0x00372CDC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedItemPickup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E114 RID: 57620 RVA: 0x00374B18 File Offset: 0x00372D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168514, XrefRangeEnd = 168518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Init_b__9_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedItemPickup.__c.NativeMethodInfoPtr__Init_b__9_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E115 RID: 57621 RVA: 0x0006A16F File Offset: 0x0006836F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004484 RID: 17540
			// (get) Token: 0x0600E116 RID: 57622 RVA: 0x00374B54 File Offset: 0x00372D54
			// (set) Token: 0x0600E117 RID: 57623 RVA: 0x0006A178 File Offset: 0x00068378
			public unsafe static NetworkedItemPickup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NetworkedItemPickup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkedItemPickup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NetworkedItemPickup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004485 RID: 17541
			// (get) Token: 0x0600E118 RID: 57624 RVA: 0x00374B7C File Offset: 0x00372D7C
			// (set) Token: 0x0600E119 RID: 57625 RVA: 0x0006A18A File Offset: 0x0006838A
			public unsafe static Func<bool> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NetworkedItemPickup.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NetworkedItemPickup.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009930 RID: 39216
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009931 RID: 39217
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04009932 RID: 39218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009933 RID: 39219
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__9_1_Internal_Boolean_0;
		}
	}
}

using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000646 RID: 1606
	public class SchizoGoblin : NPC
	{
		// Token: 0x0600994A RID: 39242 RVA: 0x00291234 File Offset: 0x0028F434
		// Note: this type is marked as 'beforefieldinit'.
		static SchizoGoblin()
		{
			Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "SchizoGoblin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr);
			SchizoGoblin.NativeFieldInfoPtr_targetPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, "targetPlayer");
			SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted");
			SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted");
			SchizoGoblin.NativeMethodInfoPtr_SetTargetPlayer_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100683252);
			SchizoGoblin.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100683253);
			SchizoGoblin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100683254);
			SchizoGoblin.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100683255);
			SchizoGoblin.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100683256);
			SchizoGoblin.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100683257);
			SchizoGoblin.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100683258);
			SchizoGoblin.NativeMethodInfoPtr_RpcLogic___SetTargetPlayer_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100683259);
			SchizoGoblin.NativeMethodInfoPtr_RpcReader___Observers_SetTargetPlayer_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100683260);
			SchizoGoblin.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100683261);
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x00291368 File Offset: 0x0028F568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273793, XrefRangeEnd = 273803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetPlayer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr_SetTargetPlayer_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x002913AC File Offset: 0x0028F5AC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x002913E0 File Offset: 0x0028F5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchizoGoblin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600994E RID: 39246 RVA: 0x0029141C File Offset: 0x0028F61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273803, XrefRangeEnd = 273811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchizoGoblin.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600994F RID: 39247 RVA: 0x00291458 File Offset: 0x0028F658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchizoGoblin.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009950 RID: 39248 RVA: 0x00291494 File Offset: 0x0028F694
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchizoGoblin.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009951 RID: 39249 RVA: 0x002914D0 File Offset: 0x0028F6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTargetPlayer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009952 RID: 39250 RVA: 0x00291514 File Offset: 0x0028F714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273811, XrefRangeEnd = 273826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTargetPlayer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr_RpcLogic___SetTargetPlayer_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009953 RID: 39251 RVA: 0x00291558 File Offset: 0x0028F758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273826, XrefRangeEnd = 273842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr_RpcReader___Observers_SetTargetPlayer_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009954 RID: 39252 RVA: 0x002915A8 File Offset: 0x0028F7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchizoGoblin.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009955 RID: 39253 RVA: 0x000477BC File Offset: 0x000459BC
		public SchizoGoblin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x06009956 RID: 39254 RVA: 0x002915E4 File Offset: 0x0028F7E4
		// (set) Token: 0x06009957 RID: 39255 RVA: 0x000477C5 File Offset: 0x000459C5
		public unsafe Player targetPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_targetPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_targetPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x06009958 RID: 39256 RVA: 0x00291614 File Offset: 0x0028F814
		// (set) Token: 0x06009959 RID: 39257 RVA: 0x000477E4 File Offset: 0x000459E4
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x0600995A RID: 39258 RVA: 0x0029163C File Offset: 0x0028F83C
		// (set) Token: 0x0600995B RID: 39259 RVA: 0x000477FF File Offset: 0x000459FF
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400694F RID: 26959
		private static readonly IntPtr NativeFieldInfoPtr_targetPlayer;

		// Token: 0x04006950 RID: 26960
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006951 RID: 26961
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006952 RID: 26962
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetPlayer_Public_Void_NetworkObject_0;

		// Token: 0x04006953 RID: 26963
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x04006954 RID: 26964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006955 RID: 26965
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006956 RID: 26966
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006957 RID: 26967
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006958 RID: 26968
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTargetPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04006959 RID: 26969
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTargetPlayer_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x0400695A RID: 26970
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTargetPlayer_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400695B RID: 26971
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

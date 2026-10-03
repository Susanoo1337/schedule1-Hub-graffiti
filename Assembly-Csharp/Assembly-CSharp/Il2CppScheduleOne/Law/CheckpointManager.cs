using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Police;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000305 RID: 773
	public class CheckpointManager : NetworkSingleton<CheckpointManager>
	{
		// Token: 0x06003D5E RID: 15710 RVA: 0x0014A188 File Offset: 0x00148388
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointManager()
		{
			Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CheckpointManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr);
			CheckpointManager.NativeFieldInfoPtr_WesternCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "WesternCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_DocksCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "DocksCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_NorthResidentialCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "NorthResidentialCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_WestResidentialCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "WestResidentialCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted");
			CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted");
			CheckpointManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100671136);
			CheckpointManager.NativeMethodInfoPtr_SetCheckpointEnabled_Public_Void_ECheckpointLocation_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100671137);
			CheckpointManager.NativeMethodInfoPtr_GetCheckpoint_Public_RoadCheckpoint_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100671138);
			CheckpointManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100671139);
			CheckpointManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100671140);
			CheckpointManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100671141);
			CheckpointManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100671142);
			CheckpointManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100671143);
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x0014A2D0 File Offset: 0x001484D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152164, XrefRangeEnd = 152169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x0014A320 File Offset: 0x00148520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152175, RefRangeEnd = 152176, XrefRangeStart = 152169, XrefRangeEnd = 152175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCheckpointEnabled(CheckpointManager.ECheckpointLocation checkpoint, bool enabled, int requestedOfficers = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkpoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedOfficers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointManager.NativeMethodInfoPtr_SetCheckpointEnabled_Public_Void_ECheckpointLocation_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x0014A37C File Offset: 0x0014857C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 152176, RefRangeEnd = 152179, XrefRangeStart = 152176, XrefRangeEnd = 152176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadCheckpoint GetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointManager.NativeMethodInfoPtr_GetCheckpoint_Public_RoadCheckpoint_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr3) : null;
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x0014A3C8 File Offset: 0x001485C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152179, XrefRangeEnd = 152182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x0014A404 File Offset: 0x00148604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152182, XrefRangeEnd = 152185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x0014A440 File Offset: 0x00148640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152185, XrefRangeEnd = 152188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x0014A47C File Offset: 0x0014867C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x0014A4B8 File Offset: 0x001486B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152188, XrefRangeEnd = 152191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x0001E917 File Offset: 0x0001CB17
		public CheckpointManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06003D68 RID: 15720 RVA: 0x0014A4F4 File Offset: 0x001486F4
		// (set) Token: 0x06003D69 RID: 15721 RVA: 0x0001E920 File Offset: 0x0001CB20
		public unsafe RoadCheckpoint WesternCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WesternCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WesternCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x0014A524 File Offset: 0x00148724
		// (set) Token: 0x06003D6B RID: 15723 RVA: 0x0001E93F File Offset: 0x0001CB3F
		public unsafe RoadCheckpoint DocksCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_DocksCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_DocksCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06003D6C RID: 15724 RVA: 0x0014A554 File Offset: 0x00148754
		// (set) Token: 0x06003D6D RID: 15725 RVA: 0x0001E95E File Offset: 0x0001CB5E
		public unsafe RoadCheckpoint NorthResidentialCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_NorthResidentialCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_NorthResidentialCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06003D6E RID: 15726 RVA: 0x0014A584 File Offset: 0x00148784
		// (set) Token: 0x06003D6F RID: 15727 RVA: 0x0001E97D File Offset: 0x0001CB7D
		public unsafe RoadCheckpoint WestResidentialCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WestResidentialCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WestResidentialCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06003D70 RID: 15728 RVA: 0x0014A5B4 File Offset: 0x001487B4
		// (set) Token: 0x06003D71 RID: 15729 RVA: 0x0001E99C File Offset: 0x0001CB9C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06003D72 RID: 15730 RVA: 0x0014A5DC File Offset: 0x001487DC
		// (set) Token: 0x06003D73 RID: 15731 RVA: 0x0001E9B7 File Offset: 0x0001CBB7
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002975 RID: 10613
		private static readonly IntPtr NativeFieldInfoPtr_WesternCheckpoint;

		// Token: 0x04002976 RID: 10614
		private static readonly IntPtr NativeFieldInfoPtr_DocksCheckpoint;

		// Token: 0x04002977 RID: 10615
		private static readonly IntPtr NativeFieldInfoPtr_NorthResidentialCheckpoint;

		// Token: 0x04002978 RID: 10616
		private static readonly IntPtr NativeFieldInfoPtr_WestResidentialCheckpoint;

		// Token: 0x04002979 RID: 10617
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400297A RID: 10618
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400297B RID: 10619
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400297C RID: 10620
		private static readonly IntPtr NativeMethodInfoPtr_SetCheckpointEnabled_Public_Void_ECheckpointLocation_Boolean_Int32_0;

		// Token: 0x0400297D RID: 10621
		private static readonly IntPtr NativeMethodInfoPtr_GetCheckpoint_Public_RoadCheckpoint_ECheckpointLocation_0;

		// Token: 0x0400297E RID: 10622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400297F RID: 10623
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002980 RID: 10624
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002981 RID: 10625
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002982 RID: 10626
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A3E RID: 2622
		[OriginalName("Assembly-CSharp.dll", "", "ECheckpointLocation")]
		public enum ECheckpointLocation
		{
			// Token: 0x04009823 RID: 38947
			Western,
			// Token: 0x04009824 RID: 38948
			Docks,
			// Token: 0x04009825 RID: 38949
			NorthResidential,
			// Token: 0x04009826 RID: 38950
			WestResidential
		}
	}
}

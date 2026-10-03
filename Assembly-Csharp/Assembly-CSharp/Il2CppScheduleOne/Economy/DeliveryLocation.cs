using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000396 RID: 918
	public class DeliveryLocation : MonoBehaviour
	{
		// Token: 0x0600536B RID: 21355 RVA: 0x0019BFEC File Offset: 0x0019A1EC
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryLocation()
		{
			Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DeliveryLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr);
			DeliveryLocation.NativeFieldInfoPtr_LocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "LocationName");
			DeliveryLocation.NativeFieldInfoPtr_LocationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "LocationDescription");
			DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "CustomerStandPoint");
			DeliveryLocation.NativeFieldInfoPtr_TeleportPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "TeleportPoint");
			DeliveryLocation.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "StaticGUID");
			DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "ScheduledContracts");
			DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "<GUID>k__BackingField");
			DeliveryLocation.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674248);
			DeliveryLocation.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674249);
			DeliveryLocation.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674250);
			DeliveryLocation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674251);
			DeliveryLocation.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674252);
			DeliveryLocation.NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674253);
			DeliveryLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674254);
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x0019C134 File Offset: 0x0019A334
		// (set) Token: 0x0600536D RID: 21357 RVA: 0x0019C170 File Offset: 0x0019A370
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x0019C1B0 File Offset: 0x0019A3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186485, XrefRangeEnd = 186489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x0019C1F0 File Offset: 0x0019A3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186489, XrefRangeEnd = 186507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x0019C224 File Offset: 0x0019A424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x0019C258 File Offset: 0x0019A458
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryLocation.NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x0019C29C File Offset: 0x0019A49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186507, XrefRangeEnd = 186522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x000277B1 File Offset: 0x000259B1
		public DeliveryLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x0019C2D8 File Offset: 0x0019A4D8
		// (set) Token: 0x06005375 RID: 21365 RVA: 0x000277BA File Offset: 0x000259BA
		public unsafe string LocationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06005376 RID: 21366 RVA: 0x0019C300 File Offset: 0x0019A500
		// (set) Token: 0x06005377 RID: 21367 RVA: 0x000277D9 File Offset: 0x000259D9
		public unsafe string LocationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06005378 RID: 21368 RVA: 0x0019C328 File Offset: 0x0019A528
		// (set) Token: 0x06005379 RID: 21369 RVA: 0x000277F8 File Offset: 0x000259F8
		public unsafe Transform CustomerStandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x0600537A RID: 21370 RVA: 0x0019C358 File Offset: 0x0019A558
		// (set) Token: 0x0600537B RID: 21371 RVA: 0x00027817 File Offset: 0x00025A17
		public unsafe Transform TeleportPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_TeleportPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_TeleportPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x0600537C RID: 21372 RVA: 0x0019C388 File Offset: 0x0019A588
		// (set) Token: 0x0600537D RID: 21373 RVA: 0x00027836 File Offset: 0x00025A36
		public unsafe string StaticGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x0019C3B0 File Offset: 0x0019A5B0
		// (set) Token: 0x0600537F RID: 21375 RVA: 0x00027855 File Offset: 0x00025A55
		public unsafe List<Contract> ScheduledContracts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06005380 RID: 21376 RVA: 0x0019C3E0 File Offset: 0x0019A5E0
		// (set) Token: 0x06005381 RID: 21377 RVA: 0x00027874 File Offset: 0x00025A74
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x0400396D RID: 14701
		private static readonly IntPtr NativeFieldInfoPtr_LocationName;

		// Token: 0x0400396E RID: 14702
		private static readonly IntPtr NativeFieldInfoPtr_LocationDescription;

		// Token: 0x0400396F RID: 14703
		private static readonly IntPtr NativeFieldInfoPtr_CustomerStandPoint;

		// Token: 0x04003970 RID: 14704
		private static readonly IntPtr NativeFieldInfoPtr_TeleportPoint;

		// Token: 0x04003971 RID: 14705
		private static readonly IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x04003972 RID: 14706
		private static readonly IntPtr NativeFieldInfoPtr_ScheduledContracts;

		// Token: 0x04003973 RID: 14707
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003974 RID: 14708
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003975 RID: 14709
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003976 RID: 14710
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003977 RID: 14711
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003978 RID: 14712
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003979 RID: 14713
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0;

		// Token: 0x0400397A RID: 14714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

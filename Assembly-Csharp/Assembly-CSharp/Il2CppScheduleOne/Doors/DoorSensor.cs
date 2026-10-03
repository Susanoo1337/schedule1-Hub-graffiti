using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003A9 RID: 937
	public class DoorSensor : MonoBehaviour
	{
		// Token: 0x06005555 RID: 21845 RVA: 0x001A2DDC File Offset: 0x001A0FDC
		// Note: this type is marked as 'beforefieldinit'.
		static DoorSensor()
		{
			Il2CppClassPointerStore<DoorSensor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DoorSensor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr);
			DoorSensor.NativeFieldInfoPtr_ActivationDistanceSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "ActivationDistanceSqr");
			DoorSensor.NativeFieldInfoPtr_DetectorSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "DetectorSide");
			DoorSensor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "Door");
			DoorSensor.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "collider");
			DoorSensor.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "exclude");
			DoorSensor.NativeFieldInfoPtr_npcsInContact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "npcsInContact");
			DoorSensor.NativeFieldInfoPtr_playersInContact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "playersInContact");
			DoorSensor.NativeFieldInfoPtr_maxContactDistanceSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "maxContactDistanceSqr");
			DoorSensor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100674494);
			DoorSensor.NativeMethodInfoPtr_UpdateCollider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100674495);
			DoorSensor.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100674496);
			DoorSensor.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100674497);
			DoorSensor.NativeMethodInfoPtr_RemoveInvalidContacts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100674498);
			DoorSensor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100674499);
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x001A2F24 File Offset: 0x001A1124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189269, XrefRangeEnd = 189287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x001A2F58 File Offset: 0x001A1158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189287, XrefRangeEnd = 189307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_UpdateCollider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x001A2F8C File Offset: 0x001A118C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189307, XrefRangeEnd = 189330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x001A2FD0 File Offset: 0x001A11D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189330, XrefRangeEnd = 189352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x001A3014 File Offset: 0x001A1214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189352, XrefRangeEnd = 189386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveInvalidContacts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_RemoveInvalidContacts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x001A3048 File Offset: 0x001A1248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189386, XrefRangeEnd = 189408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorSensor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x000284BA File Offset: 0x000266BA
		public DoorSensor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x0600555D RID: 21853 RVA: 0x001A3084 File Offset: 0x001A1284
		// (set) Token: 0x0600555E RID: 21854 RVA: 0x000284C3 File Offset: 0x000266C3
		public unsafe static float ActivationDistanceSqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DoorSensor.NativeFieldInfoPtr_ActivationDistanceSqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoorSensor.NativeFieldInfoPtr_ActivationDistanceSqr, (void*)(&value));
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x0600555F RID: 21855 RVA: 0x001A30A0 File Offset: 0x001A12A0
		// (set) Token: 0x06005560 RID: 21856 RVA: 0x000284D1 File Offset: 0x000266D1
		public unsafe EDoorSide DetectorSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_DetectorSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_DetectorSide)) = value;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06005561 RID: 21857 RVA: 0x001A30C8 File Offset: 0x001A12C8
		// (set) Token: 0x06005562 RID: 21858 RVA: 0x000284EC File Offset: 0x000266EC
		public unsafe DoorController Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06005563 RID: 21859 RVA: 0x001A30F8 File Offset: 0x001A12F8
		// (set) Token: 0x06005564 RID: 21860 RVA: 0x0002850B File Offset: 0x0002670B
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06005565 RID: 21861 RVA: 0x001A3128 File Offset: 0x001A1328
		// (set) Token: 0x06005566 RID: 21862 RVA: 0x0002852A File Offset: 0x0002672A
		public unsafe List<Collider> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06005567 RID: 21863 RVA: 0x001A3158 File Offset: 0x001A1358
		// (set) Token: 0x06005568 RID: 21864 RVA: 0x00028549 File Offset: 0x00026749
		public unsafe List<NPC> npcsInContact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_npcsInContact);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_npcsInContact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06005569 RID: 21865 RVA: 0x001A3188 File Offset: 0x001A1388
		// (set) Token: 0x0600556A RID: 21866 RVA: 0x00028568 File Offset: 0x00026768
		public unsafe List<Player> playersInContact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_playersInContact);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_playersInContact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x0600556B RID: 21867 RVA: 0x001A31B8 File Offset: 0x001A13B8
		// (set) Token: 0x0600556C RID: 21868 RVA: 0x00028587 File Offset: 0x00026787
		public unsafe float maxContactDistanceSqr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_maxContactDistanceSqr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_maxContactDistanceSqr)) = value;
			}
		}

		// Token: 0x04003ADA RID: 15066
		private static readonly IntPtr NativeFieldInfoPtr_ActivationDistanceSqr;

		// Token: 0x04003ADB RID: 15067
		private static readonly IntPtr NativeFieldInfoPtr_DetectorSide;

		// Token: 0x04003ADC RID: 15068
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x04003ADD RID: 15069
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x04003ADE RID: 15070
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x04003ADF RID: 15071
		private static readonly IntPtr NativeFieldInfoPtr_npcsInContact;

		// Token: 0x04003AE0 RID: 15072
		private static readonly IntPtr NativeFieldInfoPtr_playersInContact;

		// Token: 0x04003AE1 RID: 15073
		private static readonly IntPtr NativeFieldInfoPtr_maxContactDistanceSqr;

		// Token: 0x04003AE2 RID: 15074
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003AE3 RID: 15075
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollider_Private_Void_0;

		// Token: 0x04003AE4 RID: 15076
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04003AE5 RID: 15077
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x04003AE6 RID: 15078
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInvalidContacts_Private_Void_0;

		// Token: 0x04003AE7 RID: 15079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

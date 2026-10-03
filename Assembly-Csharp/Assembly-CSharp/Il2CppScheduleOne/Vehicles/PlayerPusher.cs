using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000D1 RID: 209
	public class PlayerPusher : MonoBehaviour
	{
		// Token: 0x06001423 RID: 5155 RVA: 0x000BF164 File Offset: 0x000BD364
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPusher()
		{
			Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "PlayerPusher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr);
			PlayerPusher.NativeFieldInfoPtr_veh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "veh");
			PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MinSpeedToPush");
			PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MaxPushSpeed");
			PlayerPusher.NativeFieldInfoPtr_MinPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MinPushForce");
			PlayerPusher.NativeFieldInfoPtr_MaxPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MaxPushForce");
			PlayerPusher.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "collider");
			PlayerPusher.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100666207);
			PlayerPusher.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100666208);
			PlayerPusher.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100666209);
			PlayerPusher.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100666210);
			PlayerPusher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100666211);
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000BF270 File Offset: 0x000BD470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93715, XrefRangeEnd = 93738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000BF2A4 File Offset: 0x000BD4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93738, XrefRangeEnd = 93742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x000BF2D8 File Offset: 0x000BD4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93742, XrefRangeEnd = 93744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x000BF318 File Offset: 0x000BD518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93744, XrefRangeEnd = 93782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x000BF35C File Offset: 0x000BD55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93782, XrefRangeEnd = 93783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPusher() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0000B147 File Offset: 0x00009347
		public PlayerPusher(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x000BF398 File Offset: 0x000BD598
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x0000B150 File Offset: 0x00009350
		public unsafe LandVehicle veh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_veh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_veh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x000BF3C8 File Offset: 0x000BD5C8
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x0000B16F File Offset: 0x0000936F
		public unsafe float MinSpeedToPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush)) = value;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x000BF3F0 File Offset: 0x000BD5F0
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x0000B18A File Offset: 0x0000938A
		public unsafe float MaxPushSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed)) = value;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x000BF418 File Offset: 0x000BD618
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x0000B1A5 File Offset: 0x000093A5
		public unsafe float MinPushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinPushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinPushForce)) = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x000BF440 File Offset: 0x000BD640
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x0000B1C0 File Offset: 0x000093C0
		public unsafe float MaxPushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushForce)) = value;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x000BF468 File Offset: 0x000BD668
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x0000B1DB File Offset: 0x000093DB
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeFieldInfoPtr_veh;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeFieldInfoPtr_MinSpeedToPush;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushSpeed;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeFieldInfoPtr_MinPushForce;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushForce;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

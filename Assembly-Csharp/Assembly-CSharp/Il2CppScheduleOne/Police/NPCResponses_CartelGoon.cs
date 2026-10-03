using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Cartel;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Responses;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x0200043B RID: 1083
	public class NPCResponses_CartelGoon : NPCResponses
	{
		// Token: 0x0600613D RID: 24893 RVA: 0x001CBB1C File Offset: 0x001C9D1C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCResponses_CartelGoon()
		{
			Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "NPCResponses_CartelGoon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr);
			NPCResponses_CartelGoon.NativeFieldInfoPtr_Goon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, "Goon");
			NPCResponses_CartelGoon.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, 100676058);
			NPCResponses_CartelGoon.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, 100676059);
			NPCResponses_CartelGoon.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, 100676060);
			NPCResponses_CartelGoon.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, 100676061);
			NPCResponses_CartelGoon.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, 100676062);
			NPCResponses_CartelGoon.NativeMethodInfoPtr_HitByCar_Public_Virtual_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, 100676063);
			NPCResponses_CartelGoon.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, 100676064);
			NPCResponses_CartelGoon.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, 100676065);
			NPCResponses_CartelGoon.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, 100676066);
			NPCResponses_CartelGoon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr, 100676067);
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x001CBC28 File Offset: 0x001C9E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206160, XrefRangeEnd = 206161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_CartelGoon.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x001CBC64 File Offset: 0x001C9E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206161, XrefRangeEnd = 206165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExplosionHeard(NoiseEvent explosionSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(explosionSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_CartelGoon.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x001CBCB4 File Offset: 0x001C9EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GunshotHeard(NoiseEvent gunshotSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gunshotSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_CartelGoon.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x001CBD04 File Offset: 0x001C9F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206165, XrefRangeEnd = 206169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticePlayerDischargingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_CartelGoon.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x001CBD54 File Offset: 0x001C9F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206169, XrefRangeEnd = 206172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayerFailedPickpocket(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_CartelGoon.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x001CBDA4 File Offset: 0x001C9FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206172, XrefRangeEnd = 206175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_CartelGoon.NativeMethodInfoPtr_HitByCar_Public_Virtual_Void_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x001CBDF4 File Offset: 0x001C9FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206175, XrefRangeEnd = 206195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ImpactReceived(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_CartelGoon.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x001CBE44 File Offset: 0x001CA044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206195, XrefRangeEnd = 206198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToAimedAt(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_CartelGoon.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x001CBE94 File Offset: 0x001CA094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206198, XrefRangeEnd = 206207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_CartelGoon.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x001CBEF4 File Offset: 0x001CA0F4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses_CartelGoon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCResponses_CartelGoon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_CartelGoon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x0002E034 File Offset: 0x0002C234
		public NPCResponses_CartelGoon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x06006149 RID: 24905 RVA: 0x001CBF30 File Offset: 0x001CA130
		// (set) Token: 0x0600614A RID: 24906 RVA: 0x0002E03D File Offset: 0x0002C23D
		public unsafe CartelGoon Goon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_CartelGoon.NativeFieldInfoPtr_Goon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelGoon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_CartelGoon.NativeFieldInfoPtr_Goon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042FA RID: 17146
		private static readonly IntPtr NativeFieldInfoPtr_Goon;

		// Token: 0x040042FB RID: 17147
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040042FC RID: 17148
		private static readonly IntPtr NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_Void_NoiseEvent_0;

		// Token: 0x040042FD RID: 17149
		private static readonly IntPtr NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0;

		// Token: 0x040042FE RID: 17150
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_Void_Player_0;

		// Token: 0x040042FF RID: 17151
		private static readonly IntPtr NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_Void_Player_0;

		// Token: 0x04004300 RID: 17152
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Virtual_Void_LandVehicle_0;

		// Token: 0x04004301 RID: 17153
		private static readonly IntPtr NativeMethodInfoPtr_ImpactReceived_Public_Virtual_Void_Impact_0;

		// Token: 0x04004302 RID: 17154
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0;

		// Token: 0x04004303 RID: 17155
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04004304 RID: 17156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

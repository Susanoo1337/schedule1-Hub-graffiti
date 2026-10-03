using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004F5 RID: 1269
	public class PlayerSmoothedVelocityCalculator : SmoothedVelocityCalculator
	{
		// Token: 0x060072F1 RID: 29425 RVA: 0x00204FF4 File Offset: 0x002031F4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSmoothedVelocityCalculator()
		{
			Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PlayerSmoothedVelocityCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr);
			PlayerSmoothedVelocityCalculator.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr, "Player");
			PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr_get_Velocity_Public_Virtual_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr, 100678161);
			PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr, 100678162);
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x060072F2 RID: 29426 RVA: 0x00205060 File Offset: 0x00203260
		public unsafe override Vector3 Velocity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227035, XrefRangeEnd = 227047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr_get_Velocity_Public_Virtual_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x002050A8 File Offset: 0x002032A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227047, XrefRangeEnd = 227048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSmoothedVelocityCalculator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x00036A63 File Offset: 0x00034C63
		public PlayerSmoothedVelocityCalculator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x060072F5 RID: 29429 RVA: 0x002050E4 File Offset: 0x002032E4
		// (set) Token: 0x060072F6 RID: 29430 RVA: 0x00036A6C File Offset: 0x00034C6C
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSmoothedVelocityCalculator.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSmoothedVelocityCalculator.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E7C RID: 20092
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04004E7D RID: 20093
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_Virtual_get_Vector3_0;

		// Token: 0x04004E7E RID: 20094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

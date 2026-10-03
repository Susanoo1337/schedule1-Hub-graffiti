using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002B6 RID: 694
	public class FoliageRustleSound : MonoBehaviour
	{
		// Token: 0x060035B9 RID: 13753 RVA: 0x0012E180 File Offset: 0x0012C380
		// Note: this type is marked as 'beforefieldinit'.
		static FoliageRustleSound()
		{
			Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "FoliageRustleSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr);
			FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "ACTIVATION_RANGE_SQUARED");
			FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "COOLDOWN");
			FoliageRustleSound.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "Sound");
			FoliageRustleSound.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "Container");
			FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "timeOnLastHit");
			FoliageRustleSound.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100670112);
			FoliageRustleSound.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100670113);
			FoliageRustleSound.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100670114);
			FoliageRustleSound.NativeMethodInfoPtr_UpdateActive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100670115);
			FoliageRustleSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100670116);
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x0012E278 File Offset: 0x0012C478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141696, XrefRangeEnd = 141702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x0012E2AC File Offset: 0x0012C4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141702, XrefRangeEnd = 141707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x0012E2E0 File Offset: 0x0012C4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141707, XrefRangeEnd = 141734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x0012E324 File Offset: 0x0012C524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141734, XrefRangeEnd = 141749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_UpdateActive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x0012E358 File Offset: 0x0012C558
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FoliageRustleSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x0001B4CD File Offset: 0x000196CD
		public FoliageRustleSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x0012E394 File Offset: 0x0012C594
		// (set) Token: 0x060035C1 RID: 13761 RVA: 0x0001B4D6 File Offset: 0x000196D6
		public unsafe static float ACTIVATION_RANGE_SQUARED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED, (void*)(&value));
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x0012E3B0 File Offset: 0x0012C5B0
		// (set) Token: 0x060035C3 RID: 13763 RVA: 0x0001B4E4 File Offset: 0x000196E4
		public unsafe static float COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x0012E3CC File Offset: 0x0012C5CC
		// (set) Token: 0x060035C5 RID: 13765 RVA: 0x0001B4F2 File Offset: 0x000196F2
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x0012E3FC File Offset: 0x0012C5FC
		// (set) Token: 0x060035C7 RID: 13767 RVA: 0x0001B511 File Offset: 0x00019711
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x0012E42C File Offset: 0x0012C62C
		// (set) Token: 0x060035C9 RID: 13769 RVA: 0x0001B530 File Offset: 0x00019730
		public unsafe float timeOnLastHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit)) = value;
			}
		}

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED;

		// Token: 0x04002400 RID: 9216
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN;

		// Token: 0x04002401 RID: 9217
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x04002402 RID: 9218
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastHit;

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002405 RID: 9221
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04002406 RID: 9222
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04002407 RID: 9223
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActive_Private_Void_0;

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

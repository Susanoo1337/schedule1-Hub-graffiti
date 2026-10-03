using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x02000109 RID: 265
	public class AnalogueClock : MonoBehaviour
	{
		// Token: 0x060019A3 RID: 6563 RVA: 0x000CF5AC File Offset: 0x000CD7AC
		// Note: this type is marked as 'beforefieldinit'.
		static AnalogueClock()
		{
			Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "AnalogueClock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr);
			AnalogueClock.NativeFieldInfoPtr_MinHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "MinHand");
			AnalogueClock.NativeFieldInfoPtr_HourHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "HourHand");
			AnalogueClock.NativeFieldInfoPtr_RotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "RotationAxis");
			AnalogueClock.NativeFieldInfoPtr_onNoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "onNoon");
			AnalogueClock.NativeFieldInfoPtr_onMidnight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "onMidnight");
			AnalogueClock.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100666703);
			AnalogueClock.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100666704);
			AnalogueClock.NativeMethodInfoPtr_MinPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100666705);
			AnalogueClock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100666706);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x000CF690 File Offset: 0x000CD890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99171, XrefRangeEnd = 99194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000CF6C4 File Offset: 0x000CD8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99194, XrefRangeEnd = 99209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x000CF6F8 File Offset: 0x000CD8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99220, RefRangeEnd = 99221, XrefRangeStart = 99209, XrefRangeEnd = 99220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr_MinPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x000CF72C File Offset: 0x000CD92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99221, XrefRangeEnd = 99224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalogueClock() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0000E1B7 File Offset: 0x0000C3B7
		public AnalogueClock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x000CF768 File Offset: 0x000CD968
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		public unsafe Transform MinHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_MinHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_MinHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x000CF798 File Offset: 0x000CD998
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x0000E1DF File Offset: 0x0000C3DF
		public unsafe Transform HourHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_HourHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_HourHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x000CF7C8 File Offset: 0x000CD9C8
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x0000E1FE File Offset: 0x0000C3FE
		public unsafe Vector3 RotationAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_RotationAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_RotationAxis)) = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x000CF7F0 File Offset: 0x000CD9F0
		// (set) Token: 0x060019B0 RID: 6576 RVA: 0x0000E219 File Offset: 0x0000C419
		public unsafe UnityEvent onNoon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onNoon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onNoon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x000CF820 File Offset: 0x000CDA20
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x0000E238 File Offset: 0x0000C438
		public unsafe UnityEvent onMidnight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onMidnight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onMidnight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_MinHand;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_HourHand;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_RotationAxis;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_onNoon;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr_onMidnight;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Public_Void_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

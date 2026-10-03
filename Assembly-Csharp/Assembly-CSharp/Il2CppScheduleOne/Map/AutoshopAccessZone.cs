using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002AF RID: 687
	public class AutoshopAccessZone : NPCPresenceAccessZone
	{
		// Token: 0x0600353D RID: 13629 RVA: 0x0012C8B0 File Offset: 0x0012AAB0
		// Note: this type is marked as 'beforefieldinit'.
		static AutoshopAccessZone()
		{
			Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "AutoshopAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr);
			AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "RollerDoorAnim");
			AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "VehicleDetection");
			AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "rollerDoorOpen");
			AutoshopAccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100670054);
			AutoshopAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100670055);
			AutoshopAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100670056);
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x0012C958 File Offset: 0x0012AB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141221, XrefRangeEnd = 141227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoshopAccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x0012C9A4 File Offset: 0x0012ABA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141227, XrefRangeEnd = 141238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoshopAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x0012C9E0 File Offset: 0x0012ABE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141238, XrefRangeEnd = 141239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoshopAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoshopAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x0001B0E3 File Offset: 0x000192E3
		public AutoshopAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x0012CA1C File Offset: 0x0012AC1C
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x0001B0EC File Offset: 0x000192EC
		public unsafe Animation RollerDoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x0012CA4C File Offset: 0x0012AC4C
		// (set) Token: 0x06003545 RID: 13637 RVA: 0x0001B10B File Offset: 0x0001930B
		public unsafe VehicleDetector VehicleDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06003546 RID: 13638 RVA: 0x0012CA7C File Offset: 0x0012AC7C
		// (set) Token: 0x06003547 RID: 13639 RVA: 0x0001B12A File Offset: 0x0001932A
		public unsafe bool rollerDoorOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen)) = value;
			}
		}

		// Token: 0x040023A8 RID: 9128
		private static readonly IntPtr NativeFieldInfoPtr_RollerDoorAnim;

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeFieldInfoPtr_VehicleDetection;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeFieldInfoPtr_rollerDoorOpen;

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

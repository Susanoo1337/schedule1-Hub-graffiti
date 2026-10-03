using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Misc;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002AE RID: 686
	public class AccessZone : MonoBehaviour
	{
		// Token: 0x06003528 RID: 13608 RVA: 0x0012C518 File Offset: 0x0012A718
		// Note: this type is marked as 'beforefieldinit'.
		static AccessZone()
		{
			Il2CppClassPointerStore<AccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "AccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessZone>.NativeClassPtr);
			AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "<IsOpen>k__BackingField");
			AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "AllowExitWhenClosed");
			AccessZone.NativeFieldInfoPtr_AutoCloseDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "AutoCloseDoor");
			AccessZone.NativeFieldInfoPtr_Doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "Doors");
			AccessZone.NativeFieldInfoPtr_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "Lights");
			AccessZone.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "onOpen");
			AccessZone.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "onClose");
			AccessZone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100670049);
			AccessZone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100670050);
			AccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100670051);
			AccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100670052);
			AccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100670053);
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06003529 RID: 13609 RVA: 0x0012C638 File Offset: 0x0012A838
		// (set) Token: 0x0600352A RID: 13610 RVA: 0x0012C674 File Offset: 0x0012A874
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x0012C6B4 File Offset: 0x0012A8B4
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x0012C6F0 File Offset: 0x0012A8F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141218, RefRangeEnd = 141219, XrefRangeStart = 141209, XrefRangeEnd = 141218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x0012C73C File Offset: 0x0012A93C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141220, RefRangeEnd = 141221, XrefRangeStart = 141219, XrefRangeEnd = 141220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x0001B00D File Offset: 0x0001920D
		public AccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x0012C778 File Offset: 0x0012A978
		// (set) Token: 0x06003530 RID: 13616 RVA: 0x0001B016 File Offset: 0x00019216
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x0012C7A0 File Offset: 0x0012A9A0
		// (set) Token: 0x06003532 RID: 13618 RVA: 0x0001B031 File Offset: 0x00019231
		public unsafe bool AllowExitWhenClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed)) = value;
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06003533 RID: 13619 RVA: 0x0012C7C8 File Offset: 0x0012A9C8
		// (set) Token: 0x06003534 RID: 13620 RVA: 0x0001B04C File Offset: 0x0001924C
		public unsafe bool AutoCloseDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AutoCloseDoor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AutoCloseDoor)) = value;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06003535 RID: 13621 RVA: 0x0012C7F0 File Offset: 0x0012A9F0
		// (set) Token: 0x06003536 RID: 13622 RVA: 0x0001B067 File Offset: 0x00019267
		public unsafe Il2CppReferenceArray<DoorController> Doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DoorController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06003537 RID: 13623 RVA: 0x0012C820 File Offset: 0x0012AA20
		// (set) Token: 0x06003538 RID: 13624 RVA: 0x0001B086 File Offset: 0x00019286
		public unsafe Il2CppReferenceArray<ToggleableLight> Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToggleableLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06003539 RID: 13625 RVA: 0x0012C850 File Offset: 0x0012AA50
		// (set) Token: 0x0600353A RID: 13626 RVA: 0x0001B0A5 File Offset: 0x000192A5
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x0600353B RID: 13627 RVA: 0x0012C880 File Offset: 0x0012AA80
		// (set) Token: 0x0600353C RID: 13628 RVA: 0x0001B0C4 File Offset: 0x000192C4
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400239C RID: 9116
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400239D RID: 9117
		private static readonly IntPtr NativeFieldInfoPtr_AllowExitWhenClosed;

		// Token: 0x0400239E RID: 9118
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseDoor;

		// Token: 0x0400239F RID: 9119
		private static readonly IntPtr NativeFieldInfoPtr_Doors;

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeFieldInfoPtr_Lights;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040023A6 RID: 9126
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040023A7 RID: 9127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

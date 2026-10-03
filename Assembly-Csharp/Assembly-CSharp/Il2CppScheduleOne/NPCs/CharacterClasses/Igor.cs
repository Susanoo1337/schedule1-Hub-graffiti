using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.Schedules;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200061E RID: 1566
	public class Igor : NPC
	{
		// Token: 0x06009742 RID: 38722 RVA: 0x0028A938 File Offset: 0x00288B38
		// Note: this type is marked as 'beforefieldinit'.
		static Igor()
		{
			Il2CppClassPointerStore<Igor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Igor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Igor>.NativeClassPtr);
			Igor.NativeFieldInfoPtr_DoorGuardEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Igor>.NativeClassPtr, "DoorGuardEvent");
			Igor.NativeFieldInfoPtr_OfficeGuardEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Igor>.NativeClassPtr, "OfficeGuardEvent");
			Igor.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Igor>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.IgorAssembly-CSharp.dll_Excuted");
			Igor.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Igor>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.IgorAssembly-CSharp.dll_Excuted");
			Igor.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Igor>.NativeClassPtr, 100683003);
			Igor.NativeMethodInfoPtr_GuardDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Igor>.NativeClassPtr, 100683004);
			Igor.NativeMethodInfoPtr_GuardOffice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Igor>.NativeClassPtr, 100683005);
			Igor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Igor>.NativeClassPtr, 100683006);
			Igor.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Igor>.NativeClassPtr, 100683007);
			Igor.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Igor>.NativeClassPtr, 100683008);
			Igor.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Igor>.NativeClassPtr, 100683009);
			Igor.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Igor>.NativeClassPtr, 100683010);
		}

		// Token: 0x06009743 RID: 38723 RVA: 0x0028AA58 File Offset: 0x00288C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273131, XrefRangeEnd = 273155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Igor.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009744 RID: 38724 RVA: 0x0028AA94 File Offset: 0x00288C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273155, XrefRangeEnd = 273160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Igor.NativeMethodInfoPtr_GuardDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009745 RID: 38725 RVA: 0x0028AAC8 File Offset: 0x00288CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273160, XrefRangeEnd = 273165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardOffice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Igor.NativeMethodInfoPtr_GuardOffice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009746 RID: 38726 RVA: 0x0028AAFC File Offset: 0x00288CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Igor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Igor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Igor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009747 RID: 38727 RVA: 0x0028AB38 File Offset: 0x00288D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Igor.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009748 RID: 38728 RVA: 0x0028AB74 File Offset: 0x00288D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Igor.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009749 RID: 38729 RVA: 0x0028ABB0 File Offset: 0x00288DB0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Igor.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600974A RID: 38730 RVA: 0x0028ABEC File Offset: 0x00288DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Igor.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600974B RID: 38731 RVA: 0x00046B27 File Offset: 0x00044D27
		public Igor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0600974C RID: 38732 RVA: 0x0028AC28 File Offset: 0x00288E28
		// (set) Token: 0x0600974D RID: 38733 RVA: 0x00046B30 File Offset: 0x00044D30
		public unsafe NPCEvent DoorGuardEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Igor.NativeFieldInfoPtr_DoorGuardEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Igor.NativeFieldInfoPtr_DoorGuardEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0600974E RID: 38734 RVA: 0x0028AC58 File Offset: 0x00288E58
		// (set) Token: 0x0600974F RID: 38735 RVA: 0x00046B4F File Offset: 0x00044D4F
		public unsafe NPCEvent OfficeGuardEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Igor.NativeFieldInfoPtr_OfficeGuardEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Igor.NativeFieldInfoPtr_OfficeGuardEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x06009750 RID: 38736 RVA: 0x0028AC88 File Offset: 0x00288E88
		// (set) Token: 0x06009751 RID: 38737 RVA: 0x00046B6E File Offset: 0x00044D6E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Igor.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Igor.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x06009752 RID: 38738 RVA: 0x0028ACB0 File Offset: 0x00288EB0
		// (set) Token: 0x06009753 RID: 38739 RVA: 0x00046B89 File Offset: 0x00044D89
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Igor.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Igor.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040067FE RID: 26622
		private static readonly IntPtr NativeFieldInfoPtr_DoorGuardEvent;

		// Token: 0x040067FF RID: 26623
		private static readonly IntPtr NativeFieldInfoPtr_OfficeGuardEvent;

		// Token: 0x04006800 RID: 26624
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006801 RID: 26625
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006802 RID: 26626
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006803 RID: 26627
		private static readonly IntPtr NativeMethodInfoPtr_GuardDoor_Private_Void_0;

		// Token: 0x04006804 RID: 26628
		private static readonly IntPtr NativeMethodInfoPtr_GuardOffice_Private_Void_0;

		// Token: 0x04006805 RID: 26629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006806 RID: 26630
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006807 RID: 26631
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006808 RID: 26632
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006809 RID: 26633
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

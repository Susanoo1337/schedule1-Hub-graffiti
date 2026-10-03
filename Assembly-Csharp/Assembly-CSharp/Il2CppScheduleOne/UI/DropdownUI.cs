using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200072F RID: 1839
	public class DropdownUI : Dropdown
	{
		// Token: 0x0600B176 RID: 45430 RVA: 0x002E5474 File Offset: 0x002E3674
		// Note: this type is marked as 'beforefieldinit'.
		static DropdownUI()
		{
			Il2CppClassPointerStore<DropdownUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DropdownUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownUI>.NativeClassPtr);
			DropdownUI.NativeFieldInfoPtr_OnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownUI>.NativeClassPtr, "OnOpen");
			DropdownUI.NativeMethodInfoPtr_add_OnOpen_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownUI>.NativeClassPtr, 100686630);
			DropdownUI.NativeMethodInfoPtr_remove_OnOpen_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownUI>.NativeClassPtr, 100686631);
			DropdownUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownUI>.NativeClassPtr, 100686632);
			DropdownUI.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownUI>.NativeClassPtr, 100686633);
			DropdownUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownUI>.NativeClassPtr, 100686634);
		}

		// Token: 0x0600B177 RID: 45431 RVA: 0x002E551C File Offset: 0x002E371C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301029, RefRangeEnd = 301030, XrefRangeStart = 301025, XrefRangeEnd = 301029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnOpen(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownUI.NativeMethodInfoPtr_add_OnOpen_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x002E5560 File Offset: 0x002E3760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301030, XrefRangeEnd = 301034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnOpen(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownUI.NativeMethodInfoPtr_remove_OnOpen_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x002E55A4 File Offset: 0x002E37A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301034, XrefRangeEnd = 301035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DropdownUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x002E55E0 File Offset: 0x002E37E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301035, XrefRangeEnd = 301036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DropdownUI.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B17B RID: 45435 RVA: 0x002E5630 File Offset: 0x002E3830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301036, XrefRangeEnd = 301040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B17C RID: 45436 RVA: 0x00051955 File Offset: 0x0004FB55
		public DropdownUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0600B17D RID: 45437 RVA: 0x002E566C File Offset: 0x002E386C
		// (set) Token: 0x0600B17E RID: 45438 RVA: 0x0005195E File Offset: 0x0004FB5E
		public unsafe Action OnOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownUI.NativeFieldInfoPtr_OnOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownUI.NativeFieldInfoPtr_OnOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A46 RID: 31302
		private static readonly IntPtr NativeFieldInfoPtr_OnOpen;

		// Token: 0x04007A47 RID: 31303
		private static readonly IntPtr NativeMethodInfoPtr_add_OnOpen_Public_add_Void_Action_0;

		// Token: 0x04007A48 RID: 31304
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnOpen_Public_rem_Void_Action_0;

		// Token: 0x04007A49 RID: 31305
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007A4A RID: 31306
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04007A4B RID: 31307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

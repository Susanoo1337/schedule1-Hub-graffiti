using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007EB RID: 2027
	public class MushroomBedUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C5D9 RID: 50649 RVA: 0x003228F8 File Offset: 0x00320AF8
		// Note: this type is marked as 'beforefieldinit'.
		static MushroomBedUIElement()
		{
			Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "MushroomBedUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr);
			MushroomBedUIElement.NativeFieldInfoPtr_SpawnIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, "SpawnIcon");
			MushroomBedUIElement.NativeFieldInfoPtr_NoSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, "NoSpawn");
			MushroomBedUIElement.NativeFieldInfoPtr_Additive1Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, "Additive1Icon");
			MushroomBedUIElement.NativeFieldInfoPtr_Additive2Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, "Additive2Icon");
			MushroomBedUIElement.NativeFieldInfoPtr_Additive3Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, "Additive3Icon");
			MushroomBedUIElement.NativeFieldInfoPtr__AssignedMustroomBed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, "<AssignedMustroomBed>k__BackingField");
			MushroomBedUIElement.NativeMethodInfoPtr_get_AssignedMustroomBed_Public_get_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, 100688933);
			MushroomBedUIElement.NativeMethodInfoPtr_set_AssignedMustroomBed_Protected_set_Void_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, 100688934);
			MushroomBedUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, 100688935);
			MushroomBedUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, 100688936);
			MushroomBedUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr, 100688937);
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x0600C5DA RID: 50650 RVA: 0x00322A04 File Offset: 0x00320C04
		// (set) Token: 0x0600C5DB RID: 50651 RVA: 0x00322A44 File Offset: 0x00320C44
		public unsafe MushroomBed AssignedMustroomBed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedUIElement.NativeMethodInfoPtr_get_AssignedMustroomBed_Public_get_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedUIElement.NativeMethodInfoPtr_set_AssignedMustroomBed_Protected_set_Void_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C5DC RID: 50652 RVA: 0x00322A88 File Offset: 0x00320C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327300, RefRangeEnd = 327301, XrefRangeStart = 327290, XrefRangeEnd = 327300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MushroomBed bed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5DD RID: 50653 RVA: 0x00322ACC File Offset: 0x00320CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327301, XrefRangeEnd = 327341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5DE RID: 50654 RVA: 0x00322B08 File Offset: 0x00320D08
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomBedUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomBedUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5DF RID: 50655 RVA: 0x0005D631 File Offset: 0x0005B831
		public MushroomBedUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x0600C5E0 RID: 50656 RVA: 0x00322B44 File Offset: 0x00320D44
		// (set) Token: 0x0600C5E1 RID: 50657 RVA: 0x0005D63A File Offset: 0x0005B83A
		public unsafe Image SpawnIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr_SpawnIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr_SpawnIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x0600C5E2 RID: 50658 RVA: 0x00322B74 File Offset: 0x00320D74
		// (set) Token: 0x0600C5E3 RID: 50659 RVA: 0x0005D659 File Offset: 0x0005B859
		public unsafe GameObject NoSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr_NoSpawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr_NoSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x0600C5E4 RID: 50660 RVA: 0x00322BA4 File Offset: 0x00320DA4
		// (set) Token: 0x0600C5E5 RID: 50661 RVA: 0x0005D678 File Offset: 0x0005B878
		public unsafe Image Additive1Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr_Additive1Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr_Additive1Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x0600C5E6 RID: 50662 RVA: 0x00322BD4 File Offset: 0x00320DD4
		// (set) Token: 0x0600C5E7 RID: 50663 RVA: 0x0005D697 File Offset: 0x0005B897
		public unsafe Image Additive2Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr_Additive2Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr_Additive2Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x0600C5E8 RID: 50664 RVA: 0x00322C04 File Offset: 0x00320E04
		// (set) Token: 0x0600C5E9 RID: 50665 RVA: 0x0005D6B6 File Offset: 0x0005B8B6
		public unsafe Image Additive3Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr_Additive3Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr_Additive3Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x0600C5EA RID: 50666 RVA: 0x00322C34 File Offset: 0x00320E34
		// (set) Token: 0x0600C5EB RID: 50667 RVA: 0x0005D6D5 File Offset: 0x0005B8D5
		public unsafe MushroomBed _AssignedMustroomBed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr__AssignedMustroomBed_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedUIElement.NativeFieldInfoPtr__AssignedMustroomBed_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040086FF RID: 34559
		private static readonly IntPtr NativeFieldInfoPtr_SpawnIcon;

		// Token: 0x04008700 RID: 34560
		private static readonly IntPtr NativeFieldInfoPtr_NoSpawn;

		// Token: 0x04008701 RID: 34561
		private static readonly IntPtr NativeFieldInfoPtr_Additive1Icon;

		// Token: 0x04008702 RID: 34562
		private static readonly IntPtr NativeFieldInfoPtr_Additive2Icon;

		// Token: 0x04008703 RID: 34563
		private static readonly IntPtr NativeFieldInfoPtr_Additive3Icon;

		// Token: 0x04008704 RID: 34564
		private static readonly IntPtr NativeFieldInfoPtr__AssignedMustroomBed_k__BackingField;

		// Token: 0x04008705 RID: 34565
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedMustroomBed_Public_get_MushroomBed_0;

		// Token: 0x04008706 RID: 34566
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedMustroomBed_Protected_set_Void_MushroomBed_0;

		// Token: 0x04008707 RID: 34567
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MushroomBed_0;

		// Token: 0x04008708 RID: 34568
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04008709 RID: 34569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007EE RID: 2030
	public class PotUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C600 RID: 50688 RVA: 0x003230D8 File Offset: 0x003212D8
		// Note: this type is marked as 'beforefieldinit'.
		static PotUIElement()
		{
			Il2CppClassPointerStore<PotUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PotUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr);
			PotUIElement.NativeFieldInfoPtr_SeedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "SeedIcon");
			PotUIElement.NativeFieldInfoPtr_NoSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "NoSeed");
			PotUIElement.NativeFieldInfoPtr_Additive1Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive1Icon");
			PotUIElement.NativeFieldInfoPtr_Additive2Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive2Icon");
			PotUIElement.NativeFieldInfoPtr_Additive3Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive3Icon");
			PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "<AssignedPot>k__BackingField");
			PotUIElement.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100688948);
			PotUIElement.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100688949);
			PotUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100688950);
			PotUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100688951);
			PotUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100688952);
		}

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x0600C601 RID: 50689 RVA: 0x003231E4 File Offset: 0x003213E4
		// (set) Token: 0x0600C602 RID: 50690 RVA: 0x00323224 File Offset: 0x00321424
		public unsafe Pot AssignedPot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C603 RID: 50691 RVA: 0x00323268 File Offset: 0x00321468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327403, RefRangeEnd = 327404, XrefRangeStart = 327393, XrefRangeEnd = 327403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C604 RID: 50692 RVA: 0x003232AC File Offset: 0x003214AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327404, XrefRangeEnd = 327444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C605 RID: 50693 RVA: 0x003232E8 File Offset: 0x003214E8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C606 RID: 50694 RVA: 0x0005D763 File Offset: 0x0005B963
		public PotUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x0600C607 RID: 50695 RVA: 0x00323324 File Offset: 0x00321524
		// (set) Token: 0x0600C608 RID: 50696 RVA: 0x0005D76C File Offset: 0x0005B96C
		public unsafe Image SeedIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_SeedIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_SeedIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x0600C609 RID: 50697 RVA: 0x00323354 File Offset: 0x00321554
		// (set) Token: 0x0600C60A RID: 50698 RVA: 0x0005D78B File Offset: 0x0005B98B
		public unsafe GameObject NoSeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_NoSeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_NoSeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x0600C60B RID: 50699 RVA: 0x00323384 File Offset: 0x00321584
		// (set) Token: 0x0600C60C RID: 50700 RVA: 0x0005D7AA File Offset: 0x0005B9AA
		public unsafe Image Additive1Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive1Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive1Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x0600C60D RID: 50701 RVA: 0x003233B4 File Offset: 0x003215B4
		// (set) Token: 0x0600C60E RID: 50702 RVA: 0x0005D7C9 File Offset: 0x0005B9C9
		public unsafe Image Additive2Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive2Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive2Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x0600C60F RID: 50703 RVA: 0x003233E4 File Offset: 0x003215E4
		// (set) Token: 0x0600C610 RID: 50704 RVA: 0x0005D7E8 File Offset: 0x0005B9E8
		public unsafe Image Additive3Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive3Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive3Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x0600C611 RID: 50705 RVA: 0x00323414 File Offset: 0x00321614
		// (set) Token: 0x0600C612 RID: 50706 RVA: 0x0005D807 File Offset: 0x0005BA07
		public unsafe Pot _AssignedPot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008717 RID: 34583
		private static readonly IntPtr NativeFieldInfoPtr_SeedIcon;

		// Token: 0x04008718 RID: 34584
		private static readonly IntPtr NativeFieldInfoPtr_NoSeed;

		// Token: 0x04008719 RID: 34585
		private static readonly IntPtr NativeFieldInfoPtr_Additive1Icon;

		// Token: 0x0400871A RID: 34586
		private static readonly IntPtr NativeFieldInfoPtr_Additive2Icon;

		// Token: 0x0400871B RID: 34587
		private static readonly IntPtr NativeFieldInfoPtr_Additive3Icon;

		// Token: 0x0400871C RID: 34588
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPot_k__BackingField;

		// Token: 0x0400871D RID: 34589
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0;

		// Token: 0x0400871E RID: 34590
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0;

		// Token: 0x0400871F RID: 34591
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Pot_0;

		// Token: 0x04008720 RID: 34592
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04008721 RID: 34593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007E8 RID: 2024
	public class DryingRackUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C5BC RID: 50620 RVA: 0x0032226C File Offset: 0x0032046C
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackUIElement()
		{
			Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "DryingRackUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr);
			DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, "<AssignedRack>k__BackingField");
			DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, "TargetQualityIcon");
			DryingRackUIElement.NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100688918);
			DryingRackUIElement.NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100688919);
			DryingRackUIElement.NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100688920);
			DryingRackUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100688921);
			DryingRackUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100688922);
		}

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x0600C5BD RID: 50621 RVA: 0x00322328 File Offset: 0x00320528
		// (set) Token: 0x0600C5BE RID: 50622 RVA: 0x00322368 File Offset: 0x00320568
		public unsafe DryingRack AssignedRack
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C5BF RID: 50623 RVA: 0x003223AC File Offset: 0x003205AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327248, RefRangeEnd = 327249, XrefRangeStart = 327238, XrefRangeEnd = 327248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5C0 RID: 50624 RVA: 0x003223F0 File Offset: 0x003205F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327249, XrefRangeEnd = 327258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5C1 RID: 50625 RVA: 0x0032242C File Offset: 0x0032062C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5C2 RID: 50626 RVA: 0x0005D59A File Offset: 0x0005B79A
		public DryingRackUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x0600C5C3 RID: 50627 RVA: 0x00322468 File Offset: 0x00320668
		// (set) Token: 0x0600C5C4 RID: 50628 RVA: 0x0005D5A3 File Offset: 0x0005B7A3
		public unsafe DryingRack _AssignedRack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x0600C5C5 RID: 50629 RVA: 0x00322498 File Offset: 0x00320698
		// (set) Token: 0x0600C5C6 RID: 50630 RVA: 0x0005D5C2 File Offset: 0x0005B7C2
		public unsafe Image TargetQualityIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040086EC RID: 34540
		private static readonly IntPtr NativeFieldInfoPtr__AssignedRack_k__BackingField;

		// Token: 0x040086ED RID: 34541
		private static readonly IntPtr NativeFieldInfoPtr_TargetQualityIcon;

		// Token: 0x040086EE RID: 34542
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0;

		// Token: 0x040086EF RID: 34543
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0;

		// Token: 0x040086F0 RID: 34544
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0;

		// Token: 0x040086F1 RID: 34545
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040086F2 RID: 34546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

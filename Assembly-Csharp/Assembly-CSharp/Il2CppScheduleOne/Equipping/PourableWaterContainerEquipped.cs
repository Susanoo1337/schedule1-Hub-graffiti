using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Tools;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x0200058A RID: 1418
	public class PourableWaterContainerEquipped : Equippable_Pourable
	{
		// Token: 0x0600815B RID: 33115 RVA: 0x002370D0 File Offset: 0x002352D0
		// Note: this type is marked as 'beforefieldinit'.
		static PourableWaterContainerEquipped()
		{
			Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "PourableWaterContainerEquipped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr);
			PourableWaterContainerEquipped.NativeFieldInfoPtr__visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr, "_visuals");
			PourableWaterContainerEquipped.NativeFieldInfoPtr__pourablePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr, "_pourablePrefab");
			PourableWaterContainerEquipped.NativeFieldInfoPtr__waterContainerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr, "_waterContainerInstance");
			PourableWaterContainerEquipped.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr, 100679914);
			PourableWaterContainerEquipped.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr, 100679915);
			PourableWaterContainerEquipped.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_GrowContainer_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr, 100679916);
			PourableWaterContainerEquipped.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr, 100679917);
			PourableWaterContainerEquipped.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr, 100679918);
		}

		// Token: 0x0600815C RID: 33116 RVA: 0x002371A0 File Offset: 0x002353A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244955, XrefRangeEnd = 244966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableWaterContainerEquipped.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600815D RID: 33117 RVA: 0x002371F0 File Offset: 0x002353F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244966, XrefRangeEnd = 244973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableWaterContainerEquipped.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600815E RID: 33118 RVA: 0x0023722C File Offset: 0x0023542C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244973, XrefRangeEnd = 244983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour(GrowContainer growContainer, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableWaterContainerEquipped.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_GrowContainer_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600815F RID: 33119 RVA: 0x002372A0 File Offset: 0x002354A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244983, XrefRangeEnd = 244987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartPourTask(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableWaterContainerEquipped.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008160 RID: 33120 RVA: 0x002372F0 File Offset: 0x002354F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableWaterContainerEquipped() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableWaterContainerEquipped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableWaterContainerEquipped.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008161 RID: 33121 RVA: 0x0003D8BF File Offset: 0x0003BABF
		public PourableWaterContainerEquipped(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x06008162 RID: 33122 RVA: 0x0023732C File Offset: 0x0023552C
		// (set) Token: 0x06008163 RID: 33123 RVA: 0x0003D8C8 File Offset: 0x0003BAC8
		public unsafe WaterContainerVisualizer _visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableWaterContainerEquipped.NativeFieldInfoPtr__visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableWaterContainerEquipped.NativeFieldInfoPtr__visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x06008164 RID: 33124 RVA: 0x0023735C File Offset: 0x0023555C
		// (set) Token: 0x06008165 RID: 33125 RVA: 0x0003D8E7 File Offset: 0x0003BAE7
		public unsafe WaterContainerPourable _pourablePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableWaterContainerEquipped.NativeFieldInfoPtr__pourablePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerPourable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableWaterContainerEquipped.NativeFieldInfoPtr__pourablePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x06008166 RID: 33126 RVA: 0x0023738C File Offset: 0x0023558C
		// (set) Token: 0x06008167 RID: 33127 RVA: 0x0003D906 File Offset: 0x0003BB06
		public unsafe WaterContainerInstance _waterContainerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableWaterContainerEquipped.NativeFieldInfoPtr__waterContainerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableWaterContainerEquipped.NativeFieldInfoPtr__waterContainerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400582E RID: 22574
		private static readonly IntPtr NativeFieldInfoPtr__visuals;

		// Token: 0x0400582F RID: 22575
		private static readonly IntPtr NativeFieldInfoPtr__pourablePrefab;

		// Token: 0x04005830 RID: 22576
		private static readonly IntPtr NativeFieldInfoPtr__waterContainerInstance;

		// Token: 0x04005831 RID: 22577
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005832 RID: 22578
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005833 RID: 22579
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_GrowContainer_byref_String_0;

		// Token: 0x04005834 RID: 22580
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_GrowContainer_0;

		// Token: 0x04005835 RID: 22581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000574 RID: 1396
	public class Equippable_Cuke : Equippable_Viewmodel
	{
		// Token: 0x06007F50 RID: 32592 RVA: 0x00230F70 File Offset: 0x0022F170
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Cuke()
		{
			Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Cuke");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr);
			Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "<IsDrinking>k__BackingField");
			Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "BaseEnergyGain");
			Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "MinEnergyGain");
			Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "ConsecutiveReduction");
			Equippable_Cuke.NativeFieldInfoPtr_HealthGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "HealthGain");
			Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "AnimationDuration");
			Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "ClearDrugEffects");
			Equippable_Cuke.NativeFieldInfoPtr_PseudoProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "PseudoProduct");
			Equippable_Cuke.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "OpenAnim");
			Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "DrinkAnim");
			Equippable_Cuke.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "OpenSound");
			Equippable_Cuke.NativeFieldInfoPtr_SlurpSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "SlurpSound");
			Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "TrashPrefab");
			Equippable_Cuke.NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679716);
			Equippable_Cuke.NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679717);
			Equippable_Cuke.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679718);
			Equippable_Cuke.NativeMethodInfoPtr_Drink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679719);
			Equippable_Cuke.NativeMethodInfoPtr_ApplyEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679720);
			Equippable_Cuke.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679721);
			Equippable_Cuke.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679722);
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x06007F51 RID: 32593 RVA: 0x00231130 File Offset: 0x0022F330
		// (set) Token: 0x06007F52 RID: 32594 RVA: 0x0023116C File Offset: 0x0022F36C
		public unsafe bool IsDrinking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007F53 RID: 32595 RVA: 0x002311AC File Offset: 0x0022F3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243148, XrefRangeEnd = 243165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cuke.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F54 RID: 32596 RVA: 0x002311E8 File Offset: 0x0022F3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243165, XrefRangeEnd = 243171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Drink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_Drink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F55 RID: 32597 RVA: 0x0023121C File Offset: 0x0022F41C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243200, RefRangeEnd = 243201, XrefRangeStart = 243171, XrefRangeEnd = 243200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_ApplyEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x00231250 File Offset: 0x0022F450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243201, XrefRangeEnd = 243204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Cuke() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F57 RID: 32599 RVA: 0x0023128C File Offset: 0x0022F48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243204, XrefRangeEnd = 243209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x0003C6DB File Offset: 0x0003A8DB
		public Equippable_Cuke(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x06007F59 RID: 32601 RVA: 0x002312CC File Offset: 0x0022F4CC
		// (set) Token: 0x06007F5A RID: 32602 RVA: 0x0003C6E4 File Offset: 0x0003A8E4
		public unsafe bool _IsDrinking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField)) = value;
			}
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x06007F5B RID: 32603 RVA: 0x002312F4 File Offset: 0x0022F4F4
		// (set) Token: 0x06007F5C RID: 32604 RVA: 0x0003C6FF File Offset: 0x0003A8FF
		public unsafe float BaseEnergyGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain)) = value;
			}
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x06007F5D RID: 32605 RVA: 0x0023131C File Offset: 0x0022F51C
		// (set) Token: 0x06007F5E RID: 32606 RVA: 0x0003C71A File Offset: 0x0003A91A
		public unsafe float MinEnergyGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain)) = value;
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x06007F5F RID: 32607 RVA: 0x00231344 File Offset: 0x0022F544
		// (set) Token: 0x06007F60 RID: 32608 RVA: 0x0003C735 File Offset: 0x0003A935
		public unsafe float ConsecutiveReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction)) = value;
			}
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x06007F61 RID: 32609 RVA: 0x0023136C File Offset: 0x0022F56C
		// (set) Token: 0x06007F62 RID: 32610 RVA: 0x0003C750 File Offset: 0x0003A950
		public unsafe float HealthGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_HealthGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_HealthGain)) = value;
			}
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x06007F63 RID: 32611 RVA: 0x00231394 File Offset: 0x0022F594
		// (set) Token: 0x06007F64 RID: 32612 RVA: 0x0003C76B File Offset: 0x0003A96B
		public unsafe float AnimationDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration)) = value;
			}
		}

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x06007F65 RID: 32613 RVA: 0x002313BC File Offset: 0x0022F5BC
		// (set) Token: 0x06007F66 RID: 32614 RVA: 0x0003C786 File Offset: 0x0003A986
		public unsafe bool ClearDrugEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects)) = value;
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x06007F67 RID: 32615 RVA: 0x002313E4 File Offset: 0x0022F5E4
		// (set) Token: 0x06007F68 RID: 32616 RVA: 0x0003C7A1 File Offset: 0x0003A9A1
		public unsafe ProductDefinition PseudoProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_PseudoProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_PseudoProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x06007F69 RID: 32617 RVA: 0x00231414 File Offset: 0x0022F614
		// (set) Token: 0x06007F6A RID: 32618 RVA: 0x0003C7C0 File Offset: 0x0003A9C0
		public unsafe Animation OpenAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x06007F6B RID: 32619 RVA: 0x00231444 File Offset: 0x0022F644
		// (set) Token: 0x06007F6C RID: 32620 RVA: 0x0003C7DF File Offset: 0x0003A9DF
		public unsafe Animation DrinkAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x06007F6D RID: 32621 RVA: 0x00231474 File Offset: 0x0022F674
		// (set) Token: 0x06007F6E RID: 32622 RVA: 0x0003C7FE File Offset: 0x0003A9FE
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x06007F6F RID: 32623 RVA: 0x002314A4 File Offset: 0x0022F6A4
		// (set) Token: 0x06007F70 RID: 32624 RVA: 0x0003C81D File Offset: 0x0003AA1D
		public unsafe AudioSourceController SlurpSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_SlurpSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_SlurpSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x06007F71 RID: 32625 RVA: 0x002314D4 File Offset: 0x0022F6D4
		// (set) Token: 0x06007F72 RID: 32626 RVA: 0x0003C83C File Offset: 0x0003AA3C
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040056EB RID: 22251
		private static readonly IntPtr NativeFieldInfoPtr__IsDrinking_k__BackingField;

		// Token: 0x040056EC RID: 22252
		private static readonly IntPtr NativeFieldInfoPtr_BaseEnergyGain;

		// Token: 0x040056ED RID: 22253
		private static readonly IntPtr NativeFieldInfoPtr_MinEnergyGain;

		// Token: 0x040056EE RID: 22254
		private static readonly IntPtr NativeFieldInfoPtr_ConsecutiveReduction;

		// Token: 0x040056EF RID: 22255
		private static readonly IntPtr NativeFieldInfoPtr_HealthGain;

		// Token: 0x040056F0 RID: 22256
		private static readonly IntPtr NativeFieldInfoPtr_AnimationDuration;

		// Token: 0x040056F1 RID: 22257
		private static readonly IntPtr NativeFieldInfoPtr_ClearDrugEffects;

		// Token: 0x040056F2 RID: 22258
		private static readonly IntPtr NativeFieldInfoPtr_PseudoProduct;

		// Token: 0x040056F3 RID: 22259
		private static readonly IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x040056F4 RID: 22260
		private static readonly IntPtr NativeFieldInfoPtr_DrinkAnim;

		// Token: 0x040056F5 RID: 22261
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x040056F6 RID: 22262
		private static readonly IntPtr NativeFieldInfoPtr_SlurpSound;

		// Token: 0x040056F7 RID: 22263
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x040056F8 RID: 22264
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0;

		// Token: 0x040056F9 RID: 22265
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0;

		// Token: 0x040056FA RID: 22266
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040056FB RID: 22267
		private static readonly IntPtr NativeMethodInfoPtr_Drink_Public_Void_0;

		// Token: 0x040056FC RID: 22268
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffects_Public_Void_0;

		// Token: 0x040056FD RID: 22269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040056FE RID: 22270
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BE6 RID: 3046
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_Cuke+<<Drink>g__DrinkRoutine|17_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600EC92 RID: 60562 RVA: 0x0039560C File Offset: 0x0039380C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique()
			{
				Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "<<Drink>g__DrinkRoutine|17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679723);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679724);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679725);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679726);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679727);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679728);
			}

			// Token: 0x0600EC93 RID: 60563 RVA: 0x003956EC File Offset: 0x003938EC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC94 RID: 60564 RVA: 0x00395734 File Offset: 0x00393934
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC95 RID: 60565 RVA: 0x00395768 File Offset: 0x00393968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243097, XrefRangeEnd = 243143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047BC RID: 18364
			// (get) Token: 0x0600EC96 RID: 60566 RVA: 0x003957A4 File Offset: 0x003939A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EC97 RID: 60567 RVA: 0x003957E4 File Offset: 0x003939E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243143, XrefRangeEnd = 243148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047BD RID: 18365
			// (get) Token: 0x0600EC98 RID: 60568 RVA: 0x00395818 File Offset: 0x00393A18
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EC99 RID: 60569 RVA: 0x0006F9C6 File Offset: 0x0006DBC6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047B9 RID: 18361
			// (get) Token: 0x0600EC9A RID: 60570 RVA: 0x00395858 File Offset: 0x00393A58
			// (set) Token: 0x0600EC9B RID: 60571 RVA: 0x0006F9CF File Offset: 0x0006DBCF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047BA RID: 18362
			// (get) Token: 0x0600EC9C RID: 60572 RVA: 0x00395880 File Offset: 0x00393A80
			// (set) Token: 0x0600EC9D RID: 60573 RVA: 0x0006F9EA File Offset: 0x0006DBEA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047BB RID: 18363
			// (get) Token: 0x0600EC9E RID: 60574 RVA: 0x003958B0 File Offset: 0x00393AB0
			// (set) Token: 0x0600EC9F RID: 60575 RVA: 0x0006FA09 File Offset: 0x0006DC09
			public unsafe Equippable_Cuke __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_Cuke>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A027 RID: 40999
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A028 RID: 41000
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A029 RID: 41001
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A02A RID: 41002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A02B RID: 41003
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A02C RID: 41004
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A02D RID: 41005
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A02E RID: 41006
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A02F RID: 41007
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

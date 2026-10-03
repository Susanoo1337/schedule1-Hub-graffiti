using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x0200057B RID: 1403
	public class Equippable_Additive : Equippable_Pourable
	{
		// Token: 0x06007FD3 RID: 32723 RVA: 0x00232610 File Offset: 0x00230810
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Additive()
		{
			Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Additive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr);
			Equippable_Additive.NativeFieldInfoPtr_additiveDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, "additiveDef");
			Equippable_Additive.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679757);
			Equippable_Additive.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679758);
			Equippable_Additive.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_GrowContainer_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679759);
			Equippable_Additive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679760);
		}

		// Token: 0x06007FD4 RID: 32724 RVA: 0x002326A4 File Offset: 0x002308A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243493, XrefRangeEnd = 243505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Additive.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FD5 RID: 32725 RVA: 0x002326F4 File Offset: 0x002308F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243505, XrefRangeEnd = 243509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartPourTask(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Additive.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x00232744 File Offset: 0x00230944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243509, XrefRangeEnd = 243512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour(GrowContainer pot, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Additive.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_GrowContainer_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x002327B8 File Offset: 0x002309B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243512, XrefRangeEnd = 243513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Additive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Additive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x0003CBAB File Offset: 0x0003ADAB
		public Equippable_Additive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x002327F4 File Offset: 0x002309F4
		// (set) Token: 0x06007FDA RID: 32730 RVA: 0x0003CBB4 File Offset: 0x0003ADB4
		public unsafe AdditiveDefinition additiveDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Additive.NativeFieldInfoPtr_additiveDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Additive.NativeFieldInfoPtr_additiveDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005737 RID: 22327
		private static readonly IntPtr NativeFieldInfoPtr_additiveDef;

		// Token: 0x04005738 RID: 22328
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005739 RID: 22329
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_GrowContainer_0;

		// Token: 0x0400573A RID: 22330
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_GrowContainer_byref_String_0;

		// Token: 0x0400573B RID: 22331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

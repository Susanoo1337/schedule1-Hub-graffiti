using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Core.Items.Framework;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000348 RID: 840
	public class ItemFilter_LegalStatus : ItemFilter
	{
		// Token: 0x060047CC RID: 18380 RVA: 0x0016F07C File Offset: 0x0016D27C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_LegalStatus()
		{
			Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_LegalStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr);
			ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, "RequiredLegalStatus");
			ItemFilter_LegalStatus.NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, 100672484);
			ItemFilter_LegalStatus.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, 100672485);
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x0016F0E8 File Offset: 0x0016D2E8
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_LegalStatus(ELegalStatus requiredLegalStatus) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requiredLegalStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_LegalStatus.NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x0016F130 File Offset: 0x0016D330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167018, XrefRangeEnd = 167019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_LegalStatus.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x00023094 File Offset: 0x00021294
		public ItemFilter_LegalStatus(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x0016F188 File Offset: 0x0016D388
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x0002309D File Offset: 0x0002129D
		public unsafe ELegalStatus RequiredLegalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus)) = value;
			}
		}

		// Token: 0x040030CA RID: 12490
		private static readonly IntPtr NativeFieldInfoPtr_RequiredLegalStatus;

		// Token: 0x040030CB RID: 12491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0;

		// Token: 0x040030CC RID: 12492
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200035E RID: 862
	[Serializable]
	public class SlotFilter : Object
	{
		// Token: 0x0600490C RID: 18700 RVA: 0x00173A70 File Offset: 0x00171C70
		// Note: this type is marked as 'beforefieldinit'.
		static SlotFilter()
		{
			Il2CppClassPointerStore<SlotFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "SlotFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr);
			SlotFilter.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, "Type");
			SlotFilter.NativeFieldInfoPtr_ItemIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, "ItemIDs");
			SlotFilter.NativeFieldInfoPtr_AllowedQualities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, "AllowedQualities");
			SlotFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, 100672661);
			SlotFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, 100672662);
			SlotFilter.NativeMethodInfoPtr_IsDefault_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, 100672663);
			SlotFilter.NativeMethodInfoPtr_Clone_Public_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, 100672664);
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x00173B2C File Offset: 0x00171D2C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 168787, RefRangeEnd = 168795, XrefRangeStart = 168744, XrefRangeEnd = 168787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x00173B68 File Offset: 0x00171D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168795, XrefRangeEnd = 168807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x00173BB8 File Offset: 0x00171DB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168809, RefRangeEnd = 168812, XrefRangeStart = 168807, XrefRangeEnd = 168809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotFilter.NativeMethodInfoPtr_IsDefault_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x00173BF4 File Offset: 0x00171DF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168830, RefRangeEnd = 168832, XrefRangeStart = 168812, XrefRangeEnd = 168830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotFilter Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotFilter.NativeMethodInfoPtr_Clone_Public_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SlotFilter>(intPtr3) : null;
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x000237D0 File Offset: 0x000219D0
		public SlotFilter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x00173C34 File Offset: 0x00171E34
		// (set) Token: 0x06004913 RID: 18707 RVA: 0x000237D9 File Offset: 0x000219D9
		public unsafe SlotFilter.EType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06004914 RID: 18708 RVA: 0x00173C5C File Offset: 0x00171E5C
		// (set) Token: 0x06004915 RID: 18709 RVA: 0x000237F4 File Offset: 0x000219F4
		public unsafe List<string> ItemIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_ItemIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_ItemIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06004916 RID: 18710 RVA: 0x00173C8C File Offset: 0x00171E8C
		// (set) Token: 0x06004917 RID: 18711 RVA: 0x00023813 File Offset: 0x00021A13
		public unsafe List<EQuality> AllowedQualities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_AllowedQualities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EQuality>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_AllowedQualities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031A8 RID: 12712
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040031A9 RID: 12713
		private static readonly IntPtr NativeFieldInfoPtr_ItemIDs;

		// Token: 0x040031AA RID: 12714
		private static readonly IntPtr NativeFieldInfoPtr_AllowedQualities;

		// Token: 0x040031AB RID: 12715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031AC RID: 12716
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Boolean_ItemInstance_0;

		// Token: 0x040031AD RID: 12717
		private static readonly IntPtr NativeMethodInfoPtr_IsDefault_Public_Boolean_0;

		// Token: 0x040031AE RID: 12718
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_SlotFilter_0;

		// Token: 0x02000A71 RID: 2673
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x04009935 RID: 39221
			None,
			// Token: 0x04009936 RID: 39222
			Whitelist,
			// Token: 0x04009937 RID: 39223
			Blacklist
		}
	}
}

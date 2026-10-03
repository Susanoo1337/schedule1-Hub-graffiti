using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002F1 RID: 753
	public class ManagementItemFilter : Object
	{
		// Token: 0x06003BBB RID: 15291 RVA: 0x00144910 File Offset: 0x00142B10
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementItemFilter()
		{
			Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementItemFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr);
			ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, "<Mode>k__BackingField");
			ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, "<Items>k__BackingField");
			ManagementItemFilter.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670955);
			ManagementItemFilter.NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670956);
			ManagementItemFilter.NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670957);
			ManagementItemFilter.NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670958);
			ManagementItemFilter.NativeMethodInfoPtr__ctor_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670959);
			ManagementItemFilter.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670960);
			ManagementItemFilter.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670961);
			ManagementItemFilter.NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670962);
			ManagementItemFilter.NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670963);
			ManagementItemFilter.NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670964);
			ManagementItemFilter.NativeMethodInfoPtr_GetDescription_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100670965);
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06003BBC RID: 15292 RVA: 0x00144A44 File Offset: 0x00142C44
		// (set) Token: 0x06003BBD RID: 15293 RVA: 0x00144A80 File Offset: 0x00142C80
		public unsafe ManagementItemFilter.EMode Mode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29049, RefRangeEnd = 29051, XrefRangeStart = 29049, XrefRangeEnd = 29051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29056, XrefRangeStart = 29051, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06003BBE RID: 15294 RVA: 0x00144AC0 File Offset: 0x00142CC0
		// (set) Token: 0x06003BBF RID: 15295 RVA: 0x00144B00 File Offset: 0x00142D00
		public unsafe List<ItemDefinition> Items
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x00144B44 File Offset: 0x00142D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150581, RefRangeEnd = 150583, XrefRangeStart = 150568, XrefRangeEnd = 150581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementItemFilter(ManagementItemFilter.EMode mode) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr__ctor_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x00144B8C File Offset: 0x00142D8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29056, XrefRangeStart = 29051, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMode(ManagementItemFilter.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00144BCC File Offset: 0x00142DCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150589, RefRangeEnd = 150591, XrefRangeStart = 150583, XrefRangeEnd = 150589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00144C10 File Offset: 0x00142E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150591, XrefRangeEnd = 150595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00144C54 File Offset: 0x00142E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150595, XrefRangeEnd = 150599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00144CA4 File Offset: 0x00142EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150606, RefRangeEnd = 150607, XrefRangeStart = 150599, XrefRangeEnd = 150606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesItemMeetFilter(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00144CF4 File Offset: 0x00142EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150607, XrefRangeEnd = 150615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_GetDescription_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x0001DD1E File Offset: 0x0001BF1E
		public ManagementItemFilter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x00144D2C File Offset: 0x00142F2C
		// (set) Token: 0x06003BC9 RID: 15305 RVA: 0x0001DD27 File Offset: 0x0001BF27
		public unsafe ManagementItemFilter.EMode _Mode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField)) = value;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x00144D54 File Offset: 0x00142F54
		// (set) Token: 0x06003BCB RID: 15307 RVA: 0x0001DD42 File Offset: 0x0001BF42
		public unsafe List<ItemDefinition> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400284F RID: 10319
		private static readonly IntPtr NativeFieldInfoPtr__Mode_k__BackingField;

		// Token: 0x04002850 RID: 10320
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04002851 RID: 10321
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_EMode_0;

		// Token: 0x04002852 RID: 10322
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0;

		// Token: 0x04002853 RID: 10323
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0;

		// Token: 0x04002854 RID: 10324
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0;

		// Token: 0x04002855 RID: 10325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EMode_0;

		// Token: 0x04002856 RID: 10326
		private static readonly IntPtr NativeMethodInfoPtr_SetMode_Public_Void_EMode_0;

		// Token: 0x04002857 RID: 10327
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0;

		// Token: 0x04002858 RID: 10328
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0;

		// Token: 0x04002859 RID: 10329
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0;

		// Token: 0x0400285A RID: 10330
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0;

		// Token: 0x0400285B RID: 10331
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_String_0;

		// Token: 0x02000A39 RID: 2617
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x04009811 RID: 38929
			Whitelist,
			// Token: 0x04009812 RID: 38930
			Blacklist
		}
	}
}

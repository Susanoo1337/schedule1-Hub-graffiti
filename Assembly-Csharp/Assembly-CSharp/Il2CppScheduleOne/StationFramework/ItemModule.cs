using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200053B RID: 1339
	public class ItemModule : MonoBehaviour
	{
		// Token: 0x060079C9 RID: 31177 RVA: 0x0021BCC8 File Offset: 0x00219EC8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemModule()
		{
			Il2CppClassPointerStore<ItemModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "ItemModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemModule>.NativeClassPtr);
			ItemModule.NativeFieldInfoPtr__Item_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, "<Item>k__BackingField");
			ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, "<IsModuleActive>k__BackingField");
			ItemModule.NativeMethodInfoPtr_get_Item_Public_get_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678948);
			ItemModule.NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678949);
			ItemModule.NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678950);
			ItemModule.NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678951);
			ItemModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678952);
			ItemModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678953);
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x060079CA RID: 31178 RVA: 0x0021BD98 File Offset: 0x00219F98
		// (set) Token: 0x060079CB RID: 31179 RVA: 0x0021BDD8 File Offset: 0x00219FD8
		public unsafe StationItem Item
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_get_Item_Public_get_StationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x060079CC RID: 31180 RVA: 0x0021BE1C File Offset: 0x0021A01C
		// (set) Token: 0x060079CD RID: 31181 RVA: 0x0021BE58 File Offset: 0x0021A058
		public unsafe bool IsModuleActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x0021BE98 File Offset: 0x0021A098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233951, RefRangeEnd = 233952, XrefRangeStart = 233950, XrefRangeEnd = 233951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x0021BEE8 File Offset: 0x0021A0E8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x0003A027 File Offset: 0x00038227
		public ItemModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x060079D1 RID: 31185 RVA: 0x0021BF24 File Offset: 0x0021A124
		// (set) Token: 0x060079D2 RID: 31186 RVA: 0x0003A030 File Offset: 0x00038230
		public unsafe StationItem _Item_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__Item_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__Item_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x060079D3 RID: 31187 RVA: 0x0021BF54 File Offset: 0x0021A154
		// (set) Token: 0x060079D4 RID: 31188 RVA: 0x0003A04F File Offset: 0x0003824F
		public unsafe bool _IsModuleActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField)) = value;
			}
		}

		// Token: 0x040052F9 RID: 21241
		private static readonly IntPtr NativeFieldInfoPtr__Item_k__BackingField;

		// Token: 0x040052FA RID: 21242
		private static readonly IntPtr NativeFieldInfoPtr__IsModuleActive_k__BackingField;

		// Token: 0x040052FB RID: 21243
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_StationItem_0;

		// Token: 0x040052FC RID: 21244
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0;

		// Token: 0x040052FD RID: 21245
		private static readonly IntPtr NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0;

		// Token: 0x040052FE RID: 21246
		private static readonly IntPtr NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0;

		// Token: 0x040052FF RID: 21247
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0;

		// Token: 0x04005300 RID: 21248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

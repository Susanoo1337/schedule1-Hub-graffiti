using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000489 RID: 1161
	public class TrashBag : TrashItem
	{
		// Token: 0x06006892 RID: 26770 RVA: 0x001E4A18 File Offset: 0x001E2C18
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBag()
		{
			Il2CppClassPointerStore<TrashBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBag>.NativeClassPtr);
			TrashBag.NativeFieldInfoPtr__Content_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, "<Content>k__BackingField");
			TrashBag.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100676971);
			TrashBag.NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100676972);
			TrashBag.NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100676973);
			TrashBag.NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100676974);
			TrashBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100676975);
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06006893 RID: 26771 RVA: 0x001E4AC0 File Offset: 0x001E2CC0
		// (set) Token: 0x06006894 RID: 26772 RVA: 0x001E4B00 File Offset: 0x001E2D00
		public unsafe TrashContent Content
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38414, RefRangeEnd = 38415, XrefRangeStart = 38414, XrefRangeEnd = 38415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x001E4B44 File Offset: 0x001E2D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216424, RefRangeEnd = 216425, XrefRangeStart = 216422, XrefRangeEnd = 216424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContent(TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006896 RID: 26774 RVA: 0x001E4B88 File Offset: 0x001E2D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216425, XrefRangeEnd = 216435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TrashItemData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag.NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItemData>(intPtr3) : null;
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x001E4BD4 File Offset: 0x001E2DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216435, XrefRangeEnd = 216459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x00031427 File Offset: 0x0002F627
		public TrashBag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06006899 RID: 26777 RVA: 0x001E4C10 File Offset: 0x001E2E10
		// (set) Token: 0x0600689A RID: 26778 RVA: 0x00031430 File Offset: 0x0002F630
		public unsafe TrashContent _Content_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag.NativeFieldInfoPtr__Content_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag.NativeFieldInfoPtr__Content_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040047E6 RID: 18406
		private static readonly IntPtr NativeFieldInfoPtr__Content_k__BackingField;

		// Token: 0x040047E7 RID: 18407
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0;

		// Token: 0x040047E8 RID: 18408
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0;

		// Token: 0x040047E9 RID: 18409
		private static readonly IntPtr NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0;

		// Token: 0x040047EA RID: 18410
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0;

		// Token: 0x040047EB RID: 18411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

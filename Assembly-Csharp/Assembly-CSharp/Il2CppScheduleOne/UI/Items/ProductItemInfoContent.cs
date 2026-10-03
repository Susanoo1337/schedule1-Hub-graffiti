using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200082D RID: 2093
	public class ProductItemInfoContent : QualityItemInfoContent
	{
		// Token: 0x0600CB97 RID: 52119 RVA: 0x00334460 File Offset: 0x00332660
		// Note: this type is marked as 'beforefieldinit'.
		static ProductItemInfoContent()
		{
			Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ProductItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr);
			ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, "PropertyLabels");
			ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100689544);
			ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100689545);
			ProductItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100689546);
		}

		// Token: 0x0600CB98 RID: 52120 RVA: 0x003344E0 File Offset: 0x003326E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334187, XrefRangeEnd = 334190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB99 RID: 52121 RVA: 0x00334530 File Offset: 0x00332730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334190, XrefRangeEnd = 334231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB9A RID: 52122 RVA: 0x00334580 File Offset: 0x00332780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334231, XrefRangeEnd = 334239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB9B RID: 52123 RVA: 0x000609AF File Offset: 0x0005EBAF
		public ProductItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x0600CB9C RID: 52124 RVA: 0x003345BC File Offset: 0x003327BC
		// (set) Token: 0x0600CB9D RID: 52125 RVA: 0x000609B8 File Offset: 0x0005EBB8
		public unsafe List<TextMeshProUGUI> PropertyLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008A9A RID: 35482
		private static readonly IntPtr NativeFieldInfoPtr_PropertyLabels;

		// Token: 0x04008A9B RID: 35483
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04008A9C RID: 35484
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0;

		// Token: 0x04008A9D RID: 35485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

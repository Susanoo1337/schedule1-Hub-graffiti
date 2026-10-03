using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000828 RID: 2088
	public class ItemInfoContent : MonoBehaviour
	{
		// Token: 0x0600CAD0 RID: 51920 RVA: 0x00331C4C File Offset: 0x0032FE4C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInfoContent()
		{
			Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr);
			ItemInfoContent.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "Height");
			ItemInfoContent.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "NameLabel");
			ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "DescriptionLabel");
			ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100689460);
			ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100689461);
			ItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100689462);
		}

		// Token: 0x0600CAD1 RID: 51921 RVA: 0x00331CF4 File Offset: 0x0032FEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333054, XrefRangeEnd = 333055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAD2 RID: 51922 RVA: 0x00331D44 File Offset: 0x0032FF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333055, XrefRangeEnd = 333056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAD3 RID: 51923 RVA: 0x00331D94 File Offset: 0x0032FF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333056, XrefRangeEnd = 333057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAD4 RID: 51924 RVA: 0x00060302 File Offset: 0x0005E502
		public ItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x0600CAD5 RID: 51925 RVA: 0x00331DD0 File Offset: 0x0032FFD0
		// (set) Token: 0x0600CAD6 RID: 51926 RVA: 0x0006030B File Offset: 0x0005E50B
		public unsafe float Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x0600CAD7 RID: 51927 RVA: 0x00331DF8 File Offset: 0x0032FFF8
		// (set) Token: 0x0600CAD8 RID: 51928 RVA: 0x00060326 File Offset: 0x0005E526
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x0600CAD9 RID: 51929 RVA: 0x00331E28 File Offset: 0x00330028
		// (set) Token: 0x0600CADA RID: 51930 RVA: 0x00060345 File Offset: 0x0005E545
		public unsafe TextMeshProUGUI DescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008A16 RID: 35350
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04008A17 RID: 35351
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04008A18 RID: 35352
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionLabel;

		// Token: 0x04008A19 RID: 35353
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04008A1A RID: 35354
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0;

		// Token: 0x04008A1B RID: 35355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

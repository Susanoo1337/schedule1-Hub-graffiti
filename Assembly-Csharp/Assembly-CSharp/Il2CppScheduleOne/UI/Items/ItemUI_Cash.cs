using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000822 RID: 2082
	public class ItemUI_Cash : ItemUI
	{
		// Token: 0x0600CA42 RID: 51778 RVA: 0x00330070 File Offset: 0x0032E270
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI_Cash()
		{
			Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr);
			ItemUI_Cash.NativeFieldInfoPtr_cashInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, "cashInstance");
			ItemUI_Cash.NativeFieldInfoPtr_AmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, "AmountLabel");
			ItemUI_Cash.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100689388);
			ItemUI_Cash.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100689389);
			ItemUI_Cash.NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100689390);
			ItemUI_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100689391);
		}

		// Token: 0x0600CA43 RID: 51779 RVA: 0x00330118 File Offset: 0x0032E318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332277, XrefRangeEnd = 332283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_Cash.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA44 RID: 51780 RVA: 0x00330168 File Offset: 0x0032E368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332283, XrefRangeEnd = 332288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_Cash.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA45 RID: 51781 RVA: 0x003301A4 File Offset: 0x0032E3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332288, XrefRangeEnd = 332293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedBalance(float balance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref balance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_Cash.NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA46 RID: 51782 RVA: 0x003301E4 File Offset: 0x0032E3E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA47 RID: 51783 RVA: 0x0005FE28 File Offset: 0x0005E028
		public ItemUI_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x0600CA48 RID: 51784 RVA: 0x00330220 File Offset: 0x0032E420
		// (set) Token: 0x0600CA49 RID: 51785 RVA: 0x0005FE31 File Offset: 0x0005E031
		public unsafe CashInstance cashInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_cashInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_cashInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x0600CA4A RID: 51786 RVA: 0x00330250 File Offset: 0x0032E450
		// (set) Token: 0x0600CA4B RID: 51787 RVA: 0x0005FE50 File Offset: 0x0005E050
		public unsafe TextMeshProUGUI AmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_AmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_AmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040089BB RID: 35259
		private static readonly IntPtr NativeFieldInfoPtr_cashInstance;

		// Token: 0x040089BC RID: 35260
		private static readonly IntPtr NativeFieldInfoPtr_AmountLabel;

		// Token: 0x040089BD RID: 35261
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040089BE RID: 35262
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x040089BF RID: 35263
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0;

		// Token: 0x040089C0 RID: 35264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

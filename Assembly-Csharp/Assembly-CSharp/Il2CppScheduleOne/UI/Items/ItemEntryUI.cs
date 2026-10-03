using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000827 RID: 2087
	public class ItemEntryUI : MonoBehaviour
	{
		// Token: 0x0600CAC5 RID: 51909 RVA: 0x00331A30 File Offset: 0x0032FC30
		// Note: this type is marked as 'beforefieldinit'.
		static ItemEntryUI()
		{
			Il2CppClassPointerStore<ItemEntryUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemEntryUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemEntryUI>.NativeClassPtr);
			ItemEntryUI.NativeFieldInfoPtr__nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemEntryUI>.NativeClassPtr, "_nameLabel");
			ItemEntryUI.NativeFieldInfoPtr__quantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemEntryUI>.NativeClassPtr, "_quantityLabel");
			ItemEntryUI.NativeFieldInfoPtr__icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemEntryUI>.NativeClassPtr, "_icon");
			ItemEntryUI.NativeMethodInfoPtr_Set_Public_Void_String_Int32_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemEntryUI>.NativeClassPtr, 100689457);
			ItemEntryUI.NativeMethodInfoPtr_SetLabelOnly_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemEntryUI>.NativeClassPtr, 100689458);
			ItemEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemEntryUI>.NativeClassPtr, 100689459);
		}

		// Token: 0x0600CAC6 RID: 51910 RVA: 0x00331AD8 File Offset: 0x0032FCD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 333047, RefRangeEnd = 333049, XrefRangeStart = 333042, XrefRangeEnd = 333047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(string name, int quantity, Sprite icon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemEntryUI.NativeMethodInfoPtr_Set_Public_Void_String_Int32_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAC7 RID: 51911 RVA: 0x00331B3C File Offset: 0x0032FD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333049, XrefRangeEnd = 333054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLabelOnly(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemEntryUI.NativeMethodInfoPtr_SetLabelOnly_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAC8 RID: 51912 RVA: 0x00331B80 File Offset: 0x0032FD80
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemEntryUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemEntryUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAC9 RID: 51913 RVA: 0x0006029C File Offset: 0x0005E49C
		public ItemEntryUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x0600CACA RID: 51914 RVA: 0x00331BBC File Offset: 0x0032FDBC
		// (set) Token: 0x0600CACB RID: 51915 RVA: 0x000602A5 File Offset: 0x0005E4A5
		public unsafe Text _nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemEntryUI.NativeFieldInfoPtr__nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemEntryUI.NativeFieldInfoPtr__nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x0600CACC RID: 51916 RVA: 0x00331BEC File Offset: 0x0032FDEC
		// (set) Token: 0x0600CACD RID: 51917 RVA: 0x000602C4 File Offset: 0x0005E4C4
		public unsafe Text _quantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemEntryUI.NativeFieldInfoPtr__quantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemEntryUI.NativeFieldInfoPtr__quantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x0600CACE RID: 51918 RVA: 0x00331C1C File Offset: 0x0032FE1C
		// (set) Token: 0x0600CACF RID: 51919 RVA: 0x000602E3 File Offset: 0x0005E4E3
		public unsafe Image _icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemEntryUI.NativeFieldInfoPtr__icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemEntryUI.NativeFieldInfoPtr__icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008A10 RID: 35344
		private static readonly IntPtr NativeFieldInfoPtr__nameLabel;

		// Token: 0x04008A11 RID: 35345
		private static readonly IntPtr NativeFieldInfoPtr__quantityLabel;

		// Token: 0x04008A12 RID: 35346
		private static readonly IntPtr NativeFieldInfoPtr__icon;

		// Token: 0x04008A13 RID: 35347
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_Int32_Sprite_0;

		// Token: 0x04008A14 RID: 35348
		private static readonly IntPtr NativeMethodInfoPtr_SetLabelOnly_Public_Void_String_0;

		// Token: 0x04008A15 RID: 35349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

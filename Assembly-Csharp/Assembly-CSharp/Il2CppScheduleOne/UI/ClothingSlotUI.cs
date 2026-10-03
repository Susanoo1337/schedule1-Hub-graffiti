using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200073E RID: 1854
	public class ClothingSlotUI : ItemSlotUI
	{
		// Token: 0x0600B35D RID: 45917 RVA: 0x002EAD48 File Offset: 0x002E8F48
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingSlotUI()
		{
			Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ClothingSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr);
			ClothingSlotUI.NativeFieldInfoPtr_SlotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, "SlotType");
			ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, "SlotTypeImage");
			ClothingSlotUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, 100686834);
			ClothingSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, 100686835);
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x002EADC8 File Offset: 0x002E8FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302699, XrefRangeEnd = 302706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingSlotUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B35F RID: 45919 RVA: 0x002EADFC File Offset: 0x002E8FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B360 RID: 45920 RVA: 0x00052C13 File Offset: 0x00050E13
		public ClothingSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0600B361 RID: 45921 RVA: 0x002EAE38 File Offset: 0x002E9038
		// (set) Token: 0x0600B362 RID: 45922 RVA: 0x00052C1C File Offset: 0x00050E1C
		public unsafe EClothingSlot SlotType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotType)) = value;
			}
		}

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0600B363 RID: 45923 RVA: 0x002EAE60 File Offset: 0x002E9060
		// (set) Token: 0x0600B364 RID: 45924 RVA: 0x00052C37 File Offset: 0x00050E37
		public unsafe Image SlotTypeImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007B72 RID: 31602
		private static readonly IntPtr NativeFieldInfoPtr_SlotType;

		// Token: 0x04007B73 RID: 31603
		private static readonly IntPtr NativeFieldInfoPtr_SlotTypeImage;

		// Token: 0x04007B74 RID: 31604
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007B75 RID: 31605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

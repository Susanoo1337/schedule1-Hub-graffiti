using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200082F RID: 2095
	public class QualityItemUI : ItemUI
	{
		// Token: 0x0600CBA6 RID: 52134 RVA: 0x00334758 File Offset: 0x00332958
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemUI()
		{
			Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "QualityItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr);
			QualityItemUI.NativeFieldInfoPtr_QualityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, "QualityIcon");
			QualityItemUI.NativeFieldInfoPtr_qualityItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, "qualityItemInstance");
			QualityItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100689549);
			QualityItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100689550);
			QualityItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100689551);
		}

		// Token: 0x0600CBA7 RID: 52135 RVA: 0x003347EC File Offset: 0x003329EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334254, XrefRangeEnd = 334260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBA8 RID: 52136 RVA: 0x0033483C File Offset: 0x00332A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334260, XrefRangeEnd = 334266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBA9 RID: 52137 RVA: 0x00334878 File Offset: 0x00332A78
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBAA RID: 52138 RVA: 0x00060A1E File Offset: 0x0005EC1E
		public QualityItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x0600CBAB RID: 52139 RVA: 0x003348B4 File Offset: 0x00332AB4
		// (set) Token: 0x0600CBAC RID: 52140 RVA: 0x00060A27 File Offset: 0x0005EC27
		public unsafe Image QualityIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_QualityIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_QualityIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x0600CBAD RID: 52141 RVA: 0x003348E4 File Offset: 0x00332AE4
		// (set) Token: 0x0600CBAE RID: 52142 RVA: 0x00060A46 File Offset: 0x0005EC46
		public unsafe QualityItemInstance qualityItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_qualityItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_qualityItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008AA2 RID: 35490
		private static readonly IntPtr NativeFieldInfoPtr_QualityIcon;

		// Token: 0x04008AA3 RID: 35491
		private static readonly IntPtr NativeFieldInfoPtr_qualityItemInstance;

		// Token: 0x04008AA4 RID: 35492
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04008AA5 RID: 35493
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04008AA6 RID: 35494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

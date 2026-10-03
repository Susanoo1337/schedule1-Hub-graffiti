using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.CustomUI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000710 RID: 1808
	public class UISelectable_CashItemSlot : UISelectable_ItemSlot
	{
		// Token: 0x0600AE6D RID: 44653 RVA: 0x002DC0CC File Offset: 0x002DA2CC
		// Note: this type is marked as 'beforefieldinit'.
		static UISelectable_CashItemSlot()
		{
			Il2CppClassPointerStore<UISelectable_CashItemSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UISelectable_CashItemSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISelectable_CashItemSlot>.NativeClassPtr);
			UISelectable_CashItemSlot.NativeMethodInfoPtr_CanBeSelectedWhileDraggingItem_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_CashItemSlot>.NativeClassPtr, 100686264);
			UISelectable_CashItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_CashItemSlot>.NativeClassPtr, 100686265);
		}

		// Token: 0x0600AE6E RID: 44654 RVA: 0x002DC124 File Offset: 0x002DA324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297978, XrefRangeEnd = 297983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeSelectedWhileDraggingItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable_CashItemSlot.NativeMethodInfoPtr_CanBeSelectedWhileDraggingItem_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AE6F RID: 44655 RVA: 0x002DC16C File Offset: 0x002DA36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297983, XrefRangeEnd = 297984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable_CashItemSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISelectable_CashItemSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_CashItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE70 RID: 44656 RVA: 0x0004FE2D File Offset: 0x0004E02D
		public UISelectable_CashItemSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007860 RID: 30816
		private static readonly IntPtr NativeMethodInfoPtr_CanBeSelectedWhileDraggingItem_Protected_Virtual_Boolean_0;

		// Token: 0x04007861 RID: 30817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

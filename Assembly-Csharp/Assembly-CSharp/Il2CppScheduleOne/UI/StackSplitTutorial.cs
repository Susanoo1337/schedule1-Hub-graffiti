using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200075E RID: 1886
	public class StackSplitTutorial : MonoBehaviour
	{
		// Token: 0x0600B7E7 RID: 47079 RVA: 0x002F8274 File Offset: 0x002F6474
		// Note: this type is marked as 'beforefieldinit'.
		static StackSplitTutorial()
		{
			Il2CppClassPointerStore<StackSplitTutorial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "StackSplitTutorial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackSplitTutorial>.NativeClassPtr);
			StackSplitTutorial.NativeFieldInfoPtr__slotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackSplitTutorial>.NativeClassPtr, "_slotUI");
			StackSplitTutorial.NativeMethodInfoPtr_Open_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackSplitTutorial>.NativeClassPtr, 100687367);
			StackSplitTutorial.NativeMethodInfoPtr_OnSlotDragStart_Private_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackSplitTutorial>.NativeClassPtr, 100687368);
			StackSplitTutorial.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackSplitTutorial>.NativeClassPtr, 100687369);
			StackSplitTutorial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackSplitTutorial>.NativeClassPtr, 100687370);
		}

		// Token: 0x0600B7E8 RID: 47080 RVA: 0x002F8308 File Offset: 0x002F6508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308729, RefRangeEnd = 308730, XrefRangeStart = 308709, XrefRangeEnd = 308729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemSlotUI slotUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slotUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackSplitTutorial.NativeMethodInfoPtr_Open_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7E9 RID: 47081 RVA: 0x002F834C File Offset: 0x002F654C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308730, XrefRangeEnd = 308748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSlotDragStart(ItemSlotUI slotUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slotUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackSplitTutorial.NativeMethodInfoPtr_OnSlotDragStart_Private_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7EA RID: 47082 RVA: 0x002F8390 File Offset: 0x002F6590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308763, RefRangeEnd = 308764, XrefRangeStart = 308748, XrefRangeEnd = 308763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackSplitTutorial.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7EB RID: 47083 RVA: 0x002F83C4 File Offset: 0x002F65C4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackSplitTutorial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackSplitTutorial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackSplitTutorial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x00055725 File Offset: 0x00053925
		public StackSplitTutorial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x0600B7ED RID: 47085 RVA: 0x002F8400 File Offset: 0x002F6600
		// (set) Token: 0x0600B7EE RID: 47086 RVA: 0x0005572E File Offset: 0x0005392E
		public unsafe ItemSlotUI _slotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackSplitTutorial.NativeFieldInfoPtr__slotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackSplitTutorial.NativeFieldInfoPtr__slotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007E4C RID: 32332
		private static readonly IntPtr NativeFieldInfoPtr__slotUI;

		// Token: 0x04007E4D RID: 32333
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemSlotUI_0;

		// Token: 0x04007E4E RID: 32334
		private static readonly IntPtr NativeMethodInfoPtr_OnSlotDragStart_Private_Void_ItemSlotUI_0;

		// Token: 0x04007E4F RID: 32335
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007E50 RID: 32336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

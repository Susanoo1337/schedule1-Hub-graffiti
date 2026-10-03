using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000831 RID: 2097
	public class WaterContainerUI : ItemUI
	{
		// Token: 0x0600CBB8 RID: 52152 RVA: 0x00334AD0 File Offset: 0x00332CD0
		// Note: this type is marked as 'beforefieldinit'.
		static WaterContainerUI()
		{
			Il2CppClassPointerStore<WaterContainerUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "WaterContainerUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterContainerUI>.NativeClassPtr);
			WaterContainerUI.NativeFieldInfoPtr_wcInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterContainerUI>.NativeClassPtr, "wcInstance");
			WaterContainerUI.NativeFieldInfoPtr_AmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterContainerUI>.NativeClassPtr, "AmountLabel");
			WaterContainerUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerUI>.NativeClassPtr, 100689555);
			WaterContainerUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerUI>.NativeClassPtr, 100689556);
			WaterContainerUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerUI>.NativeClassPtr, 100689557);
		}

		// Token: 0x0600CBB9 RID: 52153 RVA: 0x00334B64 File Offset: 0x00332D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334283, XrefRangeEnd = 334289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBBA RID: 52154 RVA: 0x00334BB4 File Offset: 0x00332DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334289, XrefRangeEnd = 334295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBBB RID: 52155 RVA: 0x00334BF0 File Offset: 0x00332DF0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterContainerUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterContainerUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBBC RID: 52156 RVA: 0x00060AAC File Offset: 0x0005ECAC
		public WaterContainerUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x0600CBBD RID: 52157 RVA: 0x00334C2C File Offset: 0x00332E2C
		// (set) Token: 0x0600CBBE RID: 52158 RVA: 0x00060AB5 File Offset: 0x0005ECB5
		public unsafe WaterContainerInstance wcInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerUI.NativeFieldInfoPtr_wcInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerUI.NativeFieldInfoPtr_wcInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x0600CBBF RID: 52159 RVA: 0x00334C5C File Offset: 0x00332E5C
		// (set) Token: 0x0600CBC0 RID: 52160 RVA: 0x00060AD4 File Offset: 0x0005ECD4
		public unsafe Text AmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerUI.NativeFieldInfoPtr_AmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerUI.NativeFieldInfoPtr_AmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008AAC RID: 35500
		private static readonly IntPtr NativeFieldInfoPtr_wcInstance;

		// Token: 0x04008AAD RID: 35501
		private static readonly IntPtr NativeFieldInfoPtr_AmountLabel;

		// Token: 0x04008AAE RID: 35502
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04008AAF RID: 35503
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04008AB0 RID: 35504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

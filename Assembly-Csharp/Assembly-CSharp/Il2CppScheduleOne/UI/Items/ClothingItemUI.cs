using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000823 RID: 2083
	public class ClothingItemUI : ItemUI
	{
		// Token: 0x0600CA4C RID: 51788 RVA: 0x00330280 File Offset: 0x0032E480
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingItemUI()
		{
			Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ClothingItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr);
			ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, "ClothingTypeIcon");
			ClothingItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, 100689392);
			ClothingItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, 100689393);
		}

		// Token: 0x0600CA4D RID: 51789 RVA: 0x003302EC File Offset: 0x0032E4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332293, XrefRangeEnd = 332312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA4E RID: 51790 RVA: 0x00330328 File Offset: 0x0032E528
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA4F RID: 51791 RVA: 0x0005FE6F File Offset: 0x0005E06F
		public ClothingItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x0600CA50 RID: 51792 RVA: 0x00330364 File Offset: 0x0032E564
		// (set) Token: 0x0600CA51 RID: 51793 RVA: 0x0005FE78 File Offset: 0x0005E078
		public unsafe Image ClothingTypeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040089C1 RID: 35265
		private static readonly IntPtr NativeFieldInfoPtr_ClothingTypeIcon;

		// Token: 0x040089C2 RID: 35266
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x040089C3 RID: 35267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

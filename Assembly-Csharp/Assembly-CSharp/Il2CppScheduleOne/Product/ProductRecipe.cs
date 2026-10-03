using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000571 RID: 1393
	public class ProductRecipe : MonoBehaviour
	{
		// Token: 0x06007F31 RID: 32561 RVA: 0x00230A5C File Offset: 0x0022EC5C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductRecipe()
		{
			Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductRecipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr);
			ProductRecipe.NativeFieldInfoPtr__productIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr, "_productIcon");
			ProductRecipe.NativeFieldInfoPtr__productTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr, "_productTooltip");
			ProductRecipe.NativeFieldInfoPtr__mixerIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr, "_mixerIcon");
			ProductRecipe.NativeFieldInfoPtr__mixerTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr, "_mixerTooltip");
			ProductRecipe.NativeFieldInfoPtr__outputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr, "_outputIcon");
			ProductRecipe.NativeFieldInfoPtr__outputTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr, "_outputTooltip");
			ProductRecipe.NativeMethodInfoPtr_SetProduct_Public_Void_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr, 100679711);
			ProductRecipe.NativeMethodInfoPtr_SetMixer_Public_Void_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr, 100679712);
			ProductRecipe.NativeMethodInfoPtr_SetOutput_Public_Void_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr, 100679713);
			ProductRecipe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr, 100679714);
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x00230B54 File Offset: 0x0022ED54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243087, RefRangeEnd = 243088, XrefRangeStart = 243084, XrefRangeEnd = 243087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProduct(Sprite sprite, string tooltip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductRecipe.NativeMethodInfoPtr_SetProduct_Public_Void_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x00230BA8 File Offset: 0x0022EDA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243091, RefRangeEnd = 243092, XrefRangeStart = 243088, XrefRangeEnd = 243091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMixer(Sprite sprite, string tooltip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductRecipe.NativeMethodInfoPtr_SetMixer_Public_Void_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x00230BFC File Offset: 0x0022EDFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243095, RefRangeEnd = 243096, XrefRangeStart = 243092, XrefRangeEnd = 243095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOutput(Sprite sprite, string tooltip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductRecipe.NativeMethodInfoPtr_SetOutput_Public_Void_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F35 RID: 32565 RVA: 0x00230C50 File Offset: 0x0022EE50
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductRecipe() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductRecipe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductRecipe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F36 RID: 32566 RVA: 0x0003C57C File Offset: 0x0003A77C
		public ProductRecipe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x06007F37 RID: 32567 RVA: 0x00230C8C File Offset: 0x0022EE8C
		// (set) Token: 0x06007F38 RID: 32568 RVA: 0x0003C585 File Offset: 0x0003A785
		public unsafe Image _productIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__productIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__productIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x06007F39 RID: 32569 RVA: 0x00230CBC File Offset: 0x0022EEBC
		// (set) Token: 0x06007F3A RID: 32570 RVA: 0x0003C5A4 File Offset: 0x0003A7A4
		public unsafe Tooltip _productTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__productTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__productTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x06007F3B RID: 32571 RVA: 0x00230CEC File Offset: 0x0022EEEC
		// (set) Token: 0x06007F3C RID: 32572 RVA: 0x0003C5C3 File Offset: 0x0003A7C3
		public unsafe Image _mixerIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__mixerIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__mixerIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x06007F3D RID: 32573 RVA: 0x00230D1C File Offset: 0x0022EF1C
		// (set) Token: 0x06007F3E RID: 32574 RVA: 0x0003C5E2 File Offset: 0x0003A7E2
		public unsafe Tooltip _mixerTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__mixerTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__mixerTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x06007F3F RID: 32575 RVA: 0x00230D4C File Offset: 0x0022EF4C
		// (set) Token: 0x06007F40 RID: 32576 RVA: 0x0003C601 File Offset: 0x0003A801
		public unsafe Image _outputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__outputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__outputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x06007F41 RID: 32577 RVA: 0x00230D7C File Offset: 0x0022EF7C
		// (set) Token: 0x06007F42 RID: 32578 RVA: 0x0003C620 File Offset: 0x0003A820
		public unsafe Tooltip _outputTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__outputTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductRecipe.NativeFieldInfoPtr__outputTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040056D7 RID: 22231
		private static readonly IntPtr NativeFieldInfoPtr__productIcon;

		// Token: 0x040056D8 RID: 22232
		private static readonly IntPtr NativeFieldInfoPtr__productTooltip;

		// Token: 0x040056D9 RID: 22233
		private static readonly IntPtr NativeFieldInfoPtr__mixerIcon;

		// Token: 0x040056DA RID: 22234
		private static readonly IntPtr NativeFieldInfoPtr__mixerTooltip;

		// Token: 0x040056DB RID: 22235
		private static readonly IntPtr NativeFieldInfoPtr__outputIcon;

		// Token: 0x040056DC RID: 22236
		private static readonly IntPtr NativeFieldInfoPtr__outputTooltip;

		// Token: 0x040056DD RID: 22237
		private static readonly IntPtr NativeMethodInfoPtr_SetProduct_Public_Void_Sprite_String_0;

		// Token: 0x040056DE RID: 22238
		private static readonly IntPtr NativeMethodInfoPtr_SetMixer_Public_Void_Sprite_String_0;

		// Token: 0x040056DF RID: 22239
		private static readonly IntPtr NativeMethodInfoPtr_SetOutput_Public_Void_Sprite_String_0;

		// Token: 0x040056E0 RID: 22240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

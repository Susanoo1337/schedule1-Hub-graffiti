using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200040D RID: 1037
	public class FontSetter : MonoBehaviour
	{
		// Token: 0x06005B62 RID: 23394 RVA: 0x001B6730 File Offset: 0x001B4930
		// Note: this type is marked as 'beforefieldinit'.
		static FontSetter()
		{
			Il2CppClassPointerStore<FontSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "FontSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontSetter>.NativeClassPtr);
			FontSetter.NativeFieldInfoPtr__imageItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetter>.NativeClassPtr, "_imageItems");
			FontSetter.NativeFieldInfoPtr__colourFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetter>.NativeClassPtr, "_colourFont");
			FontSetter.NativeMethodInfoPtr_SetColour_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetter>.NativeClassPtr, 100675236);
			FontSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetter>.NativeClassPtr, 100675237);
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x001B67B0 File Offset: 0x001B49B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197091, RefRangeEnd = 197092, XrefRangeStart = 197055, XrefRangeEnd = 197091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColour(string componentName, string ColourName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(componentName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ColourName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontSetter.NativeMethodInfoPtr_SetColour_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x001B6804 File Offset: 0x001B4A04
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x0002B428 File Offset: 0x00029628
		public FontSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06005B66 RID: 23398 RVA: 0x001B6840 File Offset: 0x001B4A40
		// (set) Token: 0x06005B67 RID: 23399 RVA: 0x0002B431 File Offset: 0x00029631
		public unsafe List<FontSetter.ImageItem> _imageItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontSetter.NativeFieldInfoPtr__imageItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FontSetter.ImageItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontSetter.NativeFieldInfoPtr__imageItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06005B68 RID: 23400 RVA: 0x001B6870 File Offset: 0x001B4A70
		// (set) Token: 0x06005B69 RID: 23401 RVA: 0x0002B450 File Offset: 0x00029650
		public unsafe ColorFont _colourFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontSetter.NativeFieldInfoPtr__colourFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontSetter.NativeFieldInfoPtr__colourFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003EA4 RID: 16036
		private static readonly IntPtr NativeFieldInfoPtr__imageItems;

		// Token: 0x04003EA5 RID: 16037
		private static readonly IntPtr NativeFieldInfoPtr__colourFont;

		// Token: 0x04003EA6 RID: 16038
		private static readonly IntPtr NativeMethodInfoPtr_SetColour_Public_Void_String_String_0;

		// Token: 0x04003EA7 RID: 16039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF1 RID: 2801
		[Serializable]
		public class ImageItem : Il2CppSystem.Object
		{
			// Token: 0x0600E51A RID: 58650 RVA: 0x003801C4 File Offset: 0x0037E3C4
			// Note: this type is marked as 'beforefieldinit'.
			static ImageItem()
			{
				Il2CppClassPointerStore<FontSetter.ImageItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FontSetter>.NativeClassPtr, "ImageItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontSetter.ImageItem>.NativeClassPtr);
				FontSetter.ImageItem.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetter.ImageItem>.NativeClassPtr, "Name");
				FontSetter.ImageItem.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetter.ImageItem>.NativeClassPtr, "Image");
				FontSetter.ImageItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetter.ImageItem>.NativeClassPtr, 100675238);
			}

			// Token: 0x0600E51B RID: 58651 RVA: 0x0038022C File Offset: 0x0037E42C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImageItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontSetter.ImageItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontSetter.ImageItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E51C RID: 58652 RVA: 0x0006C017 File Offset: 0x0006A217
			public ImageItem(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A0 RID: 17824
			// (get) Token: 0x0600E51D RID: 58653 RVA: 0x00380268 File Offset: 0x0037E468
			// (set) Token: 0x0600E51E RID: 58654 RVA: 0x0006C020 File Offset: 0x0006A220
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontSetter.ImageItem.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontSetter.ImageItem.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170045A1 RID: 17825
			// (get) Token: 0x0600E51F RID: 58655 RVA: 0x00380290 File Offset: 0x0037E490
			// (set) Token: 0x0600E520 RID: 58656 RVA: 0x0006C03F File Offset: 0x0006A23F
			public unsafe Image Image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontSetter.ImageItem.NativeFieldInfoPtr_Image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontSetter.ImageItem.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B82 RID: 39810
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04009B83 RID: 39811
			private static readonly IntPtr NativeFieldInfoPtr_Image;

			// Token: 0x04009B84 RID: 39812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AF2 RID: 2802
		[ObfuscatedName("ScheduleOne.DevUtilities.FontSetter+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E521 RID: 58657 RVA: 0x003802C0 File Offset: 0x0037E4C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<FontSetter.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FontSetter>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontSetter.__c__DisplayClass2_0>.NativeClassPtr);
				FontSetter.__c__DisplayClass2_0.NativeFieldInfoPtr_componentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetter.__c__DisplayClass2_0>.NativeClassPtr, "componentName");
				FontSetter.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetter.__c__DisplayClass2_0>.NativeClassPtr, 100675239);
				FontSetter.__c__DisplayClass2_0.NativeMethodInfoPtr__SetColour_b__0_Internal_Boolean_ImageItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetter.__c__DisplayClass2_0>.NativeClassPtr, 100675240);
			}

			// Token: 0x0600E522 RID: 58658 RVA: 0x00380328 File Offset: 0x0037E528
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontSetter.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontSetter.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E523 RID: 58659 RVA: 0x00380364 File Offset: 0x0037E564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetColour_b__0(FontSetter.ImageItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontSetter.__c__DisplayClass2_0.NativeMethodInfoPtr__SetColour_b__0_Internal_Boolean_ImageItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E524 RID: 58660 RVA: 0x0006C05E File Offset: 0x0006A25E
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A2 RID: 17826
			// (get) Token: 0x0600E525 RID: 58661 RVA: 0x003803B4 File Offset: 0x0037E5B4
			// (set) Token: 0x0600E526 RID: 58662 RVA: 0x0006C067 File Offset: 0x0006A267
			public unsafe string componentName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontSetter.__c__DisplayClass2_0.NativeFieldInfoPtr_componentName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontSetter.__c__DisplayClass2_0.NativeFieldInfoPtr_componentName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B85 RID: 39813
			private static readonly IntPtr NativeFieldInfoPtr_componentName;

			// Token: 0x04009B86 RID: 39814
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B87 RID: 39815
			private static readonly IntPtr NativeMethodInfoPtr__SetColour_b__0_Internal_Boolean_ImageItem_0;
		}
	}
}

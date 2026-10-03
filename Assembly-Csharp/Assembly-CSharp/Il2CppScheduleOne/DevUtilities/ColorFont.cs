using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200040C RID: 1036
	public class ColorFont : ScriptableObject
	{
		// Token: 0x06005B5C RID: 23388 RVA: 0x001B6608 File Offset: 0x001B4808
		// Note: this type is marked as 'beforefieldinit'.
		static ColorFont()
		{
			Il2CppClassPointerStore<ColorFont>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ColorFont");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFont>.NativeClassPtr);
			ColorFont.NativeFieldInfoPtr_ColorFontItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFont>.NativeClassPtr, "ColorFontItems");
			ColorFont.NativeMethodInfoPtr_GetColour_Public_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFont>.NativeClassPtr, 100675231);
			ColorFont.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFont>.NativeClassPtr, 100675232);
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x001B6674 File Offset: 0x001B4874
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 197038, RefRangeEnd = 197047, XrefRangeStart = 197024, XrefRangeEnd = 197038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColour(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFont.NativeMethodInfoPtr_GetColour_Public_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x001B66C4 File Offset: 0x001B48C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197047, XrefRangeEnd = 197055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorFont() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFont>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFont.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x0002B400 File Offset: 0x00029600
		public ColorFont(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06005B60 RID: 23392 RVA: 0x001B6700 File Offset: 0x001B4900
		// (set) Token: 0x06005B61 RID: 23393 RVA: 0x0002B409 File Offset: 0x00029609
		public unsafe List<ColorFont.ColorFontItem> ColorFontItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFont.NativeFieldInfoPtr_ColorFontItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ColorFont.ColorFontItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFont.NativeFieldInfoPtr_ColorFontItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003EA1 RID: 16033
		private static readonly IntPtr NativeFieldInfoPtr_ColorFontItems;

		// Token: 0x04003EA2 RID: 16034
		private static readonly IntPtr NativeMethodInfoPtr_GetColour_Public_Color_String_0;

		// Token: 0x04003EA3 RID: 16035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEF RID: 2799
		[Serializable]
		public class ColorFontItem : Il2CppSystem.Object
		{
			// Token: 0x0600E50D RID: 58637 RVA: 0x0037FFB4 File Offset: 0x0037E1B4
			// Note: this type is marked as 'beforefieldinit'.
			static ColorFontItem()
			{
				Il2CppClassPointerStore<ColorFont.ColorFontItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorFont>.NativeClassPtr, "ColorFontItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFont.ColorFontItem>.NativeClassPtr);
				ColorFont.ColorFontItem.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFont.ColorFontItem>.NativeClassPtr, "Name");
				ColorFont.ColorFontItem.NativeFieldInfoPtr_Colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFont.ColorFontItem>.NativeClassPtr, "Colour");
				ColorFont.ColorFontItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFont.ColorFontItem>.NativeClassPtr, 100675233);
			}

			// Token: 0x0600E50E RID: 58638 RVA: 0x0038001C File Offset: 0x0037E21C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorFontItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFont.ColorFontItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFont.ColorFontItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E50F RID: 58639 RVA: 0x0006BFAC File Offset: 0x0006A1AC
			public ColorFontItem(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700459D RID: 17821
			// (get) Token: 0x0600E510 RID: 58640 RVA: 0x00380058 File Offset: 0x0037E258
			// (set) Token: 0x0600E511 RID: 58641 RVA: 0x0006BFB5 File Offset: 0x0006A1B5
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFont.ColorFontItem.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFont.ColorFontItem.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700459E RID: 17822
			// (get) Token: 0x0600E512 RID: 58642 RVA: 0x00380080 File Offset: 0x0037E280
			// (set) Token: 0x0600E513 RID: 58643 RVA: 0x0006BFD4 File Offset: 0x0006A1D4
			public unsafe Color Colour
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFont.ColorFontItem.NativeFieldInfoPtr_Colour);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFont.ColorFontItem.NativeFieldInfoPtr_Colour)) = value;
				}
			}

			// Token: 0x04009B7C RID: 39804
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04009B7D RID: 39805
			private static readonly IntPtr NativeFieldInfoPtr_Colour;

			// Token: 0x04009B7E RID: 39806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AF0 RID: 2800
		[ObfuscatedName("ScheduleOne.DevUtilities.ColorFont+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E514 RID: 58644 RVA: 0x003800A8 File Offset: 0x0037E2A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ColorFont.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorFont>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFont.__c__DisplayClass1_0>.NativeClassPtr);
				ColorFont.__c__DisplayClass1_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFont.__c__DisplayClass1_0>.NativeClassPtr, "name");
				ColorFont.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFont.__c__DisplayClass1_0>.NativeClassPtr, 100675234);
				ColorFont.__c__DisplayClass1_0.NativeMethodInfoPtr__GetColour_b__0_Internal_Boolean_ColorFontItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFont.__c__DisplayClass1_0>.NativeClassPtr, 100675235);
			}

			// Token: 0x0600E515 RID: 58645 RVA: 0x00380110 File Offset: 0x0037E310
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFont.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFont.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E516 RID: 58646 RVA: 0x0038014C File Offset: 0x0037E34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetColour_b__0(ColorFont.ColorFontItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFont.__c__DisplayClass1_0.NativeMethodInfoPtr__GetColour_b__0_Internal_Boolean_ColorFontItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E517 RID: 58647 RVA: 0x0006BFEF File Offset: 0x0006A1EF
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700459F RID: 17823
			// (get) Token: 0x0600E518 RID: 58648 RVA: 0x0038019C File Offset: 0x0037E39C
			// (set) Token: 0x0600E519 RID: 58649 RVA: 0x0006BFF8 File Offset: 0x0006A1F8
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFont.__c__DisplayClass1_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFont.__c__DisplayClass1_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B7F RID: 39807
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04009B80 RID: 39808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B81 RID: 39809
			private static readonly IntPtr NativeMethodInfoPtr__GetColour_b__0_Internal_Boolean_ColorFontItem_0;
		}
	}
}

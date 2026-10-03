using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x0200044E RID: 1102
	[Serializable]
	public class CartelGoonAppearance : Il2CppSystem.Object
	{
		// Token: 0x06006404 RID: 25604 RVA: 0x001D605C File Offset: 0x001D425C
		// Note: this type is marked as 'beforefieldinit'.
		static CartelGoonAppearance()
		{
			Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelGoonAppearance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr);
			CartelGoonAppearance.NativeFieldInfoPtr_IsMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr, "IsMale");
			CartelGoonAppearance.NativeFieldInfoPtr_BaseAppearanceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr, "BaseAppearanceIndex");
			CartelGoonAppearance.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr, "SkinColor");
			CartelGoonAppearance.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr, "HairColor");
			CartelGoonAppearance.NativeFieldInfoPtr_ClothingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr, "ClothingIndex");
			CartelGoonAppearance.NativeFieldInfoPtr_VoiceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr, "VoiceIndex");
			CartelGoonAppearance.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Color_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr, 100676448);
			CartelGoonAppearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr, 100676449);
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x001D612C File Offset: 0x001D432C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210322, XrefRangeEnd = 210323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelGoonAppearance(bool isMale, int baseAppearanceIndex, Color skinColor, Color hairColor, int clothingIndex, int voiceIndex) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isMale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseAppearanceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skinColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hairColor;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clothingIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref voiceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoonAppearance.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Color_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x001D61BC File Offset: 0x001D43BC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelGoonAppearance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelGoonAppearance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoonAppearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x0002F1C9 File Offset: 0x0002D3C9
		public CartelGoonAppearance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06006408 RID: 25608 RVA: 0x001D61F8 File Offset: 0x001D43F8
		// (set) Token: 0x06006409 RID: 25609 RVA: 0x0002F1D2 File Offset: 0x0002D3D2
		public unsafe bool IsMale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_IsMale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_IsMale)) = value;
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x0600640A RID: 25610 RVA: 0x001D6220 File Offset: 0x001D4420
		// (set) Token: 0x0600640B RID: 25611 RVA: 0x0002F1ED File Offset: 0x0002D3ED
		public unsafe int BaseAppearanceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_BaseAppearanceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_BaseAppearanceIndex)) = value;
			}
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x0600640C RID: 25612 RVA: 0x001D6248 File Offset: 0x001D4448
		// (set) Token: 0x0600640D RID: 25613 RVA: 0x0002F208 File Offset: 0x0002D408
		public unsafe Color SkinColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_SkinColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_SkinColor)) = value;
			}
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x0600640E RID: 25614 RVA: 0x001D6270 File Offset: 0x001D4470
		// (set) Token: 0x0600640F RID: 25615 RVA: 0x0002F223 File Offset: 0x0002D423
		public unsafe Color HairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_HairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_HairColor)) = value;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06006410 RID: 25616 RVA: 0x001D6298 File Offset: 0x001D4498
		// (set) Token: 0x06006411 RID: 25617 RVA: 0x0002F23E File Offset: 0x0002D43E
		public unsafe int ClothingIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_ClothingIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_ClothingIndex)) = value;
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06006412 RID: 25618 RVA: 0x001D62C0 File Offset: 0x001D44C0
		// (set) Token: 0x06006413 RID: 25619 RVA: 0x0002F259 File Offset: 0x0002D459
		public unsafe int VoiceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_VoiceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoonAppearance.NativeFieldInfoPtr_VoiceIndex)) = value;
			}
		}

		// Token: 0x040044F9 RID: 17657
		private static readonly IntPtr NativeFieldInfoPtr_IsMale;

		// Token: 0x040044FA RID: 17658
		private static readonly IntPtr NativeFieldInfoPtr_BaseAppearanceIndex;

		// Token: 0x040044FB RID: 17659
		private static readonly IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x040044FC RID: 17660
		private static readonly IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x040044FD RID: 17661
		private static readonly IntPtr NativeFieldInfoPtr_ClothingIndex;

		// Token: 0x040044FE RID: 17662
		private static readonly IntPtr NativeFieldInfoPtr_VoiceIndex;

		// Token: 0x040044FF RID: 17663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Color_Color_Int32_Int32_0;

		// Token: 0x04004500 RID: 17664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

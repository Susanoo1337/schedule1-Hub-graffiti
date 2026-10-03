using System;
using Il2CppHSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2Cpp
{
	// Token: 0x02000022 RID: 34
	public class SColorPicker : ColorPicker
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00080BC4 File Offset: 0x0007EDC4
		// Note: this type is marked as 'beforefieldinit'.
		static SColorPicker()
		{
			Il2CppClassPointerStore<SColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr);
			SColorPicker.NativeFieldInfoPtr_PropertyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, "PropertyIndex");
			SColorPicker.NativeFieldInfoPtr_onValueChangeWithIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, "onValueChangeWithIndex");
			SColorPicker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, 100663499);
			SColorPicker.NativeMethodInfoPtr_ValueChanged_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, 100663500);
			SColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, 100663501);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00080C58 File Offset: 0x0007EE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66823, XrefRangeEnd = 66833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SColorPicker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00080C8C File Offset: 0x0007EE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66833, XrefRangeEnd = 66836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SColorPicker.NativeMethodInfoPtr_ValueChanged_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00080CCC File Offset: 0x0007EECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66836, XrefRangeEnd = 66837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002DB7 File Offset: 0x00000FB7
		public SColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00080D08 File Offset: 0x0007EF08
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public unsafe int PropertyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_PropertyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_PropertyIndex)) = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00080D30 File Offset: 0x0007EF30
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002DDB File Offset: 0x00000FDB
		public unsafe UnityEvent<Color, int> onValueChangeWithIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_onValueChangeWithIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Color, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_onValueChangeWithIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_PropertyIndex;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_onValueChangeWithIndex;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Private_Void_Color_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

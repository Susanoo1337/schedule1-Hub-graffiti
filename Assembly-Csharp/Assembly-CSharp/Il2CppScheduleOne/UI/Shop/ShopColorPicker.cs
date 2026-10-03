using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200083C RID: 2108
	public class ShopColorPicker : MonoBehaviour
	{
		// Token: 0x0600CCE1 RID: 52449 RVA: 0x00338AD0 File Offset: 0x00336CD0
		// Note: this type is marked as 'beforefieldinit'.
		static ShopColorPicker()
		{
			Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr);
			ShopColorPicker.NativeFieldInfoPtr_AssetIconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "AssetIconImage");
			ShopColorPicker.NativeFieldInfoPtr_ColorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorLabel");
			ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorButtonParent");
			ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorButtonPrefab");
			ShopColorPicker.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "Screen");
			ShopColorPicker.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "Panel");
			ShopColorPicker.NativeFieldInfoPtr_onColorPicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "onColorPicked");
			ShopColorPicker.NativeFieldInfoPtr_colorButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "colorButtons");
			ShopColorPicker.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100689689);
			ShopColorPicker.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100689690);
			ShopColorPicker.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100689691);
			ShopColorPicker.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100689692);
			ShopColorPicker.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100689693);
			ShopColorPicker.NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100689694);
			ShopColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100689695);
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x0600CCE2 RID: 52450 RVA: 0x00338C2C File Offset: 0x00336E2C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335627, XrefRangeEnd = 335630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600CCE3 RID: 52451 RVA: 0x00338C68 File Offset: 0x00336E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335630, XrefRangeEnd = 335723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCE4 RID: 52452 RVA: 0x00338C9C File Offset: 0x00336E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335723, XrefRangeEnd = 335727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorPicked(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCE5 RID: 52453 RVA: 0x00338CDC File Offset: 0x00336EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335727, XrefRangeEnd = 335741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCE6 RID: 52454 RVA: 0x00338D20 File Offset: 0x00336F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335749, RefRangeEnd = 335752, XrefRangeStart = 335741, XrefRangeEnd = 335749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCE7 RID: 52455 RVA: 0x00338D54 File Offset: 0x00336F54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335755, RefRangeEnd = 335758, XrefRangeStart = 335752, XrefRangeEnd = 335755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorHovered(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCE8 RID: 52456 RVA: 0x00338D94 File Offset: 0x00336F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335758, XrefRangeEnd = 335773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCE9 RID: 52457 RVA: 0x000613AA File Offset: 0x0005F5AA
		public ShopColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x0600CCEA RID: 52458 RVA: 0x00338DD0 File Offset: 0x00336FD0
		// (set) Token: 0x0600CCEB RID: 52459 RVA: 0x000613B3 File Offset: 0x0005F5B3
		public unsafe Image AssetIconImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_AssetIconImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_AssetIconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x0600CCEC RID: 52460 RVA: 0x00338E00 File Offset: 0x00337000
		// (set) Token: 0x0600CCED RID: 52461 RVA: 0x000613D2 File Offset: 0x0005F5D2
		public unsafe TextMeshProUGUI ColorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x0600CCEE RID: 52462 RVA: 0x00338E30 File Offset: 0x00337030
		// (set) Token: 0x0600CCEF RID: 52463 RVA: 0x000613F1 File Offset: 0x0005F5F1
		public unsafe RectTransform ColorButtonParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x0600CCF0 RID: 52464 RVA: 0x00338E60 File Offset: 0x00337060
		// (set) Token: 0x0600CCF1 RID: 52465 RVA: 0x00061410 File Offset: 0x0005F610
		public unsafe GameObject ColorButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x0600CCF2 RID: 52466 RVA: 0x00338E90 File Offset: 0x00337090
		// (set) Token: 0x0600CCF3 RID: 52467 RVA: 0x0006142F File Offset: 0x0005F62F
		public unsafe UIScreen Screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_Screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x0600CCF4 RID: 52468 RVA: 0x00338EC0 File Offset: 0x003370C0
		// (set) Token: 0x0600CCF5 RID: 52469 RVA: 0x0006144E File Offset: 0x0005F64E
		public unsafe UIPanel Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x0600CCF6 RID: 52470 RVA: 0x00338EF0 File Offset: 0x003370F0
		// (set) Token: 0x0600CCF7 RID: 52471 RVA: 0x0006146D File Offset: 0x0005F66D
		public unsafe UnityEvent<EClothingColor> onColorPicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_onColorPicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EClothingColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_onColorPicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x0600CCF8 RID: 52472 RVA: 0x00338F20 File Offset: 0x00337120
		// (set) Token: 0x0600CCF9 RID: 52473 RVA: 0x0006148C File Offset: 0x0005F68C
		public unsafe List<UISelectable> colorButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_colorButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UISelectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_colorButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008B8A RID: 35722
		private static readonly IntPtr NativeFieldInfoPtr_AssetIconImage;

		// Token: 0x04008B8B RID: 35723
		private static readonly IntPtr NativeFieldInfoPtr_ColorLabel;

		// Token: 0x04008B8C RID: 35724
		private static readonly IntPtr NativeFieldInfoPtr_ColorButtonParent;

		// Token: 0x04008B8D RID: 35725
		private static readonly IntPtr NativeFieldInfoPtr_ColorButtonPrefab;

		// Token: 0x04008B8E RID: 35726
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x04008B8F RID: 35727
		private static readonly IntPtr NativeFieldInfoPtr_Panel;

		// Token: 0x04008B90 RID: 35728
		private static readonly IntPtr NativeFieldInfoPtr_onColorPicked;

		// Token: 0x04008B91 RID: 35729
		private static readonly IntPtr NativeFieldInfoPtr_colorButtons;

		// Token: 0x04008B92 RID: 35730
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008B93 RID: 35731
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04008B94 RID: 35732
		private static readonly IntPtr NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0;

		// Token: 0x04008B95 RID: 35733
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0;

		// Token: 0x04008B96 RID: 35734
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008B97 RID: 35735
		private static readonly IntPtr NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0;

		// Token: 0x04008B98 RID: 35736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D8B RID: 3467
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopColorPicker+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FC4F RID: 64591 RVA: 0x003C2EB0 File Offset: 0x003C10B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass10_0>.NativeClassPtr);
				ShopColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass10_0>.NativeClassPtr, "color");
				ShopColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				ShopColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass10_0>.NativeClassPtr, 100689696);
				ShopColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass10_0>.NativeClassPtr, 100689697);
				ShopColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass10_0>.NativeClassPtr, 100689698);
				ShopColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Awake_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass10_0>.NativeClassPtr, 100689699);
			}

			// Token: 0x0600FC50 RID: 64592 RVA: 0x003C2F54 File Offset: 0x003C1154
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC51 RID: 64593 RVA: 0x003C2F90 File Offset: 0x003C1190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335620, XrefRangeEnd = 335625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC52 RID: 64594 RVA: 0x003C2FC4 File Offset: 0x003C11C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335625, XrefRangeEnd = 335627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC53 RID: 64595 RVA: 0x003C3008 File Offset: 0x003C1208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Awake_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC54 RID: 64596 RVA: 0x00077724 File Offset: 0x00075924
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CA9 RID: 19625
			// (get) Token: 0x0600FC55 RID: 64597 RVA: 0x003C303C File Offset: 0x003C123C
			// (set) Token: 0x0600FC56 RID: 64598 RVA: 0x0007772D File Offset: 0x0007592D
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17004CAA RID: 19626
			// (get) Token: 0x0600FC57 RID: 64599 RVA: 0x003C3064 File Offset: 0x003C1264
			// (set) Token: 0x0600FC58 RID: 64600 RVA: 0x00077748 File Offset: 0x00075948
			public unsafe ShopColorPicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopColorPicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA21 RID: 43553
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x0400AA22 RID: 43554
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA23 RID: 43555
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA24 RID: 43556
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;

			// Token: 0x0400AA25 RID: 43557
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_BaseEventData_0;

			// Token: 0x0400AA26 RID: 43558
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__2_Internal_Void_0;
		}
	}
}

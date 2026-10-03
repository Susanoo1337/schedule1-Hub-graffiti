using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x0200081C RID: 2076
	public class CharacterCreatorColor : CharacterCreatorField<Color>
	{
		// Token: 0x0600C9E5 RID: 51685 RVA: 0x0032EE40 File Offset: 0x0032D040
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorColor()
		{
			Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr);
			CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "ClothingColorsToUse");
			CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "OptionContainer");
			CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "UseClothingColors");
			CharacterCreatorColor.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "Colors");
			CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "OptionPrefab");
			CharacterCreatorColor.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "optionButtons");
			CharacterCreatorColor.NativeFieldInfoPtr_selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "selectedButton");
			CharacterCreatorColor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100689348);
			CharacterCreatorColor.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100689349);
			CharacterCreatorColor.NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100689350);
			CharacterCreatorColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100689351);
		}

		// Token: 0x0600C9E6 RID: 51686 RVA: 0x0032EF4C File Offset: 0x0032D14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331913, XrefRangeEnd = 331972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorColor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9E7 RID: 51687 RVA: 0x0032EF88 File Offset: 0x0032D188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331972, XrefRangeEnd = 331996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorColor.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9E8 RID: 51688 RVA: 0x0032EFC4 File Offset: 0x0032D1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331996, XrefRangeEnd = 332007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionClicked(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9E9 RID: 51689 RVA: 0x0032F004 File Offset: 0x0032D204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332007, XrefRangeEnd = 332017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorColor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9EA RID: 51690 RVA: 0x0005FB04 File Offset: 0x0005DD04
		public CharacterCreatorColor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x0600C9EB RID: 51691 RVA: 0x0032F040 File Offset: 0x0032D240
		// (set) Token: 0x0600C9EC RID: 51692 RVA: 0x0005FB0D File Offset: 0x0005DD0D
		public unsafe static Il2CppStructArray<EClothingColor> ClothingColorsToUse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<EClothingColor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x0600C9ED RID: 51693 RVA: 0x0032F068 File Offset: 0x0032D268
		// (set) Token: 0x0600C9EE RID: 51694 RVA: 0x0005FB1F File Offset: 0x0005DD1F
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x0600C9EF RID: 51695 RVA: 0x0032F098 File Offset: 0x0032D298
		// (set) Token: 0x0600C9F0 RID: 51696 RVA: 0x0005FB3E File Offset: 0x0005DD3E
		public unsafe bool UseClothingColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors)) = value;
			}
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x0600C9F1 RID: 51697 RVA: 0x0032F0C0 File Offset: 0x0032D2C0
		// (set) Token: 0x0600C9F2 RID: 51698 RVA: 0x0005FB59 File Offset: 0x0005DD59
		public unsafe List<Color> Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_Colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x0600C9F3 RID: 51699 RVA: 0x0032F0F0 File Offset: 0x0032D2F0
		// (set) Token: 0x0600C9F4 RID: 51700 RVA: 0x0005FB78 File Offset: 0x0005DD78
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x0600C9F5 RID: 51701 RVA: 0x0032F120 File Offset: 0x0032D320
		// (set) Token: 0x0600C9F6 RID: 51702 RVA: 0x0005FB97 File Offset: 0x0005DD97
		public unsafe List<Button> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x0600C9F7 RID: 51703 RVA: 0x0032F150 File Offset: 0x0032D350
		// (set) Token: 0x0600C9F8 RID: 51704 RVA: 0x0005FBB6 File Offset: 0x0005DDB6
		public unsafe Button selectedButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_selectedButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_selectedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008984 RID: 35204
		private static readonly IntPtr NativeFieldInfoPtr_ClothingColorsToUse;

		// Token: 0x04008985 RID: 35205
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04008986 RID: 35206
		private static readonly IntPtr NativeFieldInfoPtr_UseClothingColors;

		// Token: 0x04008987 RID: 35207
		private static readonly IntPtr NativeFieldInfoPtr_Colors;

		// Token: 0x04008988 RID: 35208
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04008989 RID: 35209
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x0400898A RID: 35210
		private static readonly IntPtr NativeFieldInfoPtr_selectedButton;

		// Token: 0x0400898B RID: 35211
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400898C RID: 35212
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x0400898D RID: 35213
		private static readonly IntPtr NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0;

		// Token: 0x0400898E RID: 35214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D7D RID: 3453
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorColor+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FBD5 RID: 64469 RVA: 0x003C1980 File Offset: 0x003BFB80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr);
				CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, "col");
				CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, 100689353);
				CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, 100689354);
			}

			// Token: 0x0600FBD6 RID: 64470 RVA: 0x003C19FC File Offset: 0x003BFBFC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBD7 RID: 64471 RVA: 0x003C1A38 File Offset: 0x003BFC38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331911, XrefRangeEnd = 331913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBD8 RID: 64472 RVA: 0x00077337 File Offset: 0x00075537
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C89 RID: 19593
			// (get) Token: 0x0600FBD9 RID: 64473 RVA: 0x003C1A6C File Offset: 0x003BFC6C
			// (set) Token: 0x0600FBDA RID: 64474 RVA: 0x00077340 File Offset: 0x00075540
			public unsafe Color col
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col)) = value;
				}
			}

			// Token: 0x17004C8A RID: 19594
			// (get) Token: 0x0600FBDB RID: 64475 RVA: 0x003C1A94 File Offset: 0x003BFC94
			// (set) Token: 0x0600FBDC RID: 64476 RVA: 0x0007735B File Offset: 0x0007555B
			public unsafe CharacterCreatorColor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorColor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9E1 RID: 43489
			private static readonly IntPtr NativeFieldInfoPtr_col;

			// Token: 0x0400A9E2 RID: 43490
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A9E3 RID: 43491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9E4 RID: 43492
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}

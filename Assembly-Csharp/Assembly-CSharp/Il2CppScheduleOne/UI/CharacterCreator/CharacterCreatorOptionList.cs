using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x0200081F RID: 2079
	public class CharacterCreatorOptionList : CharacterCreatorField<string>
	{
		// Token: 0x0600CA1D RID: 51741 RVA: 0x0032F978 File Offset: 0x0032DB78
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorOptionList()
		{
			Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorOptionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr);
			CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "OptionContainer");
			CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "CanSelectNone");
			CharacterCreatorOptionList.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "Options");
			CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "OptionPrefab");
			CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "optionButtons");
			CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "selectedButton");
			CharacterCreatorOptionList.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100689370);
			CharacterCreatorOptionList.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100689371);
			CharacterCreatorOptionList.NativeMethodInfoPtr_OptionClicked_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100689372);
			CharacterCreatorOptionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100689373);
		}

		// Token: 0x0600CA1E RID: 51742 RVA: 0x0032FA70 File Offset: 0x0032DC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332118, XrefRangeEnd = 332176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorOptionList.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA1F RID: 51743 RVA: 0x0032FAAC File Offset: 0x0032DCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332176, XrefRangeEnd = 332203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorOptionList.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA20 RID: 51744 RVA: 0x0032FAE8 File Offset: 0x0032DCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332203, XrefRangeEnd = 332222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionClicked(string option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.NativeMethodInfoPtr_OptionClicked_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA21 RID: 51745 RVA: 0x0032FB2C File Offset: 0x0032DD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332222, XrefRangeEnd = 332232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorOptionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA22 RID: 51746 RVA: 0x0005FCFA File Offset: 0x0005DEFA
		public CharacterCreatorOptionList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x0600CA23 RID: 51747 RVA: 0x0032FB68 File Offset: 0x0032DD68
		// (set) Token: 0x0600CA24 RID: 51748 RVA: 0x0005FD03 File Offset: 0x0005DF03
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x0600CA25 RID: 51749 RVA: 0x0032FB98 File Offset: 0x0032DD98
		// (set) Token: 0x0600CA26 RID: 51750 RVA: 0x0005FD22 File Offset: 0x0005DF22
		public unsafe bool CanSelectNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone)) = value;
			}
		}

		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x0600CA27 RID: 51751 RVA: 0x0032FBC0 File Offset: 0x0032DDC0
		// (set) Token: 0x0600CA28 RID: 51752 RVA: 0x0005FD3D File Offset: 0x0005DF3D
		public unsafe List<CharacterCreatorOptionList.Option> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterCreatorOptionList.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x0600CA29 RID: 51753 RVA: 0x0032FBF0 File Offset: 0x0032DDF0
		// (set) Token: 0x0600CA2A RID: 51754 RVA: 0x0005FD5C File Offset: 0x0005DF5C
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x0600CA2B RID: 51755 RVA: 0x0032FC20 File Offset: 0x0032DE20
		// (set) Token: 0x0600CA2C RID: 51756 RVA: 0x0005FD7B File Offset: 0x0005DF7B
		public unsafe List<Button> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x0600CA2D RID: 51757 RVA: 0x0032FC50 File Offset: 0x0032DE50
		// (set) Token: 0x0600CA2E RID: 51758 RVA: 0x0005FD9A File Offset: 0x0005DF9A
		public unsafe Button selectedButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040089A5 RID: 35237
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x040089A6 RID: 35238
		private static readonly IntPtr NativeFieldInfoPtr_CanSelectNone;

		// Token: 0x040089A7 RID: 35239
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x040089A8 RID: 35240
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x040089A9 RID: 35241
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x040089AA RID: 35242
		private static readonly IntPtr NativeFieldInfoPtr_selectedButton;

		// Token: 0x040089AB RID: 35243
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040089AC RID: 35244
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x040089AD RID: 35245
		private static readonly IntPtr NativeMethodInfoPtr_OptionClicked_Public_Void_String_0;

		// Token: 0x040089AE RID: 35246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D7F RID: 3455
		[Serializable]
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600FBE8 RID: 64488 RVA: 0x003C1C94 File Offset: 0x003BFE94
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr);
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "Label");
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "AssetPath");
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "ClothingItemEquivalent");
				CharacterCreatorOptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, 100689374);
			}

			// Token: 0x0600FBE9 RID: 64489 RVA: 0x003C1D10 File Offset: 0x003BFF10
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBEA RID: 64490 RVA: 0x000773E0 File Offset: 0x000755E0
			public Option(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C8E RID: 19598
			// (get) Token: 0x0600FBEB RID: 64491 RVA: 0x003C1D4C File Offset: 0x003BFF4C
			// (set) Token: 0x0600FBEC RID: 64492 RVA: 0x000773E9 File Offset: 0x000755E9
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004C8F RID: 19599
			// (get) Token: 0x0600FBED RID: 64493 RVA: 0x003C1D74 File Offset: 0x003BFF74
			// (set) Token: 0x0600FBEE RID: 64494 RVA: 0x00077408 File Offset: 0x00075608
			public unsafe string AssetPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004C90 RID: 19600
			// (get) Token: 0x0600FBEF RID: 64495 RVA: 0x003C1D9C File Offset: 0x003BFF9C
			// (set) Token: 0x0600FBF0 RID: 64496 RVA: 0x00077427 File Offset: 0x00075627
			public unsafe ClothingDefinition ClothingItemEquivalent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9EB RID: 43499
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x0400A9EC RID: 43500
			private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

			// Token: 0x0400A9ED RID: 43501
			private static readonly IntPtr NativeFieldInfoPtr_ClothingItemEquivalent;

			// Token: 0x0400A9EE RID: 43502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D80 RID: 3456
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorOptionList+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FBF1 RID: 64497 RVA: 0x003C1DCC File Offset: 0x003BFFCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr);
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, "option");
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, 100689375);
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, 100689376);
			}

			// Token: 0x0600FBF2 RID: 64498 RVA: 0x003C1E48 File Offset: 0x003C0048
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBF3 RID: 64499 RVA: 0x003C1E84 File Offset: 0x003C0084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332092, XrefRangeEnd = 332118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBF4 RID: 64500 RVA: 0x00077446 File Offset: 0x00075646
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C91 RID: 19601
			// (get) Token: 0x0600FBF5 RID: 64501 RVA: 0x003C1EB8 File Offset: 0x003C00B8
			// (set) Token: 0x0600FBF6 RID: 64502 RVA: 0x0007744F File Offset: 0x0007564F
			public unsafe string option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004C92 RID: 19602
			// (get) Token: 0x0600FBF7 RID: 64503 RVA: 0x003C1EE0 File Offset: 0x003C00E0
			// (set) Token: 0x0600FBF8 RID: 64504 RVA: 0x0007746E File Offset: 0x0007566E
			public unsafe CharacterCreatorOptionList __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorOptionList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9EF RID: 43503
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x0400A9F0 RID: 43504
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A9F1 RID: 43505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9F2 RID: 43506
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}

		// Token: 0x02000D81 RID: 3457
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorOptionList+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FBF9 RID: 64505 RVA: 0x003C1F10 File Offset: 0x003C0110
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr);
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, "option");
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, 100689377);
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, 100689378);
			}

			// Token: 0x0600FBFA RID: 64506 RVA: 0x003C1F78 File Offset: 0x003C0178
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBFB RID: 64507 RVA: 0x003C1FB4 File Offset: 0x003C01B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OptionClicked_b__0(CharacterCreatorOptionList.Option o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FBFC RID: 64508 RVA: 0x0007748D File Offset: 0x0007568D
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C93 RID: 19603
			// (get) Token: 0x0600FBFD RID: 64509 RVA: 0x003C2004 File Offset: 0x003C0204
			// (set) Token: 0x0600FBFE RID: 64510 RVA: 0x00077496 File Offset: 0x00075696
			public unsafe string option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A9F3 RID: 43507
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x0400A9F4 RID: 43508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9F5 RID: 43509
			private static readonly IntPtr NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200040E RID: 1038
	public class SpriteFont : ScriptableObject
	{
		// Token: 0x06005B6A RID: 23402 RVA: 0x001B68A0 File Offset: 0x001B4AA0
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteFont()
		{
			Il2CppClassPointerStore<SpriteFont>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "SpriteFont");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteFont>.NativeClassPtr);
			SpriteFont.NativeFieldInfoPtr_SpriteFontItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteFont>.NativeClassPtr, "SpriteFontItems");
			SpriteFont.NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteFont>.NativeClassPtr, 100675241);
			SpriteFont.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteFont>.NativeClassPtr, 100675242);
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x001B690C File Offset: 0x001B4B0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197106, RefRangeEnd = 197108, XrefRangeStart = 197092, XrefRangeEnd = 197106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetSprite(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteFont.NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x001B695C File Offset: 0x001B4B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197108, XrefRangeEnd = 197116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteFont() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteFont>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteFont.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x0002B46F File Offset: 0x0002966F
		public SpriteFont(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06005B6E RID: 23406 RVA: 0x001B6998 File Offset: 0x001B4B98
		// (set) Token: 0x06005B6F RID: 23407 RVA: 0x0002B478 File Offset: 0x00029678
		public unsafe List<SpriteFont.SpriteFontItem> SpriteFontItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteFont.NativeFieldInfoPtr_SpriteFontItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpriteFont.SpriteFontItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteFont.NativeFieldInfoPtr_SpriteFontItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003EA8 RID: 16040
		private static readonly IntPtr NativeFieldInfoPtr_SpriteFontItems;

		// Token: 0x04003EA9 RID: 16041
		private static readonly IntPtr NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0;

		// Token: 0x04003EAA RID: 16042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF3 RID: 2803
		[Serializable]
		public class SpriteFontItem : Il2CppSystem.Object
		{
			// Token: 0x0600E527 RID: 58663 RVA: 0x003803DC File Offset: 0x0037E5DC
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteFontItem()
			{
				Il2CppClassPointerStore<SpriteFont.SpriteFontItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteFont>.NativeClassPtr, "SpriteFontItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteFont.SpriteFontItem>.NativeClassPtr);
				SpriteFont.SpriteFontItem.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteFont.SpriteFontItem>.NativeClassPtr, "Name");
				SpriteFont.SpriteFontItem.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteFont.SpriteFontItem>.NativeClassPtr, "Sprite");
				SpriteFont.SpriteFontItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteFont.SpriteFontItem>.NativeClassPtr, 100675243);
			}

			// Token: 0x0600E528 RID: 58664 RVA: 0x00380444 File Offset: 0x0037E644
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpriteFontItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteFont.SpriteFontItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteFont.SpriteFontItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E529 RID: 58665 RVA: 0x0006C086 File Offset: 0x0006A286
			public SpriteFontItem(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A3 RID: 17827
			// (get) Token: 0x0600E52A RID: 58666 RVA: 0x00380480 File Offset: 0x0037E680
			// (set) Token: 0x0600E52B RID: 58667 RVA: 0x0006C08F File Offset: 0x0006A28F
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteFont.SpriteFontItem.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteFont.SpriteFontItem.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170045A4 RID: 17828
			// (get) Token: 0x0600E52C RID: 58668 RVA: 0x003804A8 File Offset: 0x0037E6A8
			// (set) Token: 0x0600E52D RID: 58669 RVA: 0x0006C0AE File Offset: 0x0006A2AE
			public unsafe Sprite Sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteFont.SpriteFontItem.NativeFieldInfoPtr_Sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteFont.SpriteFontItem.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B88 RID: 39816
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04009B89 RID: 39817
			private static readonly IntPtr NativeFieldInfoPtr_Sprite;

			// Token: 0x04009B8A RID: 39818
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AF4 RID: 2804
		[ObfuscatedName("ScheduleOne.DevUtilities.SpriteFont+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E52E RID: 58670 RVA: 0x003804D8 File Offset: 0x0037E6D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<SpriteFont.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteFont>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteFont.__c__DisplayClass1_0>.NativeClassPtr);
				SpriteFont.__c__DisplayClass1_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteFont.__c__DisplayClass1_0>.NativeClassPtr, "name");
				SpriteFont.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteFont.__c__DisplayClass1_0>.NativeClassPtr, 100675244);
				SpriteFont.__c__DisplayClass1_0.NativeMethodInfoPtr__GetSprite_b__0_Internal_Boolean_SpriteFontItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteFont.__c__DisplayClass1_0>.NativeClassPtr, 100675245);
			}

			// Token: 0x0600E52F RID: 58671 RVA: 0x00380540 File Offset: 0x0037E740
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteFont.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteFont.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E530 RID: 58672 RVA: 0x0038057C File Offset: 0x0037E77C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSprite_b__0(SpriteFont.SpriteFontItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteFont.__c__DisplayClass1_0.NativeMethodInfoPtr__GetSprite_b__0_Internal_Boolean_SpriteFontItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E531 RID: 58673 RVA: 0x0006C0CD File Offset: 0x0006A2CD
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A5 RID: 17829
			// (get) Token: 0x0600E532 RID: 58674 RVA: 0x003805CC File Offset: 0x0037E7CC
			// (set) Token: 0x0600E533 RID: 58675 RVA: 0x0006C0D6 File Offset: 0x0006A2D6
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteFont.__c__DisplayClass1_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteFont.__c__DisplayClass1_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B8B RID: 39819
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04009B8C RID: 39820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B8D RID: 39821
			private static readonly IntPtr NativeMethodInfoPtr__GetSprite_b__0_Internal_Boolean_SpriteFontItem_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.U2D
{
	// Token: 0x0200017D RID: 381
	public class SpriteAtlas : Object
	{
		// Token: 0x06001D56 RID: 7510 RVA: 0x00078EF0 File Offset: 0x000770F0
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAtlas()
		{
			Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteAtlas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr);
			SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100666452);
			SpriteAtlas.get_isVariantDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_isVariantDelegate>("UnityEngine.U2D.SpriteAtlas::get_isVariant");
			SpriteAtlas.get_tagDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_tagDelegate>("UnityEngine.U2D.SpriteAtlas::get_tag");
			SpriteAtlas.get_spriteCountDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_spriteCountDelegate>("UnityEngine.U2D.SpriteAtlas::get_spriteCount");
			SpriteAtlas.GetSpriteDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpriteDelegate>("UnityEngine.U2D.SpriteAtlas::GetSprite");
			SpriteAtlas.GetSpritesScriptingDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpritesScriptingDelegate>("UnityEngine.U2D.SpriteAtlas::GetSpritesScripting");
			SpriteAtlas.GetSpritesWithNameScriptingDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpritesWithNameScriptingDelegate>("UnityEngine.U2D.SpriteAtlas::GetSpritesWithNameScripting");
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00078F90 File Offset: 0x00077190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282324, RefRangeEnd = 1282325, XrefRangeStart = 1282322, XrefRangeEnd = 1282324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBindTo(Sprite sprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x0000DCD4 File Offset: 0x0000BED4
		public SpriteAtlas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0000DCDD File Offset: 0x0000BEDD
		public bool isVariant
		{
			get
			{
				return SpriteAtlas.get_isVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00078FE0 File Offset: 0x000771E0
		public string tag
		{
			get
			{
				IntPtr intPtr = SpriteAtlas.get_tagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x0000DCEF File Offset: 0x0000BEEF
		public int spriteCount
		{
			get
			{
				return SpriteAtlas.get_spriteCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00079004 File Offset: 0x00077204
		public Sprite GetSprite(string name)
		{
			IntPtr intPtr = SpriteAtlas.GetSpriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00079038 File Offset: 0x00077238
		public int GetSprites(Il2CppReferenceArray<Sprite> sprites)
		{
			return this.GetSpritesScripting(sprites);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00079054 File Offset: 0x00077254
		public int GetSprites(Il2CppReferenceArray<Sprite> sprites, string name)
		{
			return this.GetSpritesWithNameScripting(sprites, name);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x0000DD01 File Offset: 0x0000BF01
		public int GetSpritesScripting(Il2CppReferenceArray<Sprite> sprites)
		{
			return SpriteAtlas.GetSpritesScriptingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(sprites));
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x0000DD19 File Offset: 0x0000BF19
		public int GetSpritesWithNameScripting(Il2CppReferenceArray<Sprite> sprites, string name)
		{
			return SpriteAtlas.GetSpritesWithNameScriptingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(sprites), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0;

		// Token: 0x04001814 RID: 6164
		private static readonly SpriteAtlas.get_isVariantDelegate get_isVariantDelegateField;

		// Token: 0x04001815 RID: 6165
		private static readonly SpriteAtlas.get_tagDelegate get_tagDelegateField;

		// Token: 0x04001816 RID: 6166
		private static readonly SpriteAtlas.get_spriteCountDelegate get_spriteCountDelegateField;

		// Token: 0x04001817 RID: 6167
		private static readonly SpriteAtlas.GetSpriteDelegate GetSpriteDelegateField;

		// Token: 0x04001818 RID: 6168
		private static readonly SpriteAtlas.GetSpritesScriptingDelegate GetSpritesScriptingDelegateField;

		// Token: 0x04001819 RID: 6169
		private static readonly SpriteAtlas.GetSpritesWithNameScriptingDelegate GetSpritesWithNameScriptingDelegateField;

		// Token: 0x020009C9 RID: 2505
		// (Invoke) Token: 0x06003C11 RID: 15377
		private delegate bool get_isVariantDelegate(IntPtr @this);

		// Token: 0x020009CA RID: 2506
		// (Invoke) Token: 0x06003C13 RID: 15379
		private delegate IntPtr get_tagDelegate(IntPtr @this);

		// Token: 0x020009CB RID: 2507
		// (Invoke) Token: 0x06003C15 RID: 15381
		private delegate int get_spriteCountDelegate(IntPtr @this);

		// Token: 0x020009CC RID: 2508
		// (Invoke) Token: 0x06003C17 RID: 15383
		private delegate IntPtr GetSpriteDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020009CD RID: 2509
		// (Invoke) Token: 0x06003C19 RID: 15385
		private delegate int GetSpritesScriptingDelegate(IntPtr @this, IntPtr sprites);

		// Token: 0x020009CE RID: 2510
		// (Invoke) Token: 0x06003C1B RID: 15387
		private delegate int GetSpritesWithNameScriptingDelegate(IntPtr @this, IntPtr sprites, IntPtr name);
	}
}

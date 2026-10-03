using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200030A RID: 778
	public sealed class ShaderVariantCollection : Object
	{
		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x00014153 File Offset: 0x00012353
		public int shaderCount
		{
			get
			{
				return ShaderVariantCollection.get_shaderCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x00014165 File Offset: 0x00012365
		public int variantCount
		{
			get
			{
				return ShaderVariantCollection.get_variantCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x00014177 File Offset: 0x00012377
		public int warmedUpVariantCount
		{
			get
			{
				return ShaderVariantCollection.get_warmedUpVariantCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x00014189 File Offset: 0x00012389
		public bool isWarmedUp
		{
			get
			{
				return ShaderVariantCollection.get_isWarmedUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x0001419B File Offset: 0x0001239B
		public bool AddVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.AddVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x000141BA File Offset: 0x000123BA
		public bool RemoveVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.RemoveVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x000141D9 File Offset: 0x000123D9
		public bool ContainsVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.ContainsVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x000141F8 File Offset: 0x000123F8
		public void Clear()
		{
			ShaderVariantCollection.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x0001420A File Offset: 0x0001240A
		public void WarmUp()
		{
			ShaderVariantCollection.WarmUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x0001421C File Offset: 0x0001241C
		public bool WarmUpProgressively(int variantCount)
		{
			return ShaderVariantCollection.WarmUpProgressivelyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), variantCount);
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x0001422F File Offset: 0x0001242F
		public static void Internal_Create(ShaderVariantCollection svc)
		{
			ShaderVariantCollection.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(svc));
		}

		// Token: 0x04002816 RID: 10262
		private static readonly ShaderVariantCollection.get_shaderCountDelegate get_shaderCountDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_shaderCountDelegate>("UnityEngine.ShaderVariantCollection::get_shaderCount");

		// Token: 0x04002817 RID: 10263
		private static readonly ShaderVariantCollection.get_variantCountDelegate get_variantCountDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_variantCountDelegate>("UnityEngine.ShaderVariantCollection::get_variantCount");

		// Token: 0x04002818 RID: 10264
		private static readonly ShaderVariantCollection.get_warmedUpVariantCountDelegate get_warmedUpVariantCountDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_warmedUpVariantCountDelegate>("UnityEngine.ShaderVariantCollection::get_warmedUpVariantCount");

		// Token: 0x04002819 RID: 10265
		private static readonly ShaderVariantCollection.get_isWarmedUpDelegate get_isWarmedUpDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_isWarmedUpDelegate>("UnityEngine.ShaderVariantCollection::get_isWarmedUp");

		// Token: 0x0400281A RID: 10266
		private static readonly ShaderVariantCollection.AddVariantDelegate AddVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.AddVariantDelegate>("UnityEngine.ShaderVariantCollection::AddVariant");

		// Token: 0x0400281B RID: 10267
		private static readonly ShaderVariantCollection.RemoveVariantDelegate RemoveVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.RemoveVariantDelegate>("UnityEngine.ShaderVariantCollection::RemoveVariant");

		// Token: 0x0400281C RID: 10268
		private static readonly ShaderVariantCollection.ContainsVariantDelegate ContainsVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.ContainsVariantDelegate>("UnityEngine.ShaderVariantCollection::ContainsVariant");

		// Token: 0x0400281D RID: 10269
		private static readonly ShaderVariantCollection.ClearDelegate ClearDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.ClearDelegate>("UnityEngine.ShaderVariantCollection::Clear");

		// Token: 0x0400281E RID: 10270
		private static readonly ShaderVariantCollection.WarmUpDelegate WarmUpDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.WarmUpDelegate>("UnityEngine.ShaderVariantCollection::WarmUp");

		// Token: 0x0400281F RID: 10271
		private static readonly ShaderVariantCollection.WarmUpProgressivelyDelegate WarmUpProgressivelyDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.WarmUpProgressivelyDelegate>("UnityEngine.ShaderVariantCollection::WarmUpProgressively");

		// Token: 0x04002820 RID: 10272
		private static readonly ShaderVariantCollection.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.Internal_CreateDelegate>("UnityEngine.ShaderVariantCollection::Internal_Create");

		// Token: 0x02000CCC RID: 3276
		// (Invoke) Token: 0x06004235 RID: 16949
		private delegate int get_shaderCountDelegate(IntPtr @this);

		// Token: 0x02000CCD RID: 3277
		// (Invoke) Token: 0x06004237 RID: 16951
		private delegate int get_variantCountDelegate(IntPtr @this);

		// Token: 0x02000CCE RID: 3278
		// (Invoke) Token: 0x06004239 RID: 16953
		private delegate int get_warmedUpVariantCountDelegate(IntPtr @this);

		// Token: 0x02000CCF RID: 3279
		// (Invoke) Token: 0x0600423B RID: 16955
		private delegate bool get_isWarmedUpDelegate(IntPtr @this);

		// Token: 0x02000CD0 RID: 3280
		// (Invoke) Token: 0x0600423D RID: 16957
		private delegate bool AddVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000CD1 RID: 3281
		// (Invoke) Token: 0x0600423F RID: 16959
		private delegate bool RemoveVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000CD2 RID: 3282
		// (Invoke) Token: 0x06004241 RID: 16961
		private delegate bool ContainsVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000CD3 RID: 3283
		// (Invoke) Token: 0x06004243 RID: 16963
		private delegate void ClearDelegate(IntPtr @this);

		// Token: 0x02000CD4 RID: 3284
		// (Invoke) Token: 0x06004245 RID: 16965
		private delegate void WarmUpDelegate(IntPtr @this);

		// Token: 0x02000CD5 RID: 3285
		// (Invoke) Token: 0x06004247 RID: 16967
		private delegate bool WarmUpProgressivelyDelegate(IntPtr @this, int variantCount);

		// Token: 0x02000CD6 RID: 3286
		// (Invoke) Token: 0x06004249 RID: 16969
		private delegate void Internal_CreateDelegate(IntPtr svc);
	}
}

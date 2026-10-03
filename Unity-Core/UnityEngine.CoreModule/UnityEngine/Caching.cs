using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x020002BE RID: 702
	public sealed class Caching
	{
		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x00013899 File Offset: 0x00011A99
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x000138A5 File Offset: 0x00011AA5
		public static bool compressionEnabled
		{
			get
			{
				return Caching.get_compressionEnabledDelegateField();
			}
			set
			{
				Caching.set_compressionEnabledDelegateField(value);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x000138B2 File Offset: 0x00011AB2
		public static bool ready
		{
			get
			{
				return Caching.get_readyDelegateField();
			}
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000138BE File Offset: 0x00011ABE
		public static bool ClearCache()
		{
			return Caching.ClearCacheDelegateField();
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000AB788 File Offset: 0x000A9988
		public static bool ClearCache(int expiration)
		{
			return Caching.ClearCache_Int(expiration);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000138CA File Offset: 0x00011ACA
		public static bool ClearCache_Int(int expiration)
		{
			return Caching.ClearCache_IntDelegateField(expiration);
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000AB7A0 File Offset: 0x000A99A0
		public static bool ClearCachedVersion(string assetBundleName, Hash128 hash)
		{
			bool flag = String.IsNullOrEmpty(assetBundleName);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle name cannot be null or empty.");
			}
			return Caching.ClearCachedVersionInternal(assetBundleName, hash);
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x000138D7 File Offset: 0x00011AD7
		public static bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash)
		{
			return Caching.ClearCachedVersionInternal_Injected(assetBundleName, ref hash);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000AB7D0 File Offset: 0x000A99D0
		public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash)
		{
			bool flag = String.IsNullOrEmpty(assetBundleName);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle name cannot be null or empty.");
			}
			return Caching.ClearCachedVersions(assetBundleName, hash, true);
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x000AB800 File Offset: 0x000A9A00
		public static bool ClearAllCachedVersions(string assetBundleName)
		{
			bool flag = String.IsNullOrEmpty(assetBundleName);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle name cannot be null or empty.");
			}
			return Caching.ClearCachedVersions(assetBundleName, default(Hash128), false);
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x000138E1 File Offset: 0x00011AE1
		public static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion)
		{
			return Caching.ClearCachedVersions_Injected(assetBundleName, ref hash, keepInputVersion);
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x000AB838 File Offset: 0x000A9A38
		public static Il2CppStructArray<Hash128> GetCachedVersions(string assetBundleName)
		{
			IntPtr intPtr = Caching.GetCachedVersionsDelegateField(IL2CPP.ManagedStringToIl2Cpp(assetBundleName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Hash128>>(intPtr2) : null;
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000AB864 File Offset: 0x000A9A64
		public static void GetCachedVersions(string assetBundleName, List<Hash128> outCachedVersions)
		{
			bool flag = String.IsNullOrEmpty(assetBundleName);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle name cannot be null or empty.");
			}
			bool flag2 = outCachedVersions == null;
			if (flag2)
			{
				throw new ArgumentNullException("Input outCachedVersions cannot be null.");
			}
			outCachedVersions.AddRange(Caching.GetCachedVersions(assetBundleName));
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x000AB8A8 File Offset: 0x000A9AA8
		public static bool IsVersionCached(string url, int version)
		{
			return Caching.IsVersionCached(url, new Hash128(0U, 0U, 0U, (uint)version));
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x000AB8CC File Offset: 0x000A9ACC
		public static bool IsVersionCached(string url, Hash128 hash)
		{
			bool flag = String.IsNullOrEmpty(url);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle url cannot be null or empty.");
			}
			return Caching.IsVersionCached(url, "", hash);
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x000138EC File Offset: 0x00011AEC
		public static bool IsVersionCached(string url, string assetBundleName, Hash128 hash)
		{
			return Caching.IsVersionCached_Injected(url, assetBundleName, ref hash);
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x000AB900 File Offset: 0x000A9B00
		public static bool MarkAsUsed(string url, int version)
		{
			return Caching.MarkAsUsed(url, new Hash128(0U, 0U, 0U, (uint)version));
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x000AB924 File Offset: 0x000A9B24
		public static bool MarkAsUsed(string url, Hash128 hash)
		{
			bool flag = String.IsNullOrEmpty(url);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle url cannot be null or empty.");
			}
			return Caching.MarkAsUsed(url, "", hash);
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x000138F7 File Offset: 0x00011AF7
		public static bool MarkAsUsed(string url, string assetBundleName, Hash128 hash)
		{
			return Caching.MarkAsUsed_Injected(url, assetBundleName, ref hash);
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x000AB958 File Offset: 0x000A9B58
		public static int GetVersionFromCache(string url)
		{
			return -1;
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x000AB96C File Offset: 0x000A9B6C
		public static int spaceUsed
		{
			get
			{
				return (int)Caching.spaceOccupied;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x00013902 File Offset: 0x00011B02
		public static long spaceOccupied
		{
			get
			{
				return Caching.get_spaceOccupiedDelegateField();
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x000AB984 File Offset: 0x000A9B84
		public static int spaceAvailable
		{
			get
			{
				return (int)Caching.spaceFree;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x0001390E File Offset: 0x00011B0E
		public static long spaceFree
		{
			get
			{
				return Caching.get_spaceFreeDelegateField();
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x0001391A File Offset: 0x00011B1A
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x00013926 File Offset: 0x00011B26
		public static long maximumAvailableDiskSpace
		{
			get
			{
				return Caching.get_maximumAvailableDiskSpaceDelegateField();
			}
			set
			{
				Caching.set_maximumAvailableDiskSpaceDelegateField(value);
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x00013933 File Offset: 0x00011B33
		// (set) Token: 0x06002CB7 RID: 11447 RVA: 0x0001393F File Offset: 0x00011B3F
		public static int expirationDelay
		{
			get
			{
				return Caching.get_expirationDelayDelegateField();
			}
			set
			{
				Caching.set_expirationDelayDelegateField(value);
			}
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x0001394C File Offset: 0x00011B4C
		public static void GetAllCachePaths(List<string> cachePaths)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x00013959 File Offset: 0x00011B59
		public static int cacheCount
		{
			get
			{
				return Caching.get_cacheCountDelegateField();
			}
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x000AB99C File Offset: 0x000A9B9C
		public static bool CleanCache()
		{
			return Caching.ClearCache();
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x00013965 File Offset: 0x00011B65
		public static bool ClearCachedVersionInternal_Injected(string assetBundleName, ref Hash128 hash)
		{
			return Caching.ClearCachedVersionInternal_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(assetBundleName), ref hash);
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x00013978 File Offset: 0x00011B78
		public static bool ClearCachedVersions_Injected(string assetBundleName, ref Hash128 hash, bool keepInputVersion)
		{
			return Caching.ClearCachedVersions_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(assetBundleName), ref hash, keepInputVersion);
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x0001398C File Offset: 0x00011B8C
		public static bool IsVersionCached_Injected(string url, string assetBundleName, ref Hash128 hash)
		{
			return Caching.IsVersionCached_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(url), IL2CPP.ManagedStringToIl2Cpp(assetBundleName), ref hash);
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x000139A5 File Offset: 0x00011BA5
		public static bool MarkAsUsed_Injected(string url, string assetBundleName, ref Hash128 hash)
		{
			return Caching.MarkAsUsed_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(url), IL2CPP.ManagedStringToIl2Cpp(assetBundleName), ref hash);
		}

		// Token: 0x040026F6 RID: 9974
		private static readonly Caching.get_compressionEnabledDelegate get_compressionEnabledDelegateField = IL2CPP.ResolveICall<Caching.get_compressionEnabledDelegate>("UnityEngine.Caching::get_compressionEnabled");

		// Token: 0x040026F7 RID: 9975
		private static readonly Caching.set_compressionEnabledDelegate set_compressionEnabledDelegateField = IL2CPP.ResolveICall<Caching.set_compressionEnabledDelegate>("UnityEngine.Caching::set_compressionEnabled");

		// Token: 0x040026F8 RID: 9976
		private static readonly Caching.get_readyDelegate get_readyDelegateField = IL2CPP.ResolveICall<Caching.get_readyDelegate>("UnityEngine.Caching::get_ready");

		// Token: 0x040026F9 RID: 9977
		private static readonly Caching.ClearCacheDelegate ClearCacheDelegateField = IL2CPP.ResolveICall<Caching.ClearCacheDelegate>("UnityEngine.Caching::ClearCache");

		// Token: 0x040026FA RID: 9978
		private static readonly Caching.ClearCache_IntDelegate ClearCache_IntDelegateField = IL2CPP.ResolveICall<Caching.ClearCache_IntDelegate>("UnityEngine.Caching::ClearCache_Int");

		// Token: 0x040026FB RID: 9979
		private static readonly Caching.GetCachedVersionsDelegate GetCachedVersionsDelegateField = IL2CPP.ResolveICall<Caching.GetCachedVersionsDelegate>("UnityEngine.Caching::GetCachedVersions");

		// Token: 0x040026FC RID: 9980
		private static readonly Caching.get_spaceOccupiedDelegate get_spaceOccupiedDelegateField = IL2CPP.ResolveICall<Caching.get_spaceOccupiedDelegate>("UnityEngine.Caching::get_spaceOccupied");

		// Token: 0x040026FD RID: 9981
		private static readonly Caching.get_spaceFreeDelegate get_spaceFreeDelegateField = IL2CPP.ResolveICall<Caching.get_spaceFreeDelegate>("UnityEngine.Caching::get_spaceFree");

		// Token: 0x040026FE RID: 9982
		private static readonly Caching.get_maximumAvailableDiskSpaceDelegate get_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<Caching.get_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::get_maximumAvailableDiskSpace");

		// Token: 0x040026FF RID: 9983
		private static readonly Caching.set_maximumAvailableDiskSpaceDelegate set_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<Caching.set_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::set_maximumAvailableDiskSpace");

		// Token: 0x04002700 RID: 9984
		private static readonly Caching.get_expirationDelayDelegate get_expirationDelayDelegateField = IL2CPP.ResolveICall<Caching.get_expirationDelayDelegate>("UnityEngine.Caching::get_expirationDelay");

		// Token: 0x04002701 RID: 9985
		private static readonly Caching.set_expirationDelayDelegate set_expirationDelayDelegateField = IL2CPP.ResolveICall<Caching.set_expirationDelayDelegate>("UnityEngine.Caching::set_expirationDelay");

		// Token: 0x04002702 RID: 9986
		private static readonly Caching.get_cacheCountDelegate get_cacheCountDelegateField = IL2CPP.ResolveICall<Caching.get_cacheCountDelegate>("UnityEngine.Caching::get_cacheCount");

		// Token: 0x04002703 RID: 9987
		private static readonly Caching.ClearCachedVersionInternal_InjectedDelegate ClearCachedVersionInternal_InjectedDelegateField = IL2CPP.ResolveICall<Caching.ClearCachedVersionInternal_InjectedDelegate>("UnityEngine.Caching::ClearCachedVersionInternal_Injected");

		// Token: 0x04002704 RID: 9988
		private static readonly Caching.ClearCachedVersions_InjectedDelegate ClearCachedVersions_InjectedDelegateField = IL2CPP.ResolveICall<Caching.ClearCachedVersions_InjectedDelegate>("UnityEngine.Caching::ClearCachedVersions_Injected");

		// Token: 0x04002705 RID: 9989
		private static readonly Caching.IsVersionCached_InjectedDelegate IsVersionCached_InjectedDelegateField = IL2CPP.ResolveICall<Caching.IsVersionCached_InjectedDelegate>("UnityEngine.Caching::IsVersionCached_Injected");

		// Token: 0x04002706 RID: 9990
		private static readonly Caching.MarkAsUsed_InjectedDelegate MarkAsUsed_InjectedDelegateField = IL2CPP.ResolveICall<Caching.MarkAsUsed_InjectedDelegate>("UnityEngine.Caching::MarkAsUsed_Injected");

		// Token: 0x02000C6B RID: 3179
		// (Invoke) Token: 0x06004175 RID: 16757
		private delegate bool get_compressionEnabledDelegate();

		// Token: 0x02000C6C RID: 3180
		// (Invoke) Token: 0x06004177 RID: 16759
		private delegate void set_compressionEnabledDelegate(bool value);

		// Token: 0x02000C6D RID: 3181
		// (Invoke) Token: 0x06004179 RID: 16761
		private delegate bool get_readyDelegate();

		// Token: 0x02000C6E RID: 3182
		// (Invoke) Token: 0x0600417B RID: 16763
		private delegate bool ClearCacheDelegate();

		// Token: 0x02000C6F RID: 3183
		// (Invoke) Token: 0x0600417D RID: 16765
		private delegate bool ClearCache_IntDelegate(int expiration);

		// Token: 0x02000C70 RID: 3184
		// (Invoke) Token: 0x0600417F RID: 16767
		private delegate IntPtr GetCachedVersionsDelegate(IntPtr assetBundleName);

		// Token: 0x02000C71 RID: 3185
		// (Invoke) Token: 0x06004181 RID: 16769
		private delegate long get_spaceOccupiedDelegate();

		// Token: 0x02000C72 RID: 3186
		// (Invoke) Token: 0x06004183 RID: 16771
		private delegate long get_spaceFreeDelegate();

		// Token: 0x02000C73 RID: 3187
		// (Invoke) Token: 0x06004185 RID: 16773
		private delegate long get_maximumAvailableDiskSpaceDelegate();

		// Token: 0x02000C74 RID: 3188
		// (Invoke) Token: 0x06004187 RID: 16775
		private delegate void set_maximumAvailableDiskSpaceDelegate(long value);

		// Token: 0x02000C75 RID: 3189
		// (Invoke) Token: 0x06004189 RID: 16777
		private delegate int get_expirationDelayDelegate();

		// Token: 0x02000C76 RID: 3190
		// (Invoke) Token: 0x0600418B RID: 16779
		private delegate void set_expirationDelayDelegate(int value);

		// Token: 0x02000C77 RID: 3191
		// (Invoke) Token: 0x0600418D RID: 16781
		private delegate int get_cacheCountDelegate();

		// Token: 0x02000C78 RID: 3192
		// (Invoke) Token: 0x0600418F RID: 16783
		private delegate bool ClearCachedVersionInternal_InjectedDelegate(IntPtr assetBundleName, IntPtr hash);

		// Token: 0x02000C79 RID: 3193
		// (Invoke) Token: 0x06004191 RID: 16785
		private delegate bool ClearCachedVersions_InjectedDelegate(IntPtr assetBundleName, IntPtr hash, bool keepInputVersion);

		// Token: 0x02000C7A RID: 3194
		// (Invoke) Token: 0x06004193 RID: 16787
		private delegate bool IsVersionCached_InjectedDelegate(IntPtr url, IntPtr assetBundleName, IntPtr hash);

		// Token: 0x02000C7B RID: 3195
		// (Invoke) Token: 0x06004195 RID: 16789
		private delegate bool MarkAsUsed_InjectedDelegate(IntPtr url, IntPtr assetBundleName, IntPtr hash);
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Serialization
{
	// Token: 0x0200031F RID: 799
	public sealed class ManagedReferenceUtility
	{
		// Token: 0x06002D9D RID: 11677 RVA: 0x000143BA File Offset: 0x000125BA
		public static bool SetManagedReferenceIdForObjectInternal(Object obj, Object scriptObj, long refId)
		{
			return ManagedReferenceUtility.SetManagedReferenceIdForObjectInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.Il2CppObjectBaseToPtr(scriptObj), refId);
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x000ACD1C File Offset: 0x000AAF1C
		public static bool SetManagedReferenceIdForObject(Object obj, Object scriptObj, long refId)
		{
			bool flag = scriptObj == null;
			bool result;
			if (flag)
			{
				result = (refId == -2L);
			}
			else
			{
				Type type = scriptObj.GetType();
				bool flag2 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()) || type.IsSubclassOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
				if (flag2)
				{
					throw new InvalidOperationException("Cannot assign an object deriving from UnityEngine.Object to a managed reference. This is not supported.");
				}
				result = ManagedReferenceUtility.SetManagedReferenceIdForObjectInternal(obj, scriptObj, refId);
			}
			return result;
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x000143D3 File Offset: 0x000125D3
		public static long GetManagedReferenceIdForObjectInternal(Object obj, Object scriptObj)
		{
			return ManagedReferenceUtility.GetManagedReferenceIdForObjectInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.Il2CppObjectBaseToPtr(scriptObj));
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x000ACD84 File Offset: 0x000AAF84
		public static long GetManagedReferenceIdForObject(Object obj, Object scriptObj)
		{
			return ManagedReferenceUtility.GetManagedReferenceIdForObjectInternal(obj, scriptObj);
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000ACDA0 File Offset: 0x000AAFA0
		public static Object GetManagedReferenceInternal(Object obj, long id)
		{
			IntPtr intPtr = ManagedReferenceUtility.GetManagedReferenceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), id);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000ACDD0 File Offset: 0x000AAFD0
		public static Object GetManagedReference(Object obj, long id)
		{
			return ManagedReferenceUtility.GetManagedReferenceInternal(obj, id);
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000ACDEC File Offset: 0x000AAFEC
		public static Il2CppStructArray<long> GetManagedReferenceIdsForObjectInternal(Object obj)
		{
			IntPtr intPtr = ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000ACE18 File Offset: 0x000AB018
		public static Il2CppStructArray<long> GetManagedReferenceIds(Object obj)
		{
			return ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternal(obj);
		}

		// Token: 0x04002871 RID: 10353
		public const long RefIdUnknown = -1L;

		// Token: 0x04002872 RID: 10354
		public const long RefIdNull = -2L;

		// Token: 0x04002873 RID: 10355
		private static readonly ManagedReferenceUtility.SetManagedReferenceIdForObjectInternalDelegate SetManagedReferenceIdForObjectInternalDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.SetManagedReferenceIdForObjectInternalDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::SetManagedReferenceIdForObjectInternal");

		// Token: 0x04002874 RID: 10356
		private static readonly ManagedReferenceUtility.GetManagedReferenceIdForObjectInternalDelegate GetManagedReferenceIdForObjectInternalDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.GetManagedReferenceIdForObjectInternalDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceIdForObjectInternal");

		// Token: 0x04002875 RID: 10357
		private static readonly ManagedReferenceUtility.GetManagedReferenceInternalDelegate GetManagedReferenceInternalDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.GetManagedReferenceInternalDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceInternal");

		// Token: 0x04002876 RID: 10358
		private static readonly ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternalDelegate GetManagedReferenceIdsForObjectInternalDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternalDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceIdsForObjectInternal");

		// Token: 0x02000CDF RID: 3295
		// (Invoke) Token: 0x0600425B RID: 16987
		private delegate bool SetManagedReferenceIdForObjectInternalDelegate(IntPtr obj, IntPtr scriptObj, long refId);

		// Token: 0x02000CE0 RID: 3296
		// (Invoke) Token: 0x0600425D RID: 16989
		private delegate long GetManagedReferenceIdForObjectInternalDelegate(IntPtr obj, IntPtr scriptObj);

		// Token: 0x02000CE1 RID: 3297
		// (Invoke) Token: 0x0600425F RID: 16991
		private delegate IntPtr GetManagedReferenceInternalDelegate(IntPtr obj, long id);

		// Token: 0x02000CE2 RID: 3298
		// (Invoke) Token: 0x06004261 RID: 16993
		private delegate IntPtr GetManagedReferenceIdsForObjectInternalDelegate(IntPtr obj);
	}
}

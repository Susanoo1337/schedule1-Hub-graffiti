using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x0200011B RID: 283
	public sealed class Resources : Object
	{
		// Token: 0x06001711 RID: 5905 RVA: 0x000643C8 File Offset: 0x000625C8
		// Note: this type is marked as 'beforefieldinit'.
		static Resources()
		{
			Il2CppClassPointerStore<Resources>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Resources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resources>.NativeClassPtr);
			Resources.NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665722);
			Resources.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665723);
			Resources.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665724);
			Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665725);
			Resources.NativeMethodInfoPtr_Load_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665726);
			Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665727);
			Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665728);
			Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665729);
			Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665730);
			Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665731);
			Resources.NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100665732);
			Resources.UnloadAssetImplResourceManagerDelegateField = IL2CPP.ResolveICall<Resources.UnloadAssetImplResourceManagerDelegate>("UnityEngine.Resources::UnloadAssetImplResourceManager");
			Resources.InstanceIDToObjectDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDToObjectDelegate>("UnityEngine.Resources::InstanceIDToObject");
			Resources.InstanceIDToObjectListDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDToObjectListDelegate>("UnityEngine.Resources::InstanceIDToObjectList");
			Resources.InstanceIDsToValidArray_InternalDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDsToValidArray_InternalDelegate>("UnityEngine.Resources::InstanceIDsToValidArray_Internal");
			Resources.InstanceIDIsValidDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDIsValidDelegate>("UnityEngine.Resources::InstanceIDIsValid");
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00064520 File Offset: 0x00062720
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1246789, RefRangeEnd = 1246792, XrefRangeStart = 1246781, XrefRangeEnd = 1246789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ConvertObjects<T>(Il2CppReferenceArray<Object> rawObjects) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0006455C File Offset: 0x0006275C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1246797, RefRangeEnd = 1246799, XrefRangeStart = 1246792, XrefRangeEnd = 1246797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x000645A0 File Offset: 0x000627A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1246806, RefRangeEnd = 1246810, XrefRangeStart = 1246799, XrefRangeEnd = 1246806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FindObjectsOfTypeAll<T>() where T : Object
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000645CC File Offset: 0x000627CC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1246821, RefRangeEnd = 1246833, XrefRangeStart = 1246810, XrefRangeEnd = 1246821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Load(string path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00064610 File Offset: 0x00062810
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1246840, RefRangeEnd = 1246876, XrefRangeStart = 1246833, XrefRangeEnd = 1246840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Load<T>(string path) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00064650 File Offset: 0x00062850
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1246881, RefRangeEnd = 1246886, XrefRangeStart = 1246876, XrefRangeEnd = 1246881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Load(string path, Type systemTypeInstance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000646A8 File Offset: 0x000628A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246891, RefRangeEnd = 1246892, XrefRangeStart = 1246886, XrefRangeEnd = 1246891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> LoadAll(string path, Type systemTypeInstance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00064700 File Offset: 0x00062900
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1246899, RefRangeEnd = 1246903, XrefRangeStart = 1246892, XrefRangeEnd = 1246899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> LoadAll<T>(string path) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0006473C File Offset: 0x0006293C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246905, RefRangeEnd = 1246906, XrefRangeStart = 1246903, XrefRangeEnd = 1246905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetBuiltinResource(Type type, string path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00064794 File Offset: 0x00062994
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1246913, RefRangeEnd = 1246915, XrefRangeStart = 1246906, XrefRangeEnd = 1246913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetBuiltinResource<T>(string path) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_GetBuiltinResource_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x000647D4 File Offset: 0x000629D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246917, RefRangeEnd = 1246918, XrefRangeStart = 1246915, XrefRangeEnd = 1246917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadUnusedAssets()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0000B7E1 File Offset: 0x000099E1
		public Resources(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00064808 File Offset: 0x00062A08
		public static ResourceRequest LoadAsync(string path)
		{
			return Resources.LoadAsync(path, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0006482C File Offset: 0x00062A2C
		public static ResourceRequest LoadAsync<T>(string path) where T : Object
		{
			return Resources.LoadAsync(path, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00064850 File Offset: 0x00062A50
		public static ResourceRequest LoadAsync(string path, Type type)
		{
			return ResourcesAPI.ActiveAPI.LoadAsync(path, type);
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0000B7EA File Offset: 0x000099EA
		public static void UnloadAsset(Object assetToUnload)
		{
			ResourcesAPI.ActiveAPI.UnloadAsset(assetToUnload);
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0000B7F9 File Offset: 0x000099F9
		public static void UnloadAssetImplResourceManager(Object assetToUnload)
		{
			Resources.UnloadAssetImplResourceManagerDelegateField(IL2CPP.Il2CppObjectBaseToPtr(assetToUnload));
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00064870 File Offset: 0x00062A70
		public static Object InstanceIDToObject(int instanceID)
		{
			IntPtr intPtr = Resources.InstanceIDToObjectDelegateField(instanceID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0000B80B File Offset: 0x00009A0B
		public static void InstanceIDToObjectList(IntPtr instanceIDs, int instanceCount, List<Object> objects)
		{
			Resources.InstanceIDToObjectListDelegateField(instanceIDs, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(objects));
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00064898 File Offset: 0x00062A98
		public static void InstanceIDToObjectList(Unity.Collections.NativeArray<int> instanceIDs, List<Object> objects)
		{
			bool flag = !instanceIDs.IsCreated;
			if (flag)
			{
				throw new ArgumentException("NativeArray is uninitialized", "instanceIDs");
			}
			bool flag2 = objects == null;
			if (flag2)
			{
				throw new ArgumentNullException("objects");
			}
			bool flag3 = instanceIDs.Length == 0;
			if (flag3)
			{
				objects.Clear();
			}
			else
			{
				Resources.InstanceIDToObjectList((IntPtr)instanceIDs.GetUnsafeReadOnlyPtr<int>(), instanceIDs.Length, objects);
			}
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0000B81F File Offset: 0x00009A1F
		public static void InstanceIDsToValidArray_Internal(IntPtr instanceIDs, int instanceCount, IntPtr validArray, int validArrayCount)
		{
			Resources.InstanceIDsToValidArray_InternalDelegateField(instanceIDs, instanceCount, validArray, validArrayCount);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0000B82F File Offset: 0x00009A2F
		public static bool InstanceIDIsValid(int instanceId)
		{
			return Resources.InstanceIDIsValidDelegateField(instanceId);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00064908 File Offset: 0x00062B08
		public static void InstanceIDsToValidArray(Unity.Collections.NativeArray<int> instanceIDs, Unity.Collections.NativeArray<bool> validArray)
		{
			bool flag = !instanceIDs.IsCreated;
			if (flag)
			{
				throw new ArgumentException("NativeArray is uninitialized", "instanceIDs");
			}
			bool flag2 = !validArray.IsCreated;
			if (flag2)
			{
				throw new ArgumentException("NativeArray is uninitialized", "validArray");
			}
			bool flag3 = instanceIDs.Length != validArray.Length;
			if (flag3)
			{
				throw new ArgumentException("Size mismatch! Both arrays must be the same length.");
			}
			bool flag4 = instanceIDs.Length == 0;
			if (!flag4)
			{
				Resources.InstanceIDsToValidArray_Internal((IntPtr)instanceIDs.GetUnsafeReadOnlyPtr<int>(), instanceIDs.Length, (IntPtr)validArray.GetUnsafePtr<bool>(), validArray.Length);
			}
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x000649B0 File Offset: 0x00062BB0
		public unsafe static void InstanceIDsToValidArray(ReadOnlySpan<int> instanceIDs, Span<bool> validArray)
		{
			bool flag = instanceIDs.Length != validArray.Length;
			if (flag)
			{
				throw new ArgumentException("Size mismatch! Both arrays must be the same length.");
			}
			bool flag2 = instanceIDs.Length == 0;
			if (!flag2)
			{
				fixed (int* pinnableReference = instanceIDs.GetPinnableReference())
				{
					int* value = pinnableReference;
					fixed (bool* pinnableReference2 = validArray.GetPinnableReference())
					{
						bool* value2 = pinnableReference2;
						Resources.InstanceIDsToValidArray_Internal((IntPtr)((void*)value), instanceIDs.Length, (IntPtr)((void*)value2), validArray.Length);
					}
				}
			}
		}

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_0;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly Resources.UnloadAssetImplResourceManagerDelegate UnloadAssetImplResourceManagerDelegateField;

		// Token: 0x040013B2 RID: 5042
		private static readonly Resources.InstanceIDToObjectDelegate InstanceIDToObjectDelegateField;

		// Token: 0x040013B3 RID: 5043
		private static readonly Resources.InstanceIDToObjectListDelegate InstanceIDToObjectListDelegateField;

		// Token: 0x040013B4 RID: 5044
		private static readonly Resources.InstanceIDsToValidArray_InternalDelegate InstanceIDsToValidArray_InternalDelegateField;

		// Token: 0x040013B5 RID: 5045
		private static readonly Resources.InstanceIDIsValidDelegate InstanceIDIsValidDelegateField;

		// Token: 0x0200089B RID: 2203
		private sealed class MethodInfoStoreGeneric_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x04002AF9 RID: 11001
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200089C RID: 2204
		private sealed class MethodInfoStoreGeneric_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002AFA RID: 11002
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200089D RID: 2205
		private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>
		{
			// Token: 0x04002AFB RID: 11003
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_Load_Public_Static_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200089E RID: 2206
		private sealed class MethodInfoStoreGeneric_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0<T>
		{
			// Token: 0x04002AFC RID: 11004
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200089F RID: 2207
		private sealed class MethodInfoStoreGeneric_GetBuiltinResource_Public_Static_T_String_0<T>
		{
			// Token: 0x04002AFD RID: 11005
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008A0 RID: 2208
		// (Invoke) Token: 0x060039C1 RID: 14785
		private delegate void UnloadAssetImplResourceManagerDelegate(IntPtr assetToUnload);

		// Token: 0x020008A1 RID: 2209
		// (Invoke) Token: 0x060039C3 RID: 14787
		private delegate IntPtr InstanceIDToObjectDelegate(int instanceID);

		// Token: 0x020008A2 RID: 2210
		// (Invoke) Token: 0x060039C5 RID: 14789
		private delegate void InstanceIDToObjectListDelegate(IntPtr instanceIDs, int instanceCount, IntPtr objects);

		// Token: 0x020008A3 RID: 2211
		// (Invoke) Token: 0x060039C7 RID: 14791
		private delegate void InstanceIDsToValidArray_InternalDelegate(IntPtr instanceIDs, int instanceCount, IntPtr validArray, int validArrayCount);

		// Token: 0x020008A4 RID: 2212
		// (Invoke) Token: 0x060039C9 RID: 14793
		private delegate bool InstanceIDIsValidDelegate(int instanceId);
	}
}

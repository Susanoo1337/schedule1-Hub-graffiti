using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000119 RID: 281
	public static class ResourcesAPIInternal : Object
	{
		// Token: 0x060016F9 RID: 5881 RVA: 0x00063E20 File Offset: 0x00062020
		// Note: this type is marked as 'beforefieldinit'.
		static ResourcesAPIInternal()
		{
			Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ResourcesAPIInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr);
			ResourcesAPIInternal.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100665710);
			ResourcesAPIInternal.NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100665711);
			ResourcesAPIInternal.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100665712);
			ResourcesAPIInternal.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100665713);
			ResourcesAPIInternal.LoadAsyncInternalDelegateField = IL2CPP.ResolveICall<ResourcesAPIInternal.LoadAsyncInternalDelegate>("UnityEngine.ResourcesAPIInternal::LoadAsyncInternal");
			ResourcesAPIInternal.UnloadAssetDelegateField = IL2CPP.ResolveICall<ResourcesAPIInternal.UnloadAssetDelegate>("UnityEngine.ResourcesAPIInternal::UnloadAsset");
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00063EC0 File Offset: 0x000620C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246739, XrefRangeEnd = 1246741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00063F04 File Offset: 0x00062104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246741, XrefRangeEnd = 1246743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Shader FindShaderByName(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00063F48 File Offset: 0x00062148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246743, XrefRangeEnd = 1246745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Load(string path, Type systemTypeInstance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00063FA0 File Offset: 0x000621A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246745, XrefRangeEnd = 1246747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> LoadAll(string path, Type systemTypeInstance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0000B788 File Offset: 0x00009988
		public ResourcesAPIInternal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00063FF8 File Offset: 0x000621F8
		public static ResourceRequest LoadAsyncInternal(string path, Type type)
		{
			IntPtr intPtr = ResourcesAPIInternal.LoadAsyncInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(path), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0000B791 File Offset: 0x00009991
		public static void UnloadAsset(Object assetToUnload)
		{
			ResourcesAPIInternal.UnloadAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtr(assetToUnload));
		}

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0;

		// Token: 0x0400139B RID: 5019
		private static readonly ResourcesAPIInternal.LoadAsyncInternalDelegate LoadAsyncInternalDelegateField;

		// Token: 0x0400139C RID: 5020
		private static readonly ResourcesAPIInternal.UnloadAssetDelegate UnloadAssetDelegateField;

		// Token: 0x02000898 RID: 2200
		public static class EntitiesAssetGC
		{
		}

		// Token: 0x02000899 RID: 2201
		// (Invoke) Token: 0x060039B8 RID: 14776
		private delegate IntPtr LoadAsyncInternalDelegate(IntPtr path, IntPtr type);

		// Token: 0x0200089A RID: 2202
		// (Invoke) Token: 0x060039BA RID: 14778
		private delegate void UnloadAssetDelegate(IntPtr assetToUnload);
	}
}

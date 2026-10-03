using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200011A RID: 282
	public class ResourcesAPI : Object
	{
		// Token: 0x06001701 RID: 5889 RVA: 0x0006402C File Offset: 0x0006222C
		// Note: this type is marked as 'beforefieldinit'.
		static ResourcesAPI()
		{
			Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ResourcesAPI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr);
			ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, "s_DefaultAPI");
			ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, "<overrideAPI>k__BackingField");
			ResourcesAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100665714);
			ResourcesAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100665715);
			ResourcesAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100665716);
			ResourcesAPI.NativeMethodInfoPtr_FindObjectsOfTypeAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100665717);
			ResourcesAPI.NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100665718);
			ResourcesAPI.NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100665719);
			ResourcesAPI.NativeMethodInfoPtr_LoadAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100665720);
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x00064110 File Offset: 0x00062310
		public unsafe static ResourcesAPI ActiveAPI
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1246757, RefRangeEnd = 1246762, XrefRangeStart = 1246747, XrefRangeEnd = 1246757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr3) : null;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00064144 File Offset: 0x00062344
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000B7D0 File Offset: 0x000099D0
		public unsafe static ResourcesAPI overrideAPI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246762, XrefRangeEnd = 1246766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr3) : null;
			}
			set
			{
				ResourcesAPI._overrideAPI_k__BackingField = value;
			}
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00064178 File Offset: 0x00062378
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourcesAPI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x000641B4 File Offset: 0x000623B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246766, XrefRangeEnd = 1246768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type systemTypeInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_FindObjectsOfTypeAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00064210 File Offset: 0x00062410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246768, XrefRangeEnd = 1246770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Shader FindShaderByName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0006426C File Offset: 0x0006246C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246770, XrefRangeEnd = 1246779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Load(string path, Type systemTypeInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x000642DC File Offset: 0x000624DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246779, XrefRangeEnd = 1246781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> LoadAll(string path, Type systemTypeInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_LoadAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0000B7A3 File Offset: 0x000099A3
		public ResourcesAPI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x0006434C File Offset: 0x0006254C
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x0000B7AC File Offset: 0x000099AC
		public unsafe static ResourcesAPI s_DefaultAPI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x00064374 File Offset: 0x00062574
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x0000B7BE File Offset: 0x000099BE
		public unsafe static ResourcesAPI _overrideAPI_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x0006439C File Offset: 0x0006259C
		public virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance)
		{
			ResourceRequest resourceRequest = ResourcesAPIInternal.LoadAsyncInternal(path, systemTypeInstance);
			resourceRequest.m_Path = path;
			resourceRequest.m_Type = systemTypeInstance;
			return resourceRequest;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0000B7D8 File Offset: 0x000099D8
		public virtual void UnloadAsset(Object assetToUnload)
		{
			ResourcesAPIInternal.UnloadAsset(assetToUnload);
		}

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultAPI;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeFieldInfoPtr__overrideAPI_k__BackingField;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_LoadAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_String_Type_0;
	}
}

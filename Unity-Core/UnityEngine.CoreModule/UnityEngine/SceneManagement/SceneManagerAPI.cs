using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001B4 RID: 436
	public class SceneManagerAPI : Object
	{
		// Token: 0x0600200F RID: 8207 RVA: 0x0008344C File Offset: 0x0008164C
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManagerAPI()
		{
			Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManagerAPI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr);
			SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, "s_DefaultAPI");
			SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, "<overrideAPI>k__BackingField");
			SceneManagerAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100666794);
			SceneManagerAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100666795);
			SceneManagerAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100666796);
			SceneManagerAPI.NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100666797);
			SceneManagerAPI.NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100666798);
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x00083508 File Offset: 0x00081708
		public unsafe static SceneManagerAPI ActiveAPI
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1286102, RefRangeEnd = 1286104, XrefRangeStart = 1286092, XrefRangeEnd = 1286102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr3) : null;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x0008353C File Offset: 0x0008173C
		// (set) Token: 0x0600201A RID: 8218 RVA: 0x0000EDDB File Offset: 0x0000CFDB
		public unsafe static SceneManagerAPI overrideAPI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286104, XrefRangeEnd = 1286108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr3) : null;
			}
			set
			{
				SceneManagerAPI._overrideAPI_k__BackingField = value;
			}
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00083570 File Offset: 0x00081770
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneManagerAPI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000835AC File Offset: 0x000817AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286108, XrefRangeEnd = 1286110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustCompleteNextFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManagerAPI.NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00083634 File Offset: 0x00081834
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperation LoadFirstScene(bool mustLoadAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mustLoadAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManagerAPI.NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x0000EDAE File Offset: 0x0000CFAE
		public SceneManagerAPI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x0008368C File Offset: 0x0008188C
		// (set) Token: 0x06002017 RID: 8215 RVA: 0x0000EDB7 File Offset: 0x0000CFB7
		public unsafe static SceneManagerAPI s_DefaultAPI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x000836B4 File Offset: 0x000818B4
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x0000EDC9 File Offset: 0x0000CFC9
		public unsafe static SceneManagerAPI _overrideAPI_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0000EDE3 File Offset: 0x0000CFE3
		public virtual int GetNumScenesInBuildSettings()
		{
			return SceneManagerAPIInternal.GetNumScenesInBuildSettings();
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0000EDEA File Offset: 0x0000CFEA
		public virtual Scene GetSceneByBuildIndex(int buildIndex)
		{
			return SceneManagerAPIInternal.GetSceneByBuildIndex(buildIndex);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0000EDF2 File Offset: 0x0000CFF2
		public virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			return SceneManagerAPIInternal.UnloadSceneNameIndexInternal(sceneName, sceneBuildIndex, immediately, options, out outSuccess);
		}

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultAPI;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeFieldInfoPtr__overrideAPI_k__BackingField;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0;
	}
}

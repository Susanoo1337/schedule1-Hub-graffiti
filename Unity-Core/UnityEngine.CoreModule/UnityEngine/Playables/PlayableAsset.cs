using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Playables
{
	// Token: 0x02000255 RID: 597
	[Serializable]
	public class PlayableAsset : ScriptableObject
	{
		// Token: 0x06002940 RID: 10560 RVA: 0x000A0C70 File Offset: 0x0009EE70
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableAsset()
		{
			Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr);
			PlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100667696);
			PlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100667697);
			PlayableAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100667698);
			PlayableAsset.NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100667699);
			PlayableAsset.NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100667700);
			PlayableAsset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100667701);
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000A0D18 File Offset: 0x0009EF18
		[CallerCount(0)]
		public unsafe virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x000A0D80 File Offset: 0x0009EF80
		public unsafe virtual double duration
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1292727, RefRangeEnd = 1292728, XrefRangeStart = 1292723, XrefRangeEnd = 1292727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x000A0DC8 File Offset: 0x0009EFC8
		public unsafe virtual IEnumerable<PlayableBinding> outputs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292728, XrefRangeEnd = 1292732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x000A0E14 File Offset: 0x0009F014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292732, XrefRangeEnd = 1292737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr)
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(asset);
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graph;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000A0E78 File Offset: 0x0009F078
		[CallerCount(0)]
		public unsafe static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptrToDouble;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x000A0EBC File Offset: 0x0009F0BC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableAsset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x0001280C File Offset: 0x00010A0C
		public PlayableAsset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

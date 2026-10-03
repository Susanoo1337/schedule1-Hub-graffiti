using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering;

namespace UnityEngine.U2D
{
	// Token: 0x0200017B RID: 379
	public static class SpriteDataAccessExtensions : Object
	{
		// Token: 0x06001D2F RID: 7471 RVA: 0x000788A4 File Offset: 0x00076AA4
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteDataAccessExtensions()
		{
			Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteDataAccessExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100666439);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100666440);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndices_Public_Static_NativeArray_1_UInt16_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100666441);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_HasVertexAttribute_Public_Static_Boolean_Sprite_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100666442);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndicesInfo_Private_Static_SpriteChannelInfo_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100666443);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetChannelInfo_Private_Static_SpriteChannelInfo_Sprite_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100666444);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndicesInfo_Injected_Private_Static_Void_Sprite_byref_SpriteChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100666445);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetChannelInfo_Injected_Private_Static_Void_Sprite_VertexAttribute_byref_SpriteChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100666446);
			SpriteDataAccessExtensions.SetVertexCountDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetVertexCountDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetVertexCount");
			SpriteDataAccessExtensions.GetVertexCountDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetVertexCountDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetVertexCount");
			SpriteDataAccessExtensions.SetBindPoseDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetBindPoseDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBindPoseData");
			SpriteDataAccessExtensions.SetIndicesDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetIndicesDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetIndicesData");
			SpriteDataAccessExtensions.SetChannelDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetChannelDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetChannelData");
			SpriteDataAccessExtensions.GetBoneInfoDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetBoneInfoDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetBoneInfo");
			SpriteDataAccessExtensions.SetBoneDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetBoneDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBoneData");
			SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetPrimaryVertexStreamSize");
			SpriteDataAccessExtensions.GetBindPoseInfo_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetBindPoseInfo_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetBindPoseInfo_Injected");
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x000789FC File Offset: 0x00076BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282259, RefRangeEnd = 1282260, XrefRangeStart = 1282226, XrefRangeEnd = 1282259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckAttributeTypeMatchesAndThrow<T>(UnityEngine.Rendering.VertexAttribute channel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.MethodInfoStoreGeneric_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00078A30 File Offset: 0x00076C30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1282268, RefRangeEnd = 1282272, XrefRangeStart = 1282260, XrefRangeEnd = 1282268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Unity.Collections.NativeSlice<T> GetVertexAttribute<T>(this Sprite sprite, UnityEngine.Rendering.VertexAttribute channel) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.MethodInfoStoreGeneric_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Unity.Collections.NativeSlice<T>(pointer);
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00078A7C File Offset: 0x00076C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282278, RefRangeEnd = 1282279, XrefRangeStart = 1282272, XrefRangeEnd = 1282278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Unity.Collections.NativeArray<ushort> GetIndices(this Sprite sprite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndices_Public_Static_NativeArray_1_UInt16_Sprite_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Unity.Collections.NativeArray<ushort>(pointer);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00078AB8 File Offset: 0x00076CB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1282281, RefRangeEnd = 1282283, XrefRangeStart = 1282279, XrefRangeEnd = 1282281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasVertexAttribute(this Sprite sprite, UnityEngine.Rendering.VertexAttribute channel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_HasVertexAttribute_Public_Static_Boolean_Sprite_VertexAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00078B08 File Offset: 0x00076D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282283, XrefRangeEnd = 1282285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteChannelInfo GetIndicesInfo(Sprite sprite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndicesInfo_Private_Static_SpriteChannelInfo_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00078B4C File Offset: 0x00076D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282287, RefRangeEnd = 1282288, XrefRangeStart = 1282285, XrefRangeEnd = 1282287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteChannelInfo GetChannelInfo(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetChannelInfo_Private_Static_SpriteChannelInfo_Sprite_VertexAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x00078B9C File Offset: 0x00076D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282288, XrefRangeEnd = 1282290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetIndicesInfo_Injected(Sprite sprite, out SpriteChannelInfo ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndicesInfo_Injected_Private_Static_Void_Sprite_byref_SpriteChannelInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x00078BE0 File Offset: 0x00076DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282290, XrefRangeEnd = 1282292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetChannelInfo_Injected(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, out SpriteChannelInfo ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetChannelInfo_Injected_Private_Static_Void_Sprite_VertexAttribute_byref_SpriteChannelInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0000DB95 File Offset: 0x0000BD95
		public SpriteDataAccessExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0000DB9E File Offset: 0x0000BD9E
		public static void SetVertexAttribute<T>(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, Unity.Collections.NativeArray<T> src) where T : struct
		{
			SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<T>(channel);
			SpriteDataAccessExtensions.SetChannelData(sprite, channel, src.GetUnsafeReadOnlyPtr<T>());
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x00078C34 File Offset: 0x00076E34
		public static Unity.Collections.NativeArray<Matrix4x4> GetBindPoses(Sprite sprite)
		{
			SpriteChannelInfo bindPoseInfo = SpriteDataAccessExtensions.GetBindPoseInfo(sprite);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>(bindPoseInfo.buffer, bindPoseInfo.count, Unity.Collections.Allocator.None);
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0000DBB6 File Offset: 0x0000BDB6
		public static void SetBindPoses(Sprite sprite, Unity.Collections.NativeArray<Matrix4x4> src)
		{
			SpriteDataAccessExtensions.SetBindPoseData(sprite, src.GetUnsafeReadOnlyPtr<Matrix4x4>(), src.Length);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0000DBCD File Offset: 0x0000BDCD
		public static void SetIndices(Sprite sprite, Unity.Collections.NativeArray<ushort> src)
		{
			SpriteDataAccessExtensions.SetIndicesData(sprite, src.GetUnsafeReadOnlyPtr<ushort>(), src.Length);
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00078C64 File Offset: 0x00076E64
		public static Il2CppReferenceArray<SpriteBone> GetBones(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetBoneInfo(sprite);
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0000DBE4 File Offset: 0x0000BDE4
		public static void SetBones(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
		{
			SpriteDataAccessExtensions.SetBoneData(sprite, src);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x0000DBEF File Offset: 0x0000BDEF
		public static void SetVertexCount(Sprite sprite, int count)
		{
			SpriteDataAccessExtensions.SetVertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), count);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0000DC02 File Offset: 0x0000BE02
		public static int GetVertexCount(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetVertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00078C7C File Offset: 0x00076E7C
		public static SpriteChannelInfo GetBindPoseInfo(Sprite sprite)
		{
			SpriteChannelInfo result;
			SpriteDataAccessExtensions.GetBindPoseInfo_Injected(sprite, out result);
			return result;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x0000DC14 File Offset: 0x0000BE14
		public unsafe static void SetBindPoseData(Sprite sprite, void* src, int count)
		{
			SpriteDataAccessExtensions.SetBindPoseDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), src, count);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x0000DC28 File Offset: 0x0000BE28
		public unsafe static void SetIndicesData(Sprite sprite, void* src, int count)
		{
			SpriteDataAccessExtensions.SetIndicesDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), src, count);
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0000DC3C File Offset: 0x0000BE3C
		public unsafe static void SetChannelData(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, void* src)
		{
			SpriteDataAccessExtensions.SetChannelDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), channel, src);
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00078C94 File Offset: 0x00076E94
		public static Il2CppReferenceArray<SpriteBone> GetBoneInfo(Sprite sprite)
		{
			IntPtr intPtr = SpriteDataAccessExtensions.GetBoneInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteBone>>(intPtr2) : null;
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0000DC50 File Offset: 0x0000BE50
		public static void SetBoneData(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
		{
			SpriteDataAccessExtensions.SetBoneDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), IL2CPP.Il2CppObjectBaseToPtr(src));
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0000DC68 File Offset: 0x0000BE68
		public static int GetPrimaryVertexStreamSize(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0000DC7A File Offset: 0x0000BE7A
		public static void GetBindPoseInfo_Injected(Sprite sprite, out SpriteChannelInfo ret)
		{
			SpriteDataAccessExtensions.GetBindPoseInfo_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), out ret);
		}

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeMethodInfoPtr_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Static_NativeArray_1_UInt16_Sprite_0;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeMethodInfoPtr_HasVertexAttribute_Public_Static_Boolean_Sprite_VertexAttribute_0;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesInfo_Private_Static_SpriteChannelInfo_Sprite_0;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeMethodInfoPtr_GetChannelInfo_Private_Static_SpriteChannelInfo_Sprite_VertexAttribute_0;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesInfo_Injected_Private_Static_Void_Sprite_byref_SpriteChannelInfo_0;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeMethodInfoPtr_GetChannelInfo_Injected_Private_Static_Void_Sprite_VertexAttribute_byref_SpriteChannelInfo_0;

		// Token: 0x04001803 RID: 6147
		private static readonly SpriteDataAccessExtensions.SetVertexCountDelegate SetVertexCountDelegateField;

		// Token: 0x04001804 RID: 6148
		private static readonly SpriteDataAccessExtensions.GetVertexCountDelegate GetVertexCountDelegateField;

		// Token: 0x04001805 RID: 6149
		private static readonly SpriteDataAccessExtensions.SetBindPoseDataDelegate SetBindPoseDataDelegateField;

		// Token: 0x04001806 RID: 6150
		private static readonly SpriteDataAccessExtensions.SetIndicesDataDelegate SetIndicesDataDelegateField;

		// Token: 0x04001807 RID: 6151
		private static readonly SpriteDataAccessExtensions.SetChannelDataDelegate SetChannelDataDelegateField;

		// Token: 0x04001808 RID: 6152
		private static readonly SpriteDataAccessExtensions.GetBoneInfoDelegate GetBoneInfoDelegateField;

		// Token: 0x04001809 RID: 6153
		private static readonly SpriteDataAccessExtensions.SetBoneDataDelegate SetBoneDataDelegateField;

		// Token: 0x0400180A RID: 6154
		private static readonly SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegate GetPrimaryVertexStreamSizeDelegateField;

		// Token: 0x0400180B RID: 6155
		private static readonly SpriteDataAccessExtensions.GetBindPoseInfo_InjectedDelegate GetBindPoseInfo_InjectedDelegateField;

		// Token: 0x020009BE RID: 2494
		private sealed class MethodInfoStoreGeneric_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0<T>
		{
			// Token: 0x04002B69 RID: 11113
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SpriteDataAccessExtensions.NativeMethodInfoPtr_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0, Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020009BF RID: 2495
		private sealed class MethodInfoStoreGeneric_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0<T>
		{
			// Token: 0x04002B6A RID: 11114
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0, Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020009C0 RID: 2496
		// (Invoke) Token: 0x06003BFF RID: 15359
		private delegate void SetVertexCountDelegate(IntPtr sprite, int count);

		// Token: 0x020009C1 RID: 2497
		// (Invoke) Token: 0x06003C01 RID: 15361
		private delegate int GetVertexCountDelegate(IntPtr sprite);

		// Token: 0x020009C2 RID: 2498
		// (Invoke) Token: 0x06003C03 RID: 15363
		private delegate void SetBindPoseDataDelegate(IntPtr sprite, IntPtr src, int count);

		// Token: 0x020009C3 RID: 2499
		// (Invoke) Token: 0x06003C05 RID: 15365
		private delegate void SetIndicesDataDelegate(IntPtr sprite, IntPtr src, int count);

		// Token: 0x020009C4 RID: 2500
		// (Invoke) Token: 0x06003C07 RID: 15367
		private delegate void SetChannelDataDelegate(IntPtr sprite, UnityEngine.Rendering.VertexAttribute channel, IntPtr src);

		// Token: 0x020009C5 RID: 2501
		// (Invoke) Token: 0x06003C09 RID: 15369
		private delegate IntPtr GetBoneInfoDelegate(IntPtr sprite);

		// Token: 0x020009C6 RID: 2502
		// (Invoke) Token: 0x06003C0B RID: 15371
		private delegate void SetBoneDataDelegate(IntPtr sprite, IntPtr src);

		// Token: 0x020009C7 RID: 2503
		// (Invoke) Token: 0x06003C0D RID: 15373
		private delegate int GetPrimaryVertexStreamSizeDelegate(IntPtr sprite);

		// Token: 0x020009C8 RID: 2504
		// (Invoke) Token: 0x06003C0F RID: 15375
		private delegate void GetBindPoseInfo_InjectedDelegate(IntPtr sprite, [Out] IntPtr ret);
	}
}

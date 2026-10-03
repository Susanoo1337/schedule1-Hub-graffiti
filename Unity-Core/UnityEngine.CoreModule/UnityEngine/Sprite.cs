using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000174 RID: 372
	public sealed class Sprite : Object
	{
		// Token: 0x06001CB8 RID: 7352 RVA: 0x00076F3C File Offset: 0x0007513C
		// Note: this type is marked as 'beforefieldinit'.
		static Sprite()
		{
			Il2CppClassPointerStore<Sprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Sprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprite>.NativeClassPtr);
			Sprite.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666393);
			Sprite.NativeMethodInfoPtr_GetPackingRotation_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666394);
			Sprite.NativeMethodInfoPtr_GetPacked_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666395);
			Sprite.NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666396);
			Sprite.NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666397);
			Sprite.NativeMethodInfoPtr_GetPadding_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666398);
			Sprite.NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666399);
			Sprite.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666400);
			Sprite.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666401);
			Sprite.NativeMethodInfoPtr_get_border_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666402);
			Sprite.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666403);
			Sprite.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666404);
			Sprite.NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666405);
			Sprite.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666406);
			Sprite.NativeMethodInfoPtr_get_packed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666407);
			Sprite.NativeMethodInfoPtr_get_packingRotation_Public_get_SpritePackingRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666408);
			Sprite.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666409);
			Sprite.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666410);
			Sprite.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666411);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666412);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666413);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666414);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666415);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666416);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666417);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666418);
			Sprite.NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666419);
			Sprite.NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666420);
			Sprite.NativeMethodInfoPtr_GetPadding_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666421);
			Sprite.NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_Sprite_Texture2D_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666422);
			Sprite.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666423);
			Sprite.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666424);
			Sprite.NativeMethodInfoPtr_get_border_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666425);
			Sprite.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666426);
			Sprite.GetPackingModeDelegateField = IL2CPP.ResolveICall<Sprite.GetPackingModeDelegate>("UnityEngine.Sprite::GetPackingMode");
			Sprite.GetSecondaryTextureDelegateField = IL2CPP.ResolveICall<Sprite.GetSecondaryTextureDelegate>("UnityEngine.Sprite::GetSecondaryTexture");
			Sprite.GetSecondaryTextureCountDelegateField = IL2CPP.ResolveICall<Sprite.GetSecondaryTextureCountDelegate>("UnityEngine.Sprite::GetSecondaryTextureCount");
			Sprite.GetSecondaryTexturesDelegateField = IL2CPP.ResolveICall<Sprite.GetSecondaryTexturesDelegate>("UnityEngine.Sprite::GetSecondaryTextures");
			Sprite.get_spriteAtlasTextureScaleDelegateField = IL2CPP.ResolveICall<Sprite.get_spriteAtlasTextureScaleDelegate>("UnityEngine.Sprite::get_spriteAtlasTextureScale");
			Sprite.GetPhysicsShapeCountDelegateField = IL2CPP.ResolveICall<Sprite.GetPhysicsShapeCountDelegate>("UnityEngine.Sprite::GetPhysicsShapeCount");
			Sprite.Internal_GetPhysicsShapePointCountDelegateField = IL2CPP.ResolveICall<Sprite.Internal_GetPhysicsShapePointCountDelegate>("UnityEngine.Sprite::Internal_GetPhysicsShapePointCount");
			Sprite.GetPhysicsShapeImplDelegateField = IL2CPP.ResolveICall<Sprite.GetPhysicsShapeImplDelegate>("UnityEngine.Sprite::GetPhysicsShapeImpl");
			Sprite.OverridePhysicsShapeCountDelegateField = IL2CPP.ResolveICall<Sprite.OverridePhysicsShapeCountDelegate>("UnityEngine.Sprite::OverridePhysicsShapeCount");
			Sprite.OverridePhysicsShapeDelegateField = IL2CPP.ResolveICall<Sprite.OverridePhysicsShapeDelegate>("UnityEngine.Sprite::OverridePhysicsShape");
			Sprite.OverrideGeometryDelegateField = IL2CPP.ResolveICall<Sprite.OverrideGeometryDelegate>("UnityEngine.Sprite::OverrideGeometry");
			Sprite.GetTextureRect_InjectedDelegateField = IL2CPP.ResolveICall<Sprite.GetTextureRect_InjectedDelegate>("UnityEngine.Sprite::GetTextureRect_Injected");
			Sprite.GetTextureRectOffset_InjectedDelegateField = IL2CPP.ResolveICall<Sprite.GetTextureRectOffset_InjectedDelegate>("UnityEngine.Sprite::GetTextureRectOffset_Injected");
			Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegateField = IL2CPP.ResolveICall<Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegate>("UnityEngine.Sprite::CreateSpriteWithoutTextureScripting_Injected");
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000772E8 File Offset: 0x000754E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281943, XrefRangeEnd = 1281947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00077324 File Offset: 0x00075524
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1281949, RefRangeEnd = 1281951, XrefRangeStart = 1281947, XrefRangeEnd = 1281949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPackingRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPackingRotation_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00077360 File Offset: 0x00075560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281951, XrefRangeEnd = 1281953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPacked_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0007739C File Offset: 0x0007559C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281953, XrefRangeEnd = 1281955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetInnerUVs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x000773D8 File Offset: 0x000755D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281955, XrefRangeEnd = 1281957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetOuterUVs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00077414 File Offset: 0x00075614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281957, XrefRangeEnd = 1281959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetPadding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPadding_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00077450 File Offset: 0x00075650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281959, XrefRangeEnd = 1281961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref border;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateFallbackPhysicsShape;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondaryTexture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x0007750C File Offset: 0x0007570C
		public unsafe Bounds bounds
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1281963, RefRangeEnd = 1281978, XrefRangeStart = 1281961, XrefRangeEnd = 1281963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00077548 File Offset: 0x00075748
		public unsafe Rect rect
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 1281980, RefRangeEnd = 1282000, XrefRangeStart = 1281978, XrefRangeEnd = 1281980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x00077584 File Offset: 0x00075784
		public unsafe Vector4 border
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1282002, RefRangeEnd = 1282006, XrefRangeStart = 1282000, XrefRangeEnd = 1282002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_border_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x000775C0 File Offset: 0x000757C0
		public unsafe Texture2D texture
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 1282008, RefRangeEnd = 1282044, XrefRangeStart = 1282006, XrefRangeEnd = 1282008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00077600 File Offset: 0x00075800
		public unsafe float pixelsPerUnit
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1282046, RefRangeEnd = 1282051, XrefRangeStart = 1282044, XrefRangeEnd = 1282046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x0007763C File Offset: 0x0007583C
		public unsafe Texture2D associatedAlphaSplitTexture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1282053, RefRangeEnd = 1282055, XrefRangeStart = 1282051, XrefRangeEnd = 1282053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0007767C File Offset: 0x0007587C
		public unsafe Vector2 pivot
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1282057, RefRangeEnd = 1282059, XrefRangeStart = 1282055, XrefRangeEnd = 1282057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x000776B8 File Offset: 0x000758B8
		public unsafe bool packed
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1282061, RefRangeEnd = 1282064, XrefRangeStart = 1282059, XrefRangeEnd = 1282061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_packed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x000776F4 File Offset: 0x000758F4
		public unsafe SpritePackingRotation packingRotation
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1281949, RefRangeEnd = 1281951, XrefRangeStart = 1281949, XrefRangeEnd = 1281951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_packingRotation_Public_get_SpritePackingRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00077730 File Offset: 0x00075930
		public unsafe Il2CppStructArray<Vector2> vertices
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1282066, RefRangeEnd = 1282072, XrefRangeStart = 1282064, XrefRangeEnd = 1282066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00077770 File Offset: 0x00075970
		public unsafe Il2CppStructArray<ushort> triangles
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1282074, RefRangeEnd = 1282079, XrefRangeStart = 1282072, XrefRangeEnd = 1282074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr3) : null;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x000777B0 File Offset: 0x000759B0
		public unsafe Il2CppStructArray<Vector2> uv
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1282081, RefRangeEnd = 1282088, XrefRangeStart = 1282079, XrefRangeEnd = 1282081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x000777F0 File Offset: 0x000759F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282088, XrefRangeEnd = 1282089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref border;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateFallbackPhysicsShape;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00077898 File Offset: 0x00075A98
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1282113, RefRangeEnd = 1282119, XrefRangeStart = 1282089, XrefRangeEnd = 1282113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, Il2CppReferenceArray<SecondarySpriteTexture> secondaryTextures)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref border;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateFallbackPhysicsShape;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondaryTextures);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x00077954 File Offset: 0x00075B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282119, XrefRangeEnd = 1282120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref border;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000779EC File Offset: 0x00075BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282123, RefRangeEnd = 1282124, XrefRangeStart = 1282120, XrefRangeEnd = 1282123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00077A78 File Offset: 0x00075C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282124, XrefRangeEnd = 1282127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00077AF4 File Offset: 0x00075CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282127, XrefRangeEnd = 1282130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00077B64 File Offset: 0x00075D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282133, RefRangeEnd = 1282134, XrefRangeStart = 1282130, XrefRangeEnd = 1282133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00077BC4 File Offset: 0x00075DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282134, XrefRangeEnd = 1282136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetInnerUVs_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00077C04 File Offset: 0x00075E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282136, XrefRangeEnd = 1282138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOuterUVs_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00077C44 File Offset: 0x00075E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282138, XrefRangeEnd = 1282140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPadding_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPadding_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00077C84 File Offset: 0x00075E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282140, XrefRangeEnd = 1282142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape, Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &border;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateFallbackPhysicsShape;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondaryTexture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_Sprite_Texture2D_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00077D40 File Offset: 0x00075F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282142, XrefRangeEnd = 1282144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00077D80 File Offset: 0x00075F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282144, XrefRangeEnd = 1282146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00077DC0 File Offset: 0x00075FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282146, XrefRangeEnd = 1282148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_border_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_border_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00077E00 File Offset: 0x00076000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282148, XrefRangeEnd = 1282150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pivot_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0000D8B5 File Offset: 0x0000BAB5
		public Sprite(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0000D8BE File Offset: 0x0000BABE
		public int GetPackingMode()
		{
			return Sprite.GetPackingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00077E40 File Offset: 0x00076040
		public Rect GetTextureRect()
		{
			Rect result;
			this.GetTextureRect_Injected(out result);
			return result;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00077E58 File Offset: 0x00076058
		public Vector2 GetTextureRectOffset()
		{
			Vector2 result;
			this.GetTextureRectOffset_Injected(out result);
			return result;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0000D8D0 File Offset: 0x0000BAD0
		public static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture)
		{
			return Sprite.CreateSpriteWithoutTextureScripting_Injected(ref rect, ref pivot, pixelsToUnits, texture);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00077E70 File Offset: 0x00076070
		public Texture2D GetSecondaryTexture(int index)
		{
			IntPtr intPtr = Sprite.GetSecondaryTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x0000D8DD File Offset: 0x0000BADD
		public int GetSecondaryTextureCount()
		{
			return Sprite.GetSecondaryTextureCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0000D8EF File Offset: 0x0000BAEF
		public int GetSecondaryTextures(Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
		{
			return Sprite.GetSecondaryTexturesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(secondaryTexture));
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0000D907 File Offset: 0x0000BB07
		public float spriteAtlasTextureScale
		{
			get
			{
				return Sprite.get_spriteAtlasTextureScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00077EA0 File Offset: 0x000760A0
		public SpritePackingMode packingMode
		{
			get
			{
				return (SpritePackingMode)this.GetPackingMode();
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x00077EB8 File Offset: 0x000760B8
		public Rect textureRect
		{
			get
			{
				return this.GetTextureRect();
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00077ED0 File Offset: 0x000760D0
		public Vector2 textureRectOffset
		{
			get
			{
				return this.GetTextureRectOffset();
			}
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0000D919 File Offset: 0x0000BB19
		public int GetPhysicsShapeCount()
		{
			return Sprite.GetPhysicsShapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00077EE8 File Offset: 0x000760E8
		public int GetPhysicsShapePointCount(int shapeIdx)
		{
			int physicsShapeCount = this.GetPhysicsShapeCount();
			bool flag = shapeIdx < 0 || shapeIdx >= physicsShapeCount;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("Index({0}) is out of bounds(0 - {1})", shapeIdx, physicsShapeCount - 1));
			}
			return this.Internal_GetPhysicsShapePointCount(shapeIdx);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0000D92B File Offset: 0x0000BB2B
		public int Internal_GetPhysicsShapePointCount(int shapeIdx)
		{
			return Sprite.Internal_GetPhysicsShapePointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIdx);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00077F38 File Offset: 0x00076138
		public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape)
		{
			int physicsShapeCount = this.GetPhysicsShapeCount();
			bool flag = shapeIdx < 0 || shapeIdx >= physicsShapeCount;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("Index({0}) is out of bounds(0 - {1})", shapeIdx, physicsShapeCount - 1));
			}
			Sprite.GetPhysicsShapeImpl(this, shapeIdx, physicsShape);
			return physicsShape.Count;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0000D93E File Offset: 0x0000BB3E
		public static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape)
		{
			Sprite.GetPhysicsShapeImplDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), shapeIdx, IL2CPP.Il2CppObjectBaseToPtr(physicsShape));
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00077F90 File Offset: 0x00076190
		public void OverridePhysicsShape(IList<Il2CppStructArray<Vector2>> physicsShapes)
		{
			bool flag = physicsShapes == null;
			if (flag)
			{
				throw new ArgumentNullException("physicsShapes");
			}
			for (int i = 0; i < physicsShapes.Count; i++)
			{
				Il2CppStructArray<Vector2> il2CppStructArray = physicsShapes[i];
				bool flag2 = il2CppStructArray == null;
				if (flag2)
				{
					throw new ArgumentNullException("physicsShape", String.Format("Physics Shape at {0} is null.", i));
				}
				bool flag3 = il2CppStructArray.Length < 3;
				if (flag3)
				{
					throw new ArgumentException(String.Format("Physics Shape at {0} has less than 3 vertices ({1}).", i, il2CppStructArray.Length));
				}
			}
			Sprite.OverridePhysicsShapeCount(this, physicsShapes.Count);
			for (int j = 0; j < physicsShapes.Count; j++)
			{
				Sprite.OverridePhysicsShape(this, physicsShapes[j], j);
			}
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0000D957 File Offset: 0x0000BB57
		public static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount)
		{
			Sprite.OverridePhysicsShapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), physicsShapeCount);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0000D96A File Offset: 0x0000BB6A
		public static void OverridePhysicsShape(Sprite sprite, Il2CppStructArray<Vector2> physicsShape, int idx)
		{
			Sprite.OverridePhysicsShapeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), IL2CPP.Il2CppObjectBaseToPtr(physicsShape), idx);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0000D983 File Offset: 0x0000BB83
		public void OverrideGeometry(Il2CppStructArray<Vector2> vertices, Il2CppStructArray<ushort> triangles)
		{
			Sprite.OverrideGeometryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(vertices), IL2CPP.Il2CppObjectBaseToPtr(triangles));
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00078064 File Offset: 0x00076264
		public static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture)
		{
			return Sprite.CreateSpriteWithoutTextureScripting(rect, pivot, pixelsToUnits, texture);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00078080 File Offset: 0x00076280
		public static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits)
		{
			return Sprite.CreateSpriteWithoutTextureScripting(rect, pivot, pixelsToUnits, null);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x0000D9A1 File Offset: 0x0000BBA1
		public void GetTextureRect_Injected(out Rect ret)
		{
			Sprite.GetTextureRect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		public void GetTextureRectOffset_Injected(out Vector2 ret)
		{
			Sprite.GetTextureRectOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0007809C File Offset: 0x0007629C
		public static Sprite CreateSpriteWithoutTextureScripting_Injected(ref Rect rect, ref Vector2 pivot, float pixelsToUnits, Texture2D texture)
		{
			IntPtr intPtr = Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegateField(ref rect, ref pivot, pixelsToUnits, IL2CPP.Il2CppObjectBaseToPtr(texture));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_GetPackingRotation_Internal_Int32_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_GetPacked_Internal_Int32_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Internal_Vector4_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeMethodInfoPtr_get_border_Public_get_Vector4_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeMethodInfoPtr_get_packed_Public_get_Boolean_0;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeMethodInfoPtr_get_packingRotation_Public_get_SpritePackingRotation_0;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_Sprite_Texture2D_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_get_border_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly Sprite.GetPackingModeDelegate GetPackingModeDelegateField;

		// Token: 0x040017D2 RID: 6098
		private static readonly Sprite.GetSecondaryTextureDelegate GetSecondaryTextureDelegateField;

		// Token: 0x040017D3 RID: 6099
		private static readonly Sprite.GetSecondaryTextureCountDelegate GetSecondaryTextureCountDelegateField;

		// Token: 0x040017D4 RID: 6100
		private static readonly Sprite.GetSecondaryTexturesDelegate GetSecondaryTexturesDelegateField;

		// Token: 0x040017D5 RID: 6101
		private static readonly Sprite.get_spriteAtlasTextureScaleDelegate get_spriteAtlasTextureScaleDelegateField;

		// Token: 0x040017D6 RID: 6102
		private static readonly Sprite.GetPhysicsShapeCountDelegate GetPhysicsShapeCountDelegateField;

		// Token: 0x040017D7 RID: 6103
		private static readonly Sprite.Internal_GetPhysicsShapePointCountDelegate Internal_GetPhysicsShapePointCountDelegateField;

		// Token: 0x040017D8 RID: 6104
		private static readonly Sprite.GetPhysicsShapeImplDelegate GetPhysicsShapeImplDelegateField;

		// Token: 0x040017D9 RID: 6105
		private static readonly Sprite.OverridePhysicsShapeCountDelegate OverridePhysicsShapeCountDelegateField;

		// Token: 0x040017DA RID: 6106
		private static readonly Sprite.OverridePhysicsShapeDelegate OverridePhysicsShapeDelegateField;

		// Token: 0x040017DB RID: 6107
		private static readonly Sprite.OverrideGeometryDelegate OverrideGeometryDelegateField;

		// Token: 0x040017DC RID: 6108
		private static readonly Sprite.GetTextureRect_InjectedDelegate GetTextureRect_InjectedDelegateField;

		// Token: 0x040017DD RID: 6109
		private static readonly Sprite.GetTextureRectOffset_InjectedDelegate GetTextureRectOffset_InjectedDelegateField;

		// Token: 0x040017DE RID: 6110
		private static readonly Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegate CreateSpriteWithoutTextureScripting_InjectedDelegateField;

		// Token: 0x020009AF RID: 2479
		// (Invoke) Token: 0x06003BDF RID: 15327
		private delegate int GetPackingModeDelegate(IntPtr @this);

		// Token: 0x020009B0 RID: 2480
		// (Invoke) Token: 0x06003BE1 RID: 15329
		private delegate IntPtr GetSecondaryTextureDelegate(IntPtr @this, int index);

		// Token: 0x020009B1 RID: 2481
		// (Invoke) Token: 0x06003BE3 RID: 15331
		private delegate int GetSecondaryTextureCountDelegate(IntPtr @this);

		// Token: 0x020009B2 RID: 2482
		// (Invoke) Token: 0x06003BE5 RID: 15333
		private delegate int GetSecondaryTexturesDelegate(IntPtr @this, IntPtr secondaryTexture);

		// Token: 0x020009B3 RID: 2483
		// (Invoke) Token: 0x06003BE7 RID: 15335
		private delegate float get_spriteAtlasTextureScaleDelegate(IntPtr @this);

		// Token: 0x020009B4 RID: 2484
		// (Invoke) Token: 0x06003BE9 RID: 15337
		private delegate int GetPhysicsShapeCountDelegate(IntPtr @this);

		// Token: 0x020009B5 RID: 2485
		// (Invoke) Token: 0x06003BEB RID: 15339
		private delegate int Internal_GetPhysicsShapePointCountDelegate(IntPtr @this, int shapeIdx);

		// Token: 0x020009B6 RID: 2486
		// (Invoke) Token: 0x06003BED RID: 15341
		private delegate void GetPhysicsShapeImplDelegate(IntPtr sprite, int shapeIdx, IntPtr physicsShape);

		// Token: 0x020009B7 RID: 2487
		// (Invoke) Token: 0x06003BEF RID: 15343
		private delegate void OverridePhysicsShapeCountDelegate(IntPtr sprite, int physicsShapeCount);

		// Token: 0x020009B8 RID: 2488
		// (Invoke) Token: 0x06003BF1 RID: 15345
		private delegate void OverridePhysicsShapeDelegate(IntPtr sprite, IntPtr physicsShape, int idx);

		// Token: 0x020009B9 RID: 2489
		// (Invoke) Token: 0x06003BF3 RID: 15347
		private delegate void OverrideGeometryDelegate(IntPtr @this, IntPtr vertices, IntPtr triangles);

		// Token: 0x020009BA RID: 2490
		// (Invoke) Token: 0x06003BF5 RID: 15349
		private delegate void GetTextureRect_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020009BB RID: 2491
		// (Invoke) Token: 0x06003BF7 RID: 15351
		private delegate void GetTextureRectOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020009BC RID: 2492
		// (Invoke) Token: 0x06003BF9 RID: 15353
		private delegate IntPtr CreateSpriteWithoutTextureScripting_InjectedDelegate(IntPtr rect, IntPtr pivot, float pixelsToUnits, IntPtr texture);
	}
}

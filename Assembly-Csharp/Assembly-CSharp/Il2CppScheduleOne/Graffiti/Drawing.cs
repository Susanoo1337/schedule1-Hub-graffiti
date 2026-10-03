using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x02000365 RID: 869
	public class Drawing : Il2CppSystem.Object
	{
		// Token: 0x06004964 RID: 18788 RVA: 0x00174DB4 File Offset: 0x00172FB4
		// Note: this type is marked as 'beforefieldinit'.
		static Drawing()
		{
			Il2CppClassPointerStore<Drawing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "Drawing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Drawing>.NativeClassPtr);
			Drawing.NativeFieldInfoPtr___width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "<_width>k__BackingField");
			Drawing.NativeFieldInfoPtr___height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "<_height>k__BackingField");
			Drawing.NativeFieldInfoPtr__OutputTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "<OutputTexture>k__BackingField");
			Drawing.NativeFieldInfoPtr__PaintedPixelCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "<PaintedPixelCount>k__BackingField");
			Drawing.NativeFieldInfoPtr__HistoryIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "<HistoryIndex>k__BackingField");
			Drawing.NativeFieldInfoPtr__HistoryCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "<HistoryCount>k__BackingField");
			Drawing.NativeFieldInfoPtr_strokes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "strokes");
			Drawing.NativeFieldInfoPtr__historyTextureArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "_historyTextureArray");
			Drawing.NativeFieldInfoPtr_PaintedPixelHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "PaintedPixelHistory");
			Drawing.NativeFieldInfoPtr__strokeHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "_strokeHistory");
			Drawing.NativeFieldInfoPtr_MAX_UNDO_STATES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "MAX_UNDO_STATES");
			Drawing.NativeFieldInfoPtr_onTextureChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "onTextureChanged");
			Drawing.NativeMethodInfoPtr_get__width_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672699);
			Drawing.NativeMethodInfoPtr_set__width_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672700);
			Drawing.NativeMethodInfoPtr_get__height_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672701);
			Drawing.NativeMethodInfoPtr_set__height_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672702);
			Drawing.NativeMethodInfoPtr_get_TextureWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672703);
			Drawing.NativeMethodInfoPtr_get_TextureHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672704);
			Drawing.NativeMethodInfoPtr_get_OutputTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672705);
			Drawing.NativeMethodInfoPtr_set_OutputTexture_Private_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672706);
			Drawing.NativeMethodInfoPtr_get_StrokeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672707);
			Drawing.NativeMethodInfoPtr_get_PaintedPixelCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672708);
			Drawing.NativeMethodInfoPtr_set_PaintedPixelCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672709);
			Drawing.NativeMethodInfoPtr_get_HistoryIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672710);
			Drawing.NativeMethodInfoPtr_set_HistoryIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672711);
			Drawing.NativeMethodInfoPtr_get_HistoryCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672712);
			Drawing.NativeMethodInfoPtr_set_HistoryCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672713);
			Drawing.NativeMethodInfoPtr_GetStrokes_Public_List_1_SprayStroke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672714);
			Drawing.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672715);
			Drawing.NativeMethodInfoPtr_GetCopy_Public_Drawing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672716);
			Drawing.NativeMethodInfoPtr_DrawPaintedPixel_Public_Void_PixelData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672717);
			Drawing.NativeMethodInfoPtr_LerpUnclampedFast_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672718);
			Drawing.NativeMethodInfoPtr_ApplyTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672719);
			Drawing.NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672720);
			Drawing.NativeMethodInfoPtr_AddStroke_Public_Void_SprayStroke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672721);
			Drawing.NativeMethodInfoPtr_AddStrokes_Public_Void_List_1_SprayStroke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672722);
			Drawing.NativeMethodInfoPtr_CanUndo_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672723);
			Drawing.NativeMethodInfoPtr_Undo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672724);
			Drawing.NativeMethodInfoPtr_CacheDrawing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672725);
			Drawing.NativeMethodInfoPtr_RestoreFromCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672726);
			Drawing.NativeMethodInfoPtr_AddTextureToHistory_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing>.NativeClassPtr, 100672727);
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x00175118 File Offset: 0x00173318
		// (set) Token: 0x06004966 RID: 18790 RVA: 0x00175154 File Offset: 0x00173354
		public unsafe int _width
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29049, RefRangeEnd = 29051, XrefRangeStart = 29049, XrefRangeEnd = 29051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_get__width_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29056, XrefRangeStart = 29051, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_set__width_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06004967 RID: 18791 RVA: 0x00175194 File Offset: 0x00173394
		// (set) Token: 0x06004968 RID: 18792 RVA: 0x001751D0 File Offset: 0x001733D0
		public unsafe int _height
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_get__height_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 168968, RefRangeEnd = 168976, XrefRangeStart = 168968, XrefRangeEnd = 168968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_set__height_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06004969 RID: 18793 RVA: 0x00175210 File Offset: 0x00173410
		public unsafe int TextureWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168976, XrefRangeEnd = 168977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_get_TextureWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x0600496A RID: 18794 RVA: 0x0017524C File Offset: 0x0017344C
		public unsafe int TextureHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168977, XrefRangeEnd = 168978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_get_TextureHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x0600496B RID: 18795 RVA: 0x00175288 File Offset: 0x00173488
		// (set) Token: 0x0600496C RID: 18796 RVA: 0x001752C8 File Offset: 0x001734C8
		public unsafe Texture2D OutputTexture
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_get_OutputTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_set_OutputTexture_Private_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x0017530C File Offset: 0x0017350C
		public unsafe int StrokeCount
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 168979, RefRangeEnd = 168995, XrefRangeStart = 168978, XrefRangeEnd = 168979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_get_StrokeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x0600496E RID: 18798 RVA: 0x00175348 File Offset: 0x00173548
		// (set) Token: 0x0600496F RID: 18799 RVA: 0x00175384 File Offset: 0x00173584
		public unsafe int PaintedPixelCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_get_PaintedPixelCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_set_PaintedPixelCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06004970 RID: 18800 RVA: 0x001753C4 File Offset: 0x001735C4
		// (set) Token: 0x06004971 RID: 18801 RVA: 0x00175400 File Offset: 0x00173600
		public unsafe int HistoryIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_get_HistoryIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_set_HistoryIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06004972 RID: 18802 RVA: 0x00175440 File Offset: 0x00173640
		// (set) Token: 0x06004973 RID: 18803 RVA: 0x0017547C File Offset: 0x0017367C
		public unsafe int HistoryCount
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_get_HistoryCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29101, RefRangeEnd = 29102, XrefRangeStart = 29101, XrefRangeEnd = 29102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_set_HistoryCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x001754BC File Offset: 0x001736BC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SprayStroke> GetStrokes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_GetStrokes_Public_List_1_SprayStroke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SprayStroke>>(intPtr3) : null;
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x001754FC File Offset: 0x001736FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169032, RefRangeEnd = 169034, XrefRangeStart = 168995, XrefRangeEnd = 169032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Drawing(int width, int height, bool initPixels) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Drawing>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initPixels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00175560 File Offset: 0x00173760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169034, XrefRangeEnd = 169060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Drawing GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_GetCopy_Public_Drawing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Drawing>(intPtr3) : null;
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x001755A0 File Offset: 0x001737A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 169080, RefRangeEnd = 169085, XrefRangeStart = 169060, XrefRangeEnd = 169080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawPaintedPixel(PixelData data, bool applyTexture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_DrawPaintedPixel_Public_Void_PixelData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x001755F0 File Offset: 0x001737F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 169085, RefRangeEnd = 169091, XrefRangeStart = 169085, XrefRangeEnd = 169085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color LerpUnclampedFast(Color a, Color b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_LerpUnclampedFast_Public_Static_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x0017564C File Offset: 0x0017384C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169092, RefRangeEnd = 169093, XrefRangeStart = 169091, XrefRangeEnd = 169092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_ApplyTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00175680 File Offset: 0x00173880
		[CallerCount(0)]
		public unsafe bool IsCoordinateInBounds(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x001756D8 File Offset: 0x001738D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169093, XrefRangeEnd = 169106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStroke(SprayStroke stroke)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stroke);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_AddStroke_Public_Void_SprayStroke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x0017571C File Offset: 0x0017391C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169131, RefRangeEnd = 169134, XrefRangeStart = 169106, XrefRangeEnd = 169131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStrokes(List<SprayStroke> newStrokes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStrokes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_AddStrokes_Public_Void_List_1_SprayStroke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x00175760 File Offset: 0x00173960
		[CallerCount(0)]
		public unsafe bool CanUndo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_CanUndo_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x0017579C File Offset: 0x0017399C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169141, RefRangeEnd = 169142, XrefRangeStart = 169134, XrefRangeEnd = 169141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_Undo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x001757D0 File Offset: 0x001739D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 169147, RefRangeEnd = 169151, XrefRangeStart = 169142, XrefRangeEnd = 169147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheDrawing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_CacheDrawing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x00175804 File Offset: 0x00173A04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169156, RefRangeEnd = 169158, XrefRangeStart = 169151, XrefRangeEnd = 169156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreFromCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_RestoreFromCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x00175838 File Offset: 0x00173A38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169163, RefRangeEnd = 169164, XrefRangeStart = 169158, XrefRangeEnd = 169163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTextureToHistory(bool saveToCache = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref saveToCache;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.NativeMethodInfoPtr_AddTextureToHistory_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x00023A04 File Offset: 0x00021C04
		public Drawing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06004983 RID: 18819 RVA: 0x00175878 File Offset: 0x00173A78
		// (set) Token: 0x06004984 RID: 18820 RVA: 0x00023A0D File Offset: 0x00021C0D
		public unsafe int __width_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr___width_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr___width_k__BackingField)) = value;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06004985 RID: 18821 RVA: 0x001758A0 File Offset: 0x00173AA0
		// (set) Token: 0x06004986 RID: 18822 RVA: 0x00023A28 File Offset: 0x00021C28
		public unsafe int __height_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr___height_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr___height_k__BackingField)) = value;
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06004987 RID: 18823 RVA: 0x001758C8 File Offset: 0x00173AC8
		// (set) Token: 0x06004988 RID: 18824 RVA: 0x00023A43 File Offset: 0x00021C43
		public unsafe Texture2D _OutputTexture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__OutputTexture_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__OutputTexture_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x001758F8 File Offset: 0x00173AF8
		// (set) Token: 0x0600498A RID: 18826 RVA: 0x00023A62 File Offset: 0x00021C62
		public unsafe int _PaintedPixelCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__PaintedPixelCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__PaintedPixelCount_k__BackingField)) = value;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x0600498B RID: 18827 RVA: 0x00175920 File Offset: 0x00173B20
		// (set) Token: 0x0600498C RID: 18828 RVA: 0x00023A7D File Offset: 0x00021C7D
		public unsafe int _HistoryIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__HistoryIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__HistoryIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x00175948 File Offset: 0x00173B48
		// (set) Token: 0x0600498E RID: 18830 RVA: 0x00023A98 File Offset: 0x00021C98
		public unsafe int _HistoryCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__HistoryCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__HistoryCount_k__BackingField)) = value;
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x00175970 File Offset: 0x00173B70
		// (set) Token: 0x06004990 RID: 18832 RVA: 0x00023AB3 File Offset: 0x00021CB3
		public unsafe List<SprayStroke> strokes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr_strokes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SprayStroke>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr_strokes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06004991 RID: 18833 RVA: 0x001759A0 File Offset: 0x00173BA0
		// (set) Token: 0x06004992 RID: 18834 RVA: 0x00023AD2 File Offset: 0x00021CD2
		public unsafe Texture2DArray _historyTextureArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__historyTextureArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__historyTextureArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06004993 RID: 18835 RVA: 0x001759D0 File Offset: 0x00173BD0
		// (set) Token: 0x06004994 RID: 18836 RVA: 0x00023AF1 File Offset: 0x00021CF1
		public unsafe Il2CppStructArray<int> PaintedPixelHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr_PaintedPixelHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr_PaintedPixelHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06004995 RID: 18837 RVA: 0x00175A00 File Offset: 0x00173C00
		// (set) Token: 0x06004996 RID: 18838 RVA: 0x00023B10 File Offset: 0x00021D10
		public unsafe Il2CppStructArray<int> _strokeHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__strokeHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr__strokeHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06004997 RID: 18839 RVA: 0x00175A30 File Offset: 0x00173C30
		// (set) Token: 0x06004998 RID: 18840 RVA: 0x00023B2F File Offset: 0x00021D2F
		public unsafe static int MAX_UNDO_STATES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Drawing.NativeFieldInfoPtr_MAX_UNDO_STATES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Drawing.NativeFieldInfoPtr_MAX_UNDO_STATES, (void*)(&value));
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06004999 RID: 18841 RVA: 0x00175A4C File Offset: 0x00173C4C
		// (set) Token: 0x0600499A RID: 18842 RVA: 0x00023B3D File Offset: 0x00021D3D
		public unsafe Action onTextureChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr_onTextureChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.NativeFieldInfoPtr_onTextureChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031E0 RID: 12768
		private static readonly IntPtr NativeFieldInfoPtr___width_k__BackingField;

		// Token: 0x040031E1 RID: 12769
		private static readonly IntPtr NativeFieldInfoPtr___height_k__BackingField;

		// Token: 0x040031E2 RID: 12770
		private static readonly IntPtr NativeFieldInfoPtr__OutputTexture_k__BackingField;

		// Token: 0x040031E3 RID: 12771
		private static readonly IntPtr NativeFieldInfoPtr__PaintedPixelCount_k__BackingField;

		// Token: 0x040031E4 RID: 12772
		private static readonly IntPtr NativeFieldInfoPtr__HistoryIndex_k__BackingField;

		// Token: 0x040031E5 RID: 12773
		private static readonly IntPtr NativeFieldInfoPtr__HistoryCount_k__BackingField;

		// Token: 0x040031E6 RID: 12774
		private static readonly IntPtr NativeFieldInfoPtr_strokes;

		// Token: 0x040031E7 RID: 12775
		private static readonly IntPtr NativeFieldInfoPtr__historyTextureArray;

		// Token: 0x040031E8 RID: 12776
		private static readonly IntPtr NativeFieldInfoPtr_PaintedPixelHistory;

		// Token: 0x040031E9 RID: 12777
		private static readonly IntPtr NativeFieldInfoPtr__strokeHistory;

		// Token: 0x040031EA RID: 12778
		private static readonly IntPtr NativeFieldInfoPtr_MAX_UNDO_STATES;

		// Token: 0x040031EB RID: 12779
		private static readonly IntPtr NativeFieldInfoPtr_onTextureChanged;

		// Token: 0x040031EC RID: 12780
		private static readonly IntPtr NativeMethodInfoPtr_get__width_Private_get_Int32_0;

		// Token: 0x040031ED RID: 12781
		private static readonly IntPtr NativeMethodInfoPtr_set__width_Private_set_Void_Int32_0;

		// Token: 0x040031EE RID: 12782
		private static readonly IntPtr NativeMethodInfoPtr_get__height_Private_get_Int32_0;

		// Token: 0x040031EF RID: 12783
		private static readonly IntPtr NativeMethodInfoPtr_set__height_Private_set_Void_Int32_0;

		// Token: 0x040031F0 RID: 12784
		private static readonly IntPtr NativeMethodInfoPtr_get_TextureWidth_Public_get_Int32_0;

		// Token: 0x040031F1 RID: 12785
		private static readonly IntPtr NativeMethodInfoPtr_get_TextureHeight_Public_get_Int32_0;

		// Token: 0x040031F2 RID: 12786
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputTexture_Public_get_Texture2D_0;

		// Token: 0x040031F3 RID: 12787
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputTexture_Private_set_Void_Texture2D_0;

		// Token: 0x040031F4 RID: 12788
		private static readonly IntPtr NativeMethodInfoPtr_get_StrokeCount_Public_get_Int32_0;

		// Token: 0x040031F5 RID: 12789
		private static readonly IntPtr NativeMethodInfoPtr_get_PaintedPixelCount_Public_get_Int32_0;

		// Token: 0x040031F6 RID: 12790
		private static readonly IntPtr NativeMethodInfoPtr_set_PaintedPixelCount_Public_set_Void_Int32_0;

		// Token: 0x040031F7 RID: 12791
		private static readonly IntPtr NativeMethodInfoPtr_get_HistoryIndex_Public_get_Int32_0;

		// Token: 0x040031F8 RID: 12792
		private static readonly IntPtr NativeMethodInfoPtr_set_HistoryIndex_Private_set_Void_Int32_0;

		// Token: 0x040031F9 RID: 12793
		private static readonly IntPtr NativeMethodInfoPtr_get_HistoryCount_Public_get_Int32_0;

		// Token: 0x040031FA RID: 12794
		private static readonly IntPtr NativeMethodInfoPtr_set_HistoryCount_Private_set_Void_Int32_0;

		// Token: 0x040031FB RID: 12795
		private static readonly IntPtr NativeMethodInfoPtr_GetStrokes_Public_List_1_SprayStroke_0;

		// Token: 0x040031FC RID: 12796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;

		// Token: 0x040031FD RID: 12797
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Drawing_0;

		// Token: 0x040031FE RID: 12798
		private static readonly IntPtr NativeMethodInfoPtr_DrawPaintedPixel_Public_Void_PixelData_Boolean_0;

		// Token: 0x040031FF RID: 12799
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclampedFast_Public_Static_Color_Color_Color_Single_0;

		// Token: 0x04003200 RID: 12800
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTexture_Private_Void_0;

		// Token: 0x04003201 RID: 12801
		private static readonly IntPtr NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Int32_Int32_0;

		// Token: 0x04003202 RID: 12802
		private static readonly IntPtr NativeMethodInfoPtr_AddStroke_Public_Void_SprayStroke_0;

		// Token: 0x04003203 RID: 12803
		private static readonly IntPtr NativeMethodInfoPtr_AddStrokes_Public_Void_List_1_SprayStroke_0;

		// Token: 0x04003204 RID: 12804
		private static readonly IntPtr NativeMethodInfoPtr_CanUndo_Public_Boolean_0;

		// Token: 0x04003205 RID: 12805
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Void_0;

		// Token: 0x04003206 RID: 12806
		private static readonly IntPtr NativeMethodInfoPtr_CacheDrawing_Public_Void_0;

		// Token: 0x04003207 RID: 12807
		private static readonly IntPtr NativeMethodInfoPtr_RestoreFromCache_Public_Void_0;

		// Token: 0x04003208 RID: 12808
		private static readonly IntPtr NativeMethodInfoPtr_AddTextureToHistory_Public_Void_Boolean_0;

		// Token: 0x02000A72 RID: 2674
		public class DrawData : Il2CppSystem.Object
		{
			// Token: 0x0600E11A RID: 57626 RVA: 0x00374BA4 File Offset: 0x00372DA4
			// Note: this type is marked as 'beforefieldinit'.
			static DrawData()
			{
				Il2CppClassPointerStore<Drawing.DrawData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "DrawData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Drawing.DrawData>.NativeClassPtr);
				Drawing.DrawData.NativeFieldInfoPtr_DrawPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing.DrawData>.NativeClassPtr, "DrawPixels");
				Drawing.DrawData.NativeMethodInfoPtr_Add_Public_Void_DrawPixels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing.DrawData>.NativeClassPtr, 100672728);
				Drawing.DrawData.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing.DrawData>.NativeClassPtr, 100672729);
				Drawing.DrawData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing.DrawData>.NativeClassPtr, 100672730);
				Drawing.DrawData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing.DrawData>.NativeClassPtr, 100672731);
			}

			// Token: 0x0600E11B RID: 57627 RVA: 0x00374C34 File Offset: 0x00372E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168949, XrefRangeEnd = 168955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(Drawing.DrawPixels drawPixels)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drawPixels);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.DrawData.NativeMethodInfoPtr_Add_Public_Void_DrawPixels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E11C RID: 57628 RVA: 0x00374C78 File Offset: 0x00372E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168955, XrefRangeEnd = 168956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsEmpty()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.DrawData.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E11D RID: 57629 RVA: 0x00374CB4 File Offset: 0x00372EB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168956, XrefRangeEnd = 168958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.DrawData.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E11E RID: 57630 RVA: 0x00374CE8 File Offset: 0x00372EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168958, XrefRangeEnd = 168966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrawData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Drawing.DrawData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.DrawData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E11F RID: 57631 RVA: 0x0006A19C File Offset: 0x0006839C
			public DrawData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004486 RID: 17542
			// (get) Token: 0x0600E120 RID: 57632 RVA: 0x00374D24 File Offset: 0x00372F24
			// (set) Token: 0x0600E121 RID: 57633 RVA: 0x0006A1A5 File Offset: 0x000683A5
			public unsafe List<Drawing.DrawPixels> DrawPixels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.DrawData.NativeFieldInfoPtr_DrawPixels);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Drawing.DrawPixels>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.DrawData.NativeFieldInfoPtr_DrawPixels), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009938 RID: 39224
			private static readonly IntPtr NativeFieldInfoPtr_DrawPixels;

			// Token: 0x04009939 RID: 39225
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_DrawPixels_0;

			// Token: 0x0400993A RID: 39226
			private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

			// Token: 0x0400993B RID: 39227
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x0400993C RID: 39228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A73 RID: 2675
		public class DrawPixels : Il2CppSystem.Object
		{
			// Token: 0x0600E122 RID: 57634 RVA: 0x00374D54 File Offset: 0x00372F54
			// Note: this type is marked as 'beforefieldinit'.
			static DrawPixels()
			{
				Il2CppClassPointerStore<Drawing.DrawPixels>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Drawing>.NativeClassPtr, "DrawPixels");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Drawing.DrawPixels>.NativeClassPtr);
				Drawing.DrawPixels.NativeFieldInfoPtr_BottomLeftX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing.DrawPixels>.NativeClassPtr, "BottomLeftX");
				Drawing.DrawPixels.NativeFieldInfoPtr_BottomLeftY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing.DrawPixels>.NativeClassPtr, "BottomLeftY");
				Drawing.DrawPixels.NativeFieldInfoPtr_BlockWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing.DrawPixels>.NativeClassPtr, "BlockWidth");
				Drawing.DrawPixels.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drawing.DrawPixels>.NativeClassPtr, "Colors");
				Drawing.DrawPixels.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drawing.DrawPixels>.NativeClassPtr, 100672732);
			}

			// Token: 0x0600E123 RID: 57635 RVA: 0x00374DE4 File Offset: 0x00372FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168966, XrefRangeEnd = 168968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrawPixels(int bottomLeftX, int bottomLeftY, int blockWidth, Il2CppStructArray<Color> colors) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Drawing.DrawPixels>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref bottomLeftX;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottomLeftY;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockWidth;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Drawing.DrawPixels.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E124 RID: 57636 RVA: 0x0006A1C4 File Offset: 0x000683C4
			public DrawPixels(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004487 RID: 17543
			// (get) Token: 0x0600E125 RID: 57637 RVA: 0x00374E5C File Offset: 0x0037305C
			// (set) Token: 0x0600E126 RID: 57638 RVA: 0x0006A1CD File Offset: 0x000683CD
			public unsafe int BottomLeftX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.DrawPixels.NativeFieldInfoPtr_BottomLeftX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.DrawPixels.NativeFieldInfoPtr_BottomLeftX)) = value;
				}
			}

			// Token: 0x17004488 RID: 17544
			// (get) Token: 0x0600E127 RID: 57639 RVA: 0x00374E84 File Offset: 0x00373084
			// (set) Token: 0x0600E128 RID: 57640 RVA: 0x0006A1E8 File Offset: 0x000683E8
			public unsafe int BottomLeftY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.DrawPixels.NativeFieldInfoPtr_BottomLeftY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.DrawPixels.NativeFieldInfoPtr_BottomLeftY)) = value;
				}
			}

			// Token: 0x17004489 RID: 17545
			// (get) Token: 0x0600E129 RID: 57641 RVA: 0x00374EAC File Offset: 0x003730AC
			// (set) Token: 0x0600E12A RID: 57642 RVA: 0x0006A203 File Offset: 0x00068403
			public unsafe int BlockWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.DrawPixels.NativeFieldInfoPtr_BlockWidth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.DrawPixels.NativeFieldInfoPtr_BlockWidth)) = value;
				}
			}

			// Token: 0x1700448A RID: 17546
			// (get) Token: 0x0600E12B RID: 57643 RVA: 0x00374ED4 File Offset: 0x003730D4
			// (set) Token: 0x0600E12C RID: 57644 RVA: 0x0006A21E File Offset: 0x0006841E
			public unsafe Il2CppStructArray<Color> Colors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.DrawPixels.NativeFieldInfoPtr_Colors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Drawing.DrawPixels.NativeFieldInfoPtr_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400993D RID: 39229
			private static readonly IntPtr NativeFieldInfoPtr_BottomLeftX;

			// Token: 0x0400993E RID: 39230
			private static readonly IntPtr NativeFieldInfoPtr_BottomLeftY;

			// Token: 0x0400993F RID: 39231
			private static readonly IntPtr NativeFieldInfoPtr_BlockWidth;

			// Token: 0x04009940 RID: 39232
			private static readonly IntPtr NativeFieldInfoPtr_Colors;

			// Token: 0x04009941 RID: 39233
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_Color_0;
		}
	}
}

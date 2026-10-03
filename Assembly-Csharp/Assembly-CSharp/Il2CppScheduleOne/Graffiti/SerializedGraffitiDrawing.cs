using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x0200036C RID: 876
	public class SerializedGraffitiDrawing : ScriptableObject
	{
		// Token: 0x060049FD RID: 18941 RVA: 0x00176EFC File Offset: 0x001750FC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGraffitiDrawing()
		{
			Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "SerializedGraffitiDrawing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr);
			SerializedGraffitiDrawing.NativeFieldInfoPtr__DrawingName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, "<DrawingName>k__BackingField");
			SerializedGraffitiDrawing.NativeFieldInfoPtr__Width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, "<Width>k__BackingField");
			SerializedGraffitiDrawing.NativeFieldInfoPtr__Height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, "<Height>k__BackingField");
			SerializedGraffitiDrawing.NativeFieldInfoPtr__Strokes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, "<Strokes>k__BackingField");
			SerializedGraffitiDrawing.NativeMethodInfoPtr_get_DrawingName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672778);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_set_DrawingName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672779);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_get_Width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672780);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_set_Width_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672781);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_get_Height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672782);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_set_Height_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672783);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_get_Strokes_Public_get_List_1_SprayStroke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672784);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_set_Strokes_Private_set_Void_List_1_SprayStroke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672785);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_SetDrawingName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672786);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_SetStrokes_Public_Void_List_1_SprayStroke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672787);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_RecalculateSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672788);
			SerializedGraffitiDrawing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672789);
			SerializedGraffitiDrawing.NativeMethodInfoPtr_Method_Internal_Static_Void_SprayStroke_byref_UShort2_byref_UShort2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr, 100672790);
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x060049FE RID: 18942 RVA: 0x00177080 File Offset: 0x00175280
		// (set) Token: 0x060049FF RID: 18943 RVA: 0x001770B8 File Offset: 0x001752B8
		public unsafe string DrawingName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_get_DrawingName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_set_DrawingName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06004A00 RID: 18944 RVA: 0x001770FC File Offset: 0x001752FC
		// (set) Token: 0x06004A01 RID: 18945 RVA: 0x00177138 File Offset: 0x00175338
		public unsafe int Width
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_get_Width_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_set_Width_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06004A02 RID: 18946 RVA: 0x00177178 File Offset: 0x00175378
		// (set) Token: 0x06004A03 RID: 18947 RVA: 0x001771B4 File Offset: 0x001753B4
		public unsafe int Height
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_get_Height_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_set_Height_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06004A04 RID: 18948 RVA: 0x001771F4 File Offset: 0x001753F4
		// (set) Token: 0x06004A05 RID: 18949 RVA: 0x00177234 File Offset: 0x00175434
		public unsafe List<SprayStroke> Strokes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_get_Strokes_Public_get_List_1_SprayStroke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SprayStroke>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_set_Strokes_Private_set_Void_List_1_SprayStroke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x00177278 File Offset: 0x00175478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDrawingName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_SetDrawingName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x001772BC File Offset: 0x001754BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169541, XrefRangeEnd = 169543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStrokes(List<SprayStroke> strokes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_SetStrokes_Public_Void_List_1_SprayStroke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00177300 File Offset: 0x00175500
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169574, RefRangeEnd = 169576, XrefRangeStart = 169543, XrefRangeEnd = 169574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_RecalculateSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00177334 File Offset: 0x00175534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169576, XrefRangeEnd = 169588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGraffitiDrawing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGraffitiDrawing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00177370 File Offset: 0x00175570
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169592, RefRangeEnd = 169594, XrefRangeStart = 169588, XrefRangeEnd = 169592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_SprayStroke_byref_UShort2_byref_UShort2_0(SprayStroke stroke, out UShort2 min, out UShort2 max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stroke);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraffitiDrawing.NativeMethodInfoPtr_Method_Internal_Static_Void_SprayStroke_byref_UShort2_byref_UShort2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x00023E3C File Offset: 0x0002203C
		public SerializedGraffitiDrawing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06004A0C RID: 18956 RVA: 0x001773C4 File Offset: 0x001755C4
		// (set) Token: 0x06004A0D RID: 18957 RVA: 0x00023E45 File Offset: 0x00022045
		public unsafe string _DrawingName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraffitiDrawing.NativeFieldInfoPtr__DrawingName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraffitiDrawing.NativeFieldInfoPtr__DrawingName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06004A0E RID: 18958 RVA: 0x001773EC File Offset: 0x001755EC
		// (set) Token: 0x06004A0F RID: 18959 RVA: 0x00023E64 File Offset: 0x00022064
		public unsafe int _Width_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraffitiDrawing.NativeFieldInfoPtr__Width_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraffitiDrawing.NativeFieldInfoPtr__Width_k__BackingField)) = value;
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06004A10 RID: 18960 RVA: 0x00177414 File Offset: 0x00175614
		// (set) Token: 0x06004A11 RID: 18961 RVA: 0x00023E7F File Offset: 0x0002207F
		public unsafe int _Height_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraffitiDrawing.NativeFieldInfoPtr__Height_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraffitiDrawing.NativeFieldInfoPtr__Height_k__BackingField)) = value;
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06004A12 RID: 18962 RVA: 0x0017743C File Offset: 0x0017563C
		// (set) Token: 0x06004A13 RID: 18963 RVA: 0x00023E9A File Offset: 0x0002209A
		public unsafe List<SprayStroke> _Strokes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraffitiDrawing.NativeFieldInfoPtr__Strokes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SprayStroke>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraffitiDrawing.NativeFieldInfoPtr__Strokes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003254 RID: 12884
		private static readonly IntPtr NativeFieldInfoPtr__DrawingName_k__BackingField;

		// Token: 0x04003255 RID: 12885
		private static readonly IntPtr NativeFieldInfoPtr__Width_k__BackingField;

		// Token: 0x04003256 RID: 12886
		private static readonly IntPtr NativeFieldInfoPtr__Height_k__BackingField;

		// Token: 0x04003257 RID: 12887
		private static readonly IntPtr NativeFieldInfoPtr__Strokes_k__BackingField;

		// Token: 0x04003258 RID: 12888
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawingName_Public_get_String_0;

		// Token: 0x04003259 RID: 12889
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawingName_Private_set_Void_String_0;

		// Token: 0x0400325A RID: 12890
		private static readonly IntPtr NativeMethodInfoPtr_get_Width_Public_get_Int32_0;

		// Token: 0x0400325B RID: 12891
		private static readonly IntPtr NativeMethodInfoPtr_set_Width_Private_set_Void_Int32_0;

		// Token: 0x0400325C RID: 12892
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Int32_0;

		// Token: 0x0400325D RID: 12893
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Private_set_Void_Int32_0;

		// Token: 0x0400325E RID: 12894
		private static readonly IntPtr NativeMethodInfoPtr_get_Strokes_Public_get_List_1_SprayStroke_0;

		// Token: 0x0400325F RID: 12895
		private static readonly IntPtr NativeMethodInfoPtr_set_Strokes_Private_set_Void_List_1_SprayStroke_0;

		// Token: 0x04003260 RID: 12896
		private static readonly IntPtr NativeMethodInfoPtr_SetDrawingName_Public_Void_String_0;

		// Token: 0x04003261 RID: 12897
		private static readonly IntPtr NativeMethodInfoPtr_SetStrokes_Public_Void_List_1_SprayStroke_0;

		// Token: 0x04003262 RID: 12898
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateSize_Private_Void_0;

		// Token: 0x04003263 RID: 12899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003264 RID: 12900
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_SprayStroke_byref_UShort2_byref_UShort2_0;
	}
}

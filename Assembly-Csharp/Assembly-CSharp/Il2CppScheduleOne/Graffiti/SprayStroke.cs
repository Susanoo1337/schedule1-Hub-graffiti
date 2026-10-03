using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x0200036E RID: 878
	[Serializable]
	public class SprayStroke : Object
	{
		// Token: 0x06004A1F RID: 18975 RVA: 0x00177648 File Offset: 0x00175848
		// Note: this type is marked as 'beforefieldinit'.
		static SprayStroke()
		{
			Il2CppClassPointerStore<SprayStroke>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "SprayStroke");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr);
			SprayStroke.NativeFieldInfoPtr_MinStrokeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "MinStrokeLength");
			SprayStroke.NativeFieldInfoPtr_AngleThreshold_Degrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "AngleThreshold_Degrees");
			SprayStroke.NativeFieldInfoPtr_MaxStrokeDeviation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "MaxStrokeDeviation");
			SprayStroke.NativeFieldInfoPtr_ForwardSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "ForwardSampleCount");
			SprayStroke.NativeFieldInfoPtr_StrokeSize_LegacyDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "StrokeSize_LegacyDefault");
			SprayStroke.NativeFieldInfoPtr_StrokeSize_Small = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "StrokeSize_Small");
			SprayStroke.NativeFieldInfoPtr_StrokeSize_Medium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "StrokeSize_Medium");
			SprayStroke.NativeFieldInfoPtr_StrokeSize_Large = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "StrokeSize_Large");
			SprayStroke.NativeFieldInfoPtr_StrokeSize_ExtraLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "StrokeSize_ExtraLarge");
			SprayStroke.NativeFieldInfoPtr_StrokeSizePresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "StrokeSizePresets");
			SprayStroke.NativeFieldInfoPtr_StrokeSize_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "StrokeSize_Min");
			SprayStroke.NativeFieldInfoPtr_StrokeSize_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "StrokeSize_Max");
			SprayStroke.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "Start");
			SprayStroke.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "End");
			SprayStroke.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "Color");
			SprayStroke.NativeFieldInfoPtr_StrokeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, "StrokeSize");
			SprayStroke.NativeMethodInfoPtr__ctor_Public_Void_UShort2_UShort2_ESprayColor_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, 100672794);
			SprayStroke.NativeMethodInfoPtr_GetCopy_Public_SprayStroke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, 100672795);
			SprayStroke.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, 100672796);
			SprayStroke.NativeMethodInfoPtr_GetPixelsFromStroke_Public_List_1_PixelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, 100672797);
			SprayStroke.NativeMethodInfoPtr_GetStrokesFromPixels_Public_Static_List_1_SprayStroke_List_1_UShort2_ESprayColor_Byte_SpraySurface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, 100672798);
			SprayStroke.NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, 100672799);
			SprayStroke.NativeMethodInfoPtr_Deserialize_Public_Static_SprayStroke_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, 100672800);
			SprayStroke.NativeMethodInfoPtr_CopyAndShiftStrokes_Public_Static_List_1_SprayStroke_List_1_SprayStroke_UShort2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, 100672801);
			SprayStroke.NativeMethodInfoPtr_GetBounds_Public_Static_Void_List_1_SprayStroke_byref_UShort2_byref_UShort2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, 100672802);
			SprayStroke.NativeMethodInfoPtr_Method_Internal_Static_Void_SprayStroke_byref_UShort2_byref_UShort2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr, 100672804);
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x00177880 File Offset: 0x00175A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169634, XrefRangeEnd = 169635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SprayStroke(UShort2 start, UShort2 end, ESprayColor color, byte strokeSize) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strokeSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayStroke.NativeMethodInfoPtr__ctor_Public_Void_UShort2_UShort2_ESprayColor_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x001778F4 File Offset: 0x00175AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169635, XrefRangeEnd = 169639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SprayStroke GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayStroke.NativeMethodInfoPtr_GetCopy_Public_SprayStroke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SprayStroke>(intPtr3) : null;
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x00177934 File Offset: 0x00175B34
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SprayStroke() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SprayStroke>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayStroke.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x00177970 File Offset: 0x00175B70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169679, RefRangeEnd = 169681, XrefRangeStart = 169639, XrefRangeEnd = 169679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PixelData> GetPixelsFromStroke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayStroke.NativeMethodInfoPtr_GetPixelsFromStroke_Public_List_1_PixelData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PixelData>>(intPtr3) : null;
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x001779B0 File Offset: 0x00175BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169728, RefRangeEnd = 169729, XrefRangeStart = 169681, XrefRangeEnd = 169728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<SprayStroke> GetStrokesFromPixels(List<UShort2> coords, ESprayColor color, byte strokeSize, SpraySurface surface)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coords);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strokeSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayStroke.NativeMethodInfoPtr_GetStrokesFromPixels_Public_Static_List_1_SprayStroke_List_1_UShort2_ESprayColor_Byte_SpraySurface_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SprayStroke>>(intPtr3) : null;
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x00177A24 File Offset: 0x00175C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169729, XrefRangeEnd = 169740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(BinaryWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayStroke.NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x00177A68 File Offset: 0x00175C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169740, XrefRangeEnd = 169744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SprayStroke Deserialize(BinaryReader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayStroke.NativeMethodInfoPtr_Deserialize_Public_Static_SprayStroke_BinaryReader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SprayStroke>(intPtr3) : null;
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x00177AAC File Offset: 0x00175CAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169773, RefRangeEnd = 169775, XrefRangeStart = 169744, XrefRangeEnd = 169773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<SprayStroke> CopyAndShiftStrokes(List<SprayStroke> strokes, UShort2 shift)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayStroke.NativeMethodInfoPtr_CopyAndShiftStrokes_Public_Static_List_1_SprayStroke_List_1_SprayStroke_UShort2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SprayStroke>>(intPtr3) : null;
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x00177B00 File Offset: 0x00175D00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169793, RefRangeEnd = 169795, XrefRangeStart = 169775, XrefRangeEnd = 169793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetBounds(List<SprayStroke> strokes, out UShort2 min, out UShort2 max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayStroke.NativeMethodInfoPtr_GetBounds_Public_Static_Void_List_1_SprayStroke_byref_UShort2_byref_UShort2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x00177B54 File Offset: 0x00175D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169592, RefRangeEnd = 169594, XrefRangeStart = 169592, XrefRangeEnd = 169594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_SprayStroke_byref_UShort2_byref_UShort2_0(SprayStroke stroke, out UShort2 min, out UShort2 max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stroke);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayStroke.NativeMethodInfoPtr_Method_Internal_Static_Void_SprayStroke_byref_UShort2_byref_UShort2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x00023F1F File Offset: 0x0002211F
		public SprayStroke(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x00177BA8 File Offset: 0x00175DA8
		// (set) Token: 0x06004A2C RID: 18988 RVA: 0x00023F28 File Offset: 0x00022128
		public unsafe static int MinStrokeLength
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_MinStrokeLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_MinStrokeLength, (void*)(&value));
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x00177BC4 File Offset: 0x00175DC4
		// (set) Token: 0x06004A2E RID: 18990 RVA: 0x00023F36 File Offset: 0x00022136
		public unsafe static int AngleThreshold_Degrees
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_AngleThreshold_Degrees, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_AngleThreshold_Degrees, (void*)(&value));
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06004A2F RID: 18991 RVA: 0x00177BE0 File Offset: 0x00175DE0
		// (set) Token: 0x06004A30 RID: 18992 RVA: 0x00023F44 File Offset: 0x00022144
		public unsafe static float MaxStrokeDeviation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_MaxStrokeDeviation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_MaxStrokeDeviation, (void*)(&value));
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06004A31 RID: 18993 RVA: 0x00177BFC File Offset: 0x00175DFC
		// (set) Token: 0x06004A32 RID: 18994 RVA: 0x00023F52 File Offset: 0x00022152
		public unsafe static int ForwardSampleCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_ForwardSampleCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_ForwardSampleCount, (void*)(&value));
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06004A33 RID: 18995 RVA: 0x00177C18 File Offset: 0x00175E18
		// (set) Token: 0x06004A34 RID: 18996 RVA: 0x00023F60 File Offset: 0x00022160
		public unsafe static byte StrokeSize_LegacyDefault
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_LegacyDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_LegacyDefault, (void*)(&value));
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06004A35 RID: 18997 RVA: 0x00177C34 File Offset: 0x00175E34
		// (set) Token: 0x06004A36 RID: 18998 RVA: 0x00023F6E File Offset: 0x0002216E
		public unsafe static byte StrokeSize_Small
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_Small, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_Small, (void*)(&value));
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06004A37 RID: 18999 RVA: 0x00177C50 File Offset: 0x00175E50
		// (set) Token: 0x06004A38 RID: 19000 RVA: 0x00023F7C File Offset: 0x0002217C
		public unsafe static byte StrokeSize_Medium
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_Medium, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_Medium, (void*)(&value));
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x00177C6C File Offset: 0x00175E6C
		// (set) Token: 0x06004A3A RID: 19002 RVA: 0x00023F8A File Offset: 0x0002218A
		public unsafe static byte StrokeSize_Large
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_Large, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_Large, (void*)(&value));
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06004A3B RID: 19003 RVA: 0x00177C88 File Offset: 0x00175E88
		// (set) Token: 0x06004A3C RID: 19004 RVA: 0x00023F98 File Offset: 0x00022198
		public unsafe static byte StrokeSize_ExtraLarge
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_ExtraLarge, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_ExtraLarge, (void*)(&value));
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06004A3D RID: 19005 RVA: 0x00177CA4 File Offset: 0x00175EA4
		// (set) Token: 0x06004A3E RID: 19006 RVA: 0x00023FA6 File Offset: 0x000221A6
		public unsafe static Il2CppStructArray<byte> StrokeSizePresets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_StrokeSizePresets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_StrokeSizePresets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06004A3F RID: 19007 RVA: 0x00177CCC File Offset: 0x00175ECC
		// (set) Token: 0x06004A40 RID: 19008 RVA: 0x00023FB8 File Offset: 0x000221B8
		public unsafe static byte StrokeSize_Min
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_Min, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_Min, (void*)(&value));
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06004A41 RID: 19009 RVA: 0x00177CE8 File Offset: 0x00175EE8
		// (set) Token: 0x06004A42 RID: 19010 RVA: 0x00023FC6 File Offset: 0x000221C6
		public unsafe static byte StrokeSize_Max
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_Max, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SprayStroke.NativeFieldInfoPtr_StrokeSize_Max, (void*)(&value));
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06004A43 RID: 19011 RVA: 0x00177D04 File Offset: 0x00175F04
		// (set) Token: 0x06004A44 RID: 19012 RVA: 0x00023FD4 File Offset: 0x000221D4
		public unsafe UShort2 Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayStroke.NativeFieldInfoPtr_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayStroke.NativeFieldInfoPtr_Start)) = value;
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06004A45 RID: 19013 RVA: 0x00177D2C File Offset: 0x00175F2C
		// (set) Token: 0x06004A46 RID: 19014 RVA: 0x00023FEF File Offset: 0x000221EF
		public unsafe UShort2 End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayStroke.NativeFieldInfoPtr_End);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayStroke.NativeFieldInfoPtr_End)) = value;
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06004A47 RID: 19015 RVA: 0x00177D54 File Offset: 0x00175F54
		// (set) Token: 0x06004A48 RID: 19016 RVA: 0x0002400A File Offset: 0x0002220A
		public unsafe ESprayColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayStroke.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayStroke.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06004A49 RID: 19017 RVA: 0x00177D7C File Offset: 0x00175F7C
		// (set) Token: 0x06004A4A RID: 19018 RVA: 0x00024025 File Offset: 0x00022225
		public unsafe byte StrokeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayStroke.NativeFieldInfoPtr_StrokeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayStroke.NativeFieldInfoPtr_StrokeSize)) = value;
			}
		}

		// Token: 0x0400326B RID: 12907
		private static readonly IntPtr NativeFieldInfoPtr_MinStrokeLength;

		// Token: 0x0400326C RID: 12908
		private static readonly IntPtr NativeFieldInfoPtr_AngleThreshold_Degrees;

		// Token: 0x0400326D RID: 12909
		private static readonly IntPtr NativeFieldInfoPtr_MaxStrokeDeviation;

		// Token: 0x0400326E RID: 12910
		private static readonly IntPtr NativeFieldInfoPtr_ForwardSampleCount;

		// Token: 0x0400326F RID: 12911
		private static readonly IntPtr NativeFieldInfoPtr_StrokeSize_LegacyDefault;

		// Token: 0x04003270 RID: 12912
		private static readonly IntPtr NativeFieldInfoPtr_StrokeSize_Small;

		// Token: 0x04003271 RID: 12913
		private static readonly IntPtr NativeFieldInfoPtr_StrokeSize_Medium;

		// Token: 0x04003272 RID: 12914
		private static readonly IntPtr NativeFieldInfoPtr_StrokeSize_Large;

		// Token: 0x04003273 RID: 12915
		private static readonly IntPtr NativeFieldInfoPtr_StrokeSize_ExtraLarge;

		// Token: 0x04003274 RID: 12916
		private static readonly IntPtr NativeFieldInfoPtr_StrokeSizePresets;

		// Token: 0x04003275 RID: 12917
		private static readonly IntPtr NativeFieldInfoPtr_StrokeSize_Min;

		// Token: 0x04003276 RID: 12918
		private static readonly IntPtr NativeFieldInfoPtr_StrokeSize_Max;

		// Token: 0x04003277 RID: 12919
		private static readonly IntPtr NativeFieldInfoPtr_Start;

		// Token: 0x04003278 RID: 12920
		private static readonly IntPtr NativeFieldInfoPtr_End;

		// Token: 0x04003279 RID: 12921
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x0400327A RID: 12922
		private static readonly IntPtr NativeFieldInfoPtr_StrokeSize;

		// Token: 0x0400327B RID: 12923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UShort2_UShort2_ESprayColor_Byte_0;

		// Token: 0x0400327C RID: 12924
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_SprayStroke_0;

		// Token: 0x0400327D RID: 12925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400327E RID: 12926
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelsFromStroke_Public_List_1_PixelData_0;

		// Token: 0x0400327F RID: 12927
		private static readonly IntPtr NativeMethodInfoPtr_GetStrokesFromPixels_Public_Static_List_1_SprayStroke_List_1_UShort2_ESprayColor_Byte_SpraySurface_0;

		// Token: 0x04003280 RID: 12928
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

		// Token: 0x04003281 RID: 12929
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_SprayStroke_BinaryReader_0;

		// Token: 0x04003282 RID: 12930
		private static readonly IntPtr NativeMethodInfoPtr_CopyAndShiftStrokes_Public_Static_List_1_SprayStroke_List_1_SprayStroke_UShort2_0;

		// Token: 0x04003283 RID: 12931
		private static readonly IntPtr NativeMethodInfoPtr_GetBounds_Public_Static_Void_List_1_SprayStroke_byref_UShort2_byref_UShort2_0;

		// Token: 0x04003284 RID: 12932
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_SprayStroke_byref_UShort2_byref_UShort2_0;
	}
}

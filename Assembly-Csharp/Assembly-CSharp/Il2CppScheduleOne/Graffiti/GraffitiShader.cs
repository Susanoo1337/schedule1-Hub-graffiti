using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x0200036A RID: 874
	public class GraffitiShader : Il2CppSystem.Object
	{
		// Token: 0x060049D9 RID: 18905 RVA: 0x001767CC File Offset: 0x001749CC
		// Note: this type is marked as 'beforefieldinit'.
		static GraffitiShader()
		{
			Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "GraffitiShader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr);
			GraffitiShader.NativeFieldInfoPtr__kernal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, "_kernal");
			GraffitiShader.NativeFieldInfoPtr__shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, "_shader");
			GraffitiShader.NativeFieldInfoPtr__texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, "_texture");
			GraffitiShader.NativeFieldInfoPtr__width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, "_width");
			GraffitiShader.NativeFieldInfoPtr__height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, "_height");
			GraffitiShader.NativeFieldInfoPtr__strokes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, "_strokes");
			GraffitiShader.NativeFieldInfoPtr__falloffTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, "_falloffTable");
			GraffitiShader.NativeMethodInfoPtr_Initialise_Public_Void_Texture2D_Int32_Int32_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, 100672765);
			GraffitiShader.NativeMethodInfoPtr_Draw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, 100672766);
			GraffitiShader.NativeMethodInfoPtr_ClearStrokes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, 100672767);
			GraffitiShader.NativeMethodInfoPtr_AddStrokes_Public_Void_List_1_SprayStroke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, 100672768);
			GraffitiShader.NativeMethodInfoPtr_RemoveStrokes_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, 100672769);
			GraffitiShader.NativeMethodInfoPtr_CreateFalloffTables_Private_Void_Int32_Int32_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, 100672770);
			GraffitiShader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, 100672771);
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00176914 File Offset: 0x00174B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169406, XrefRangeEnd = 169448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialise(Texture2D texture, int minStrokeSize, int maxStrokeSize, AnimationCurve falloffCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minStrokeSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStrokeSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(falloffCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiShader.NativeMethodInfoPtr_Initialise_Public_Void_Texture2D_Int32_Int32_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x00176988 File Offset: 0x00174B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169448, XrefRangeEnd = 169465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiShader.NativeMethodInfoPtr_Draw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DC RID: 18908 RVA: 0x001769BC File Offset: 0x00174BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169465, XrefRangeEnd = 169466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearStrokes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiShader.NativeMethodInfoPtr_ClearStrokes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x001769F0 File Offset: 0x00174BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169466, XrefRangeEnd = 169491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStrokes(List<SprayStroke> strokes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiShader.NativeMethodInfoPtr_AddStrokes_Public_Void_List_1_SprayStroke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x00176A34 File Offset: 0x00174C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169491, XrefRangeEnd = 169495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveStrokes(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiShader.NativeMethodInfoPtr_RemoveStrokes_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00176A74 File Offset: 0x00174C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169495, XrefRangeEnd = 169503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateFalloffTables(int minFalloff, int maxFalloff, AnimationCurve falloffCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minFalloff;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxFalloff;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(falloffCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiShader.NativeMethodInfoPtr_CreateFalloffTables_Private_Void_Int32_Int32_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x00176AD4 File Offset: 0x00174CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169503, XrefRangeEnd = 169511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraffitiShader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiShader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x00023D0C File Offset: 0x00021F0C
		public GraffitiShader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x060049E2 RID: 18914 RVA: 0x00176B10 File Offset: 0x00174D10
		// (set) Token: 0x060049E3 RID: 18915 RVA: 0x00023D15 File Offset: 0x00021F15
		public unsafe int _kernal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__kernal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__kernal)) = value;
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x060049E4 RID: 18916 RVA: 0x00176B38 File Offset: 0x00174D38
		// (set) Token: 0x060049E5 RID: 18917 RVA: 0x00023D30 File Offset: 0x00021F30
		public unsafe ComputeShader _shader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__shader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__shader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x060049E6 RID: 18918 RVA: 0x00176B68 File Offset: 0x00174D68
		// (set) Token: 0x060049E7 RID: 18919 RVA: 0x00023D4F File Offset: 0x00021F4F
		public unsafe Texture2D _texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x00176B98 File Offset: 0x00174D98
		// (set) Token: 0x060049E9 RID: 18921 RVA: 0x00023D6E File Offset: 0x00021F6E
		public unsafe int _width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__width)) = value;
			}
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x00176BC0 File Offset: 0x00174DC0
		// (set) Token: 0x060049EB RID: 18923 RVA: 0x00023D89 File Offset: 0x00021F89
		public unsafe int _height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__height)) = value;
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x00176BE8 File Offset: 0x00174DE8
		// (set) Token: 0x060049ED RID: 18925 RVA: 0x00023DA4 File Offset: 0x00021FA4
		public unsafe List<GraffitiShader.StrokeData> _strokes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__strokes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GraffitiShader.StrokeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__strokes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x060049EE RID: 18926 RVA: 0x00176C18 File Offset: 0x00174E18
		// (set) Token: 0x060049EF RID: 18927 RVA: 0x00023DC3 File Offset: 0x00021FC3
		public unsafe Il2CppStructArray<float> _falloffTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__falloffTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiShader.NativeFieldInfoPtr__falloffTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400323E RID: 12862
		private static readonly IntPtr NativeFieldInfoPtr__kernal;

		// Token: 0x0400323F RID: 12863
		private static readonly IntPtr NativeFieldInfoPtr__shader;

		// Token: 0x04003240 RID: 12864
		private static readonly IntPtr NativeFieldInfoPtr__texture;

		// Token: 0x04003241 RID: 12865
		private static readonly IntPtr NativeFieldInfoPtr__width;

		// Token: 0x04003242 RID: 12866
		private static readonly IntPtr NativeFieldInfoPtr__height;

		// Token: 0x04003243 RID: 12867
		private static readonly IntPtr NativeFieldInfoPtr__strokes;

		// Token: 0x04003244 RID: 12868
		private static readonly IntPtr NativeFieldInfoPtr__falloffTable;

		// Token: 0x04003245 RID: 12869
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Void_Texture2D_Int32_Int32_AnimationCurve_0;

		// Token: 0x04003246 RID: 12870
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_0;

		// Token: 0x04003247 RID: 12871
		private static readonly IntPtr NativeMethodInfoPtr_ClearStrokes_Public_Void_0;

		// Token: 0x04003248 RID: 12872
		private static readonly IntPtr NativeMethodInfoPtr_AddStrokes_Public_Void_List_1_SprayStroke_0;

		// Token: 0x04003249 RID: 12873
		private static readonly IntPtr NativeMethodInfoPtr_RemoveStrokes_Public_Void_Int32_0;

		// Token: 0x0400324A RID: 12874
		private static readonly IntPtr NativeMethodInfoPtr_CreateFalloffTables_Private_Void_Int32_Int32_AnimationCurve_0;

		// Token: 0x0400324B RID: 12875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A75 RID: 2677
		[StructLayout(2)]
		public struct StrokeData
		{
			// Token: 0x0600E133 RID: 57651 RVA: 0x0037501C File Offset: 0x0037321C
			// Note: this type is marked as 'beforefieldinit'.
			static StrokeData()
			{
				Il2CppClassPointerStore<GraffitiShader.StrokeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraffitiShader>.NativeClassPtr, "StrokeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiShader.StrokeData>.NativeClassPtr);
				GraffitiShader.StrokeData.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader.StrokeData>.NativeClassPtr, "Start");
				GraffitiShader.StrokeData.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader.StrokeData>.NativeClassPtr, "End");
				GraffitiShader.StrokeData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader.StrokeData>.NativeClassPtr, "Color");
				GraffitiShader.StrokeData.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiShader.StrokeData>.NativeClassPtr, "Size");
				GraffitiShader.StrokeData.NativeMethodInfoPtr_get_Stride_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiShader.StrokeData>.NativeClassPtr, 100672772);
			}

			// Token: 0x1700448C RID: 17548
			// (get) Token: 0x0600E134 RID: 57652 RVA: 0x003750AC File Offset: 0x003732AC
			public unsafe static int Stride
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 169405, RefRangeEnd = 169406, XrefRangeStart = 169405, XrefRangeEnd = 169405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiShader.StrokeData.NativeMethodInfoPtr_get_Stride_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600E135 RID: 57653 RVA: 0x0006A265 File Offset: 0x00068465
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraffitiShader.StrokeData>.NativeClassPtr, ref this));
			}

			// Token: 0x04009945 RID: 39237
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x04009946 RID: 39238
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x04009947 RID: 39239
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04009948 RID: 39240
			private static readonly IntPtr NativeFieldInfoPtr_Size;

			// Token: 0x04009949 RID: 39241
			private static readonly IntPtr NativeMethodInfoPtr_get_Stride_Public_Static_get_Int32_0;

			// Token: 0x0400994A RID: 39242
			[FieldOffset(0)]
			public uint2 Start;

			// Token: 0x0400994B RID: 39243
			[FieldOffset(8)]
			public uint2 End;

			// Token: 0x0400994C RID: 39244
			[FieldOffset(16)]
			public uint Color;

			// Token: 0x0400994D RID: 39245
			[FieldOffset(20)]
			public uint Size;
		}
	}
}

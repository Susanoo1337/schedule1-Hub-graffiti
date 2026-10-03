using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000269 RID: 617
	[StructLayout(2)]
	public struct LinearColor
	{
		// Token: 0x06002AC6 RID: 10950 RVA: 0x000A6B18 File Offset: 0x000A4D18
		// Note: this type is marked as 'beforefieldinit'.
		static LinearColor()
		{
			Il2CppClassPointerStore<LinearColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LinearColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinearColor>.NativeClassPtr);
			LinearColor.NativeFieldInfoPtr_m_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_red");
			LinearColor.NativeFieldInfoPtr_m_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_green");
			LinearColor.NativeFieldInfoPtr_m_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_blue");
			LinearColor.NativeFieldInfoPtr_m_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_intensity");
			LinearColor.NativeMethodInfoPtr_get_red_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100667903);
			LinearColor.NativeMethodInfoPtr_set_red_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100667904);
			LinearColor.NativeMethodInfoPtr_get_green_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100667905);
			LinearColor.NativeMethodInfoPtr_set_green_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100667906);
			LinearColor.NativeMethodInfoPtr_get_blue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100667907);
			LinearColor.NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100667908);
			LinearColor.NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100667909);
			LinearColor.NativeMethodInfoPtr_Black_Public_Static_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100667910);
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x000A6C38 File Offset: 0x000A4E38
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x000A6C68 File Offset: 0x000A4E68
		public unsafe float red
		{
			[CallerCount(87)]
			[CachedScanResults(RefRangeStart = 1226696, RefRangeEnd = 1226783, XrefRangeStart = 1226696, XrefRangeEnd = 1226783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_red_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1294052, RefRangeEnd = 1294063, XrefRangeStart = 1294052, XrefRangeEnd = 1294052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_red_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x000A6C9C File Offset: 0x000A4E9C
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x000A6CCC File Offset: 0x000A4ECC
		public unsafe float green
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 1219142, RefRangeEnd = 1219216, XrefRangeStart = 1219142, XrefRangeEnd = 1219216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_green_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1294063, RefRangeEnd = 1294074, XrefRangeStart = 1294063, XrefRangeEnd = 1294063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_green_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x000A6D00 File Offset: 0x000A4F00
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x000A6D30 File Offset: 0x000A4F30
		public unsafe float blue
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 1226783, RefRangeEnd = 1226824, XrefRangeStart = 1226783, XrefRangeEnd = 1226824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_blue_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1294074, RefRangeEnd = 1294085, XrefRangeStart = 1294074, XrefRangeEnd = 1294074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x000A6D64 File Offset: 0x000A4F64
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1294096, RefRangeEnd = 1294107, XrefRangeStart = 1294085, XrefRangeEnd = 1294096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinearColor Convert(Color color, float intensity)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000A6DB0 File Offset: 0x000A4FB0
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1232935, RefRangeEnd = 1232971, XrefRangeStart = 1232935, XrefRangeEnd = 1232971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinearColor Black()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_Black_Public_Static_LinearColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x00012E0E File Offset: 0x0001100E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, ref this));
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x000A6DE0 File Offset: 0x000A4FE0
		// (set) Token: 0x06002AD1 RID: 10961 RVA: 0x000A6DF8 File Offset: 0x000A4FF8
		public float intensity
		{
			get
			{
				return this.m_intensity;
			}
			set
			{
				bool flag = value < 0f;
				if (flag)
				{
					throw new ArgumentOutOfRangeException(String.Concat("Intensity (", value.ToString(), ") must be positive."));
				}
				this.m_intensity = value;
			}
		}

		// Token: 0x04002457 RID: 9303
		private static readonly IntPtr NativeFieldInfoPtr_m_red;

		// Token: 0x04002458 RID: 9304
		private static readonly IntPtr NativeFieldInfoPtr_m_green;

		// Token: 0x04002459 RID: 9305
		private static readonly IntPtr NativeFieldInfoPtr_m_blue;

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeFieldInfoPtr_m_intensity;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeMethodInfoPtr_get_red_Public_get_Single_0;

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeMethodInfoPtr_set_red_Public_set_Void_Single_0;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeMethodInfoPtr_get_green_Public_get_Single_0;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeMethodInfoPtr_set_green_Public_set_Void_Single_0;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeMethodInfoPtr_get_blue_Public_get_Single_0;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0;

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeMethodInfoPtr_Black_Public_Static_LinearColor_0;

		// Token: 0x04002463 RID: 9315
		[FieldOffset(0)]
		public float m_red;

		// Token: 0x04002464 RID: 9316
		[FieldOffset(4)]
		public float m_green;

		// Token: 0x04002465 RID: 9317
		[FieldOffset(8)]
		public float m_blue;

		// Token: 0x04002466 RID: 9318
		[FieldOffset(12)]
		public float m_intensity;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x0200036B RID: 875
	public class PixelData : Object
	{
		// Token: 0x060049F0 RID: 18928 RVA: 0x00176C48 File Offset: 0x00174E48
		// Note: this type is marked as 'beforefieldinit'.
		static PixelData()
		{
			Il2CppClassPointerStore<PixelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "PixelData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PixelData>.NativeClassPtr);
			PixelData.NativeFieldInfoPtr_Coordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelData>.NativeClassPtr, "Coordinate");
			PixelData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelData>.NativeClassPtr, "Color");
			PixelData.NativeFieldInfoPtr_StrokeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelData>.NativeClassPtr, "StrokeSize");
			PixelData.NativeMethodInfoPtr_get_StrokeRadiusRoundedUp_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelData>.NativeClassPtr, 100672773);
			PixelData.NativeMethodInfoPtr_get_StrokeRadiusRoundedDown_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelData>.NativeClassPtr, 100672774);
			PixelData.NativeMethodInfoPtr__ctor_Public_Void_UShort2_ESprayColor_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelData>.NativeClassPtr, 100672775);
			PixelData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelData>.NativeClassPtr, 100672776);
			PixelData.NativeMethodInfoPtr_GetPixelStrength_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelData>.NativeClassPtr, 100672777);
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x060049F1 RID: 18929 RVA: 0x00176D18 File Offset: 0x00174F18
		public unsafe byte StrokeRadiusRoundedUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169511, XrefRangeEnd = 169515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelData.NativeMethodInfoPtr_get_StrokeRadiusRoundedUp_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x060049F2 RID: 18930 RVA: 0x00176D54 File Offset: 0x00174F54
		public unsafe byte StrokeRadiusRoundedDown
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 169519, RefRangeEnd = 169521, XrefRangeStart = 169515, XrefRangeEnd = 169519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelData.NativeMethodInfoPtr_get_StrokeRadiusRoundedDown_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x00176D90 File Offset: 0x00174F90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169522, RefRangeEnd = 169525, XrefRangeStart = 169521, XrefRangeEnd = 169522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PixelData(UShort2 coordinate, ESprayColor color, byte strokeSize) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PixelData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref coordinate;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strokeSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelData.NativeMethodInfoPtr__ctor_Public_Void_UShort2_ESprayColor_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x00176DF4 File Offset: 0x00174FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169525, XrefRangeEnd = 169534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PixelData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x00176E38 File Offset: 0x00175038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169540, RefRangeEnd = 169541, XrefRangeStart = 169534, XrefRangeEnd = 169540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPixelStrength(int pixelIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pixelIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelData.NativeMethodInfoPtr_GetPixelStrength_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x00023DE2 File Offset: 0x00021FE2
		public PixelData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x00176E84 File Offset: 0x00175084
		// (set) Token: 0x060049F8 RID: 18936 RVA: 0x00023DEB File Offset: 0x00021FEB
		public unsafe UShort2 Coordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelData.NativeFieldInfoPtr_Coordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelData.NativeFieldInfoPtr_Coordinate)) = value;
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x060049F9 RID: 18937 RVA: 0x00176EAC File Offset: 0x001750AC
		// (set) Token: 0x060049FA RID: 18938 RVA: 0x00023E06 File Offset: 0x00022006
		public unsafe ESprayColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelData.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelData.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x060049FB RID: 18939 RVA: 0x00176ED4 File Offset: 0x001750D4
		// (set) Token: 0x060049FC RID: 18940 RVA: 0x00023E21 File Offset: 0x00022021
		public unsafe byte StrokeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelData.NativeFieldInfoPtr_StrokeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelData.NativeFieldInfoPtr_StrokeSize)) = value;
			}
		}

		// Token: 0x0400324C RID: 12876
		private static readonly IntPtr NativeFieldInfoPtr_Coordinate;

		// Token: 0x0400324D RID: 12877
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x0400324E RID: 12878
		private static readonly IntPtr NativeFieldInfoPtr_StrokeSize;

		// Token: 0x0400324F RID: 12879
		private static readonly IntPtr NativeMethodInfoPtr_get_StrokeRadiusRoundedUp_Public_get_Byte_0;

		// Token: 0x04003250 RID: 12880
		private static readonly IntPtr NativeMethodInfoPtr_get_StrokeRadiusRoundedDown_Public_get_Byte_0;

		// Token: 0x04003251 RID: 12881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UShort2_ESprayColor_Byte_0;

		// Token: 0x04003252 RID: 12882
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003253 RID: 12883
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelStrength_Public_Single_Int32_0;
	}
}
